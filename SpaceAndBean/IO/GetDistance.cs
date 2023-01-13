using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Windows.Forms;

namespace SpaceAndBean.IO
{
    public class GetDistance
    {
        public static double Get(decimal x1, decimal y1, decimal x2, decimal y2)
        {
            double result = Math.Sqrt((Math.Pow(Decimal.ToDouble(x1 - x2), 2) + Math.Pow(Decimal.ToDouble(y1 - y2), 2)));

            return result;
        }

        // x1 : Tally4, y1 : Tally14
        public static double Get(String path, decimal x1, decimal y1, String nps)
        {
            double result = -1;

            if (!Access.IsAccessAble(path))
            {
                Thread.Sleep(1000);
                return Get(path, x1, y1, nps);
            }
            StreamReader sr = new StreamReader(@path);
            String all = "";
            bool flag = false;  //Tally Chart 찾으면 true로 변환
            while (sr.Peek() > 0)
            {
                String s = sr.ReadLine();
                all += s;
                if (s.Replace(" ", "").Contains("1tallyfluctuationcharts"))
                {
                    // Tally Chart 찾음
                    flag = true;
                    sr.ReadLine();
                    sr.ReadLine();
                    continue;
                }

                if (flag)
                {
                    IEnumerable<string> query = s.Split(' ').Where(line => !string.IsNullOrEmpty(line))
                        .Select(line => line.Trim());
                    List<String> list = query.ToList();
                    //MessageBox.Show("첫번째 요소:"+list[0]);
                    
                    if (list.Count > 0 && list[0].Equals(nps))
                    {
                        String Tally4Text = list[1];
                        String Tally14Text = list[6];
                        decimal Tally4Mean = Decimal.Parse(Tally4Text.Split(' ')[0], System.Globalization.NumberStyles.Float);
                        decimal Tally14Mean = Decimal.Parse(Tally14Text.Split(' ')[0], System.Globalization.NumberStyles.Float);
                    
                        result = Math.Sqrt((Math.Pow(Decimal.ToDouble(x1 - Tally4Mean), 2) + Math.Pow(Decimal.ToDouble(y1 - Tally14Mean), 2)));
                        break;
                    }
                    
                    /*
                    String[] TallyTexts = s.Split(new string[] { "   " }, StringSplitOptions.None);
                    String targetNps = TallyTexts[0].Replace(" ", "");
                    if (targetNps.Equals(nps))
                    {
                        // 비교하고자 하는 nps의 값이 맞다면
                        String Tally4Text = TallyTexts[1];
                        String Tally14Text = TallyTexts[2];

                        decimal Tally4Mean = Decimal.Parse(Tally4Text.Split(' ')[0], System.Globalization.NumberStyles.Float);
                        decimal Tally14Mean = Decimal.Parse(Tally14Text.Split(' ')[0], System.Globalization.NumberStyles.Float);
                    
                        result = Math.Sqrt((Math.Pow(Decimal.ToDouble(x1 - Tally4Mean), 2) + Math.Pow(Decimal.ToDouble(y1 - Tally14Mean), 2)));
                        break;
                    }
                    */
                }
            }
            
            
            sr.Close();
            
            return result;
        }
    }
}