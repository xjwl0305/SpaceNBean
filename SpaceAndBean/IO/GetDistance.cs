using System;
using System.IO;
using System.Security.Cryptography.X509Certificates;

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
            double result = 0;
            
            StreamReader sr = new StreamReader(@path);
            bool flag = false;  //Tally Chart 찾으면 true로 변환
            while (sr.Peek() >= 0)
            {
                String s = sr.ReadLine();
                if (s.Replace(" ", "") == "1tallyfluctuationcharts")
                {
                    // Tally Chart 찾음
                    flag = true;
                    continue;
                }

                if (flag)
                {

                    String[] TallyTexts = s.Split(new string[] { "   " }, StringSplitOptions.None);
                    String targetNps = TallyTexts[0].Replace(" ", "");
                    if (targetNps.Equals(nps))
                    {
                        // 비교하고자 하는 nps의 값이 맞다면
                        String Tally4Text = TallyTexts[1];
                        String Tally14Text = TallyTexts[2];

                        decimal Tally4Mean = Decimal.Parse(Tally4Text.Split(' ')[0]);
                        decimal Tally14Mean = Decimal.Parse(Tally14Text.Split(' ')[0]);
                        
                        result = Math.Sqrt((Math.Pow(Decimal.ToDouble(x1 - Tally4Mean), 2) + Math.Pow(Decimal.ToDouble(y1 - Tally14Mean), 2)));
                        break;
                    }
                }
            }


            return result;
        }
    }
}