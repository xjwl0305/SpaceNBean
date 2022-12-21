using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using SpaceAndBean.IO;
using SpaceAndBean.RandomCreate;
using Excel = Microsoft.Office.Interop.Excel;

namespace SpaceAndBean.MCNP6
{
    public class AutoExec
    {
        public static int Exec_count = 0;
        public static Process p = new Process();
        public static StreamWriter myStreamWriter;
        public static ArrayList path_list = new ArrayList();
        public static void Exec_MCNP()
        {
            //watcher.Created += FileSystemWatcher_Created;
            ProcessStartInfo MCNP = new ProcessStartInfo();
            MCNP.FileName = "C:\\Windows\\System32\\cmd.exe";
            MCNP.Arguments = "/K %HOMEDRIVE%%HOMEPATH%\\mcnp_env_620.bat";
            MCNP.RedirectStandardInput = true;
            MCNP.RedirectStandardOutput = true;
            MCNP.RedirectStandardError = true;
            //MCNP.CreateNoWindow = true;
            MCNP.Verb = "runas";
            MCNP.UseShellExecute = false;
            //MCNP.UserName = "RWIZ";
            
            
            for (int i = 0; i < 10; i++)
            {
                p = Process.Start(MCNP);
                using (StreamWriter myStreamWriter = p.StandardInput)
                {
                    myStreamWriter.WriteLine("mcnp6 i=" + Program.outputFilePath + " o=C:\\result_File\\" +
                                             Path.GetFileName(Program.outputFilePath));
                }
                path_list.Add(Program.outputFilePath);
                Delay(3000);
                p.Close();
                //p.WaitForExit(-1);
                Program.CellCardArrayList = MakeCellCard.Make(Program.MaterialCardArrayList, Program.SurfaceCardArrayList);
                SaveInput.Save(Program.CellCardArrayList, Program.SurfaceCardArrayList, Program.MaterialCardArrayList,
                    Program.TallyCardArrayList);
            }
            Exec_count += 1;
            Process[] processes = Process.GetProcessesByName("mcnp6");
            while (processes.Length > 0)
            {
                foreach (var proc in processes)
                {
                    proc.CloseMainWindow();
                }
                processes = Process.GetProcessesByName("mcnp6");
            }

            // 유클리드 거리 계산
            double minDistance =
                GetDistance.Get((String)path_list[0], Decimal.Parse(Program.tally4, System.Globalization.NumberStyles.Float), Decimal.Parse(Program.tally14, System.Globalization.NumberStyles.Float), "1000000");
            int minIndex = 0;
            for (int i = 1; i < path_list.Count; i++)
            {
                double distance =
                    GetDistance.Get((String)path_list[i], Decimal.Parse(Program.tally4, System.Globalization.NumberStyles.Float), Decimal.Parse(Program.tally14, System.Globalization.NumberStyles.Float), "1000000");
                if (distance < minDistance)
                {
                    minDistance = distance;
                    minIndex = i;
                }
            }
            
            //최적해만 csv 출력합니다.
            Change_To_CSV((String)path_list[minIndex]);
            
            /*
            foreach (string path in path_list)
            {
                Change_To_CSV(path);
            }
            */
        }
        
        public static void Change_To_CSV(string path)
        {

            //string[] path = Directory.GetFiles("C:\\result_File\\", "*.txt", SearchOption.TopDirectoryOnly);
            string pattern =
                @"\s+\d{1,3}\s+\d{1,3}\s+\d{1,3}\s+[a-zA-Z0-9-+.]{8,15}\s+[a-zA-Z0-9-+.]{8,15}\s+[a-zA-Z0-9-+.]{8,15}\s+[a-zA-Z0-9-+.]{8,15}\s+";
            var excelApp = new Excel.Application();
            var workBook = excelApp.Workbooks.Add();                            // 워크북 추가
            var workSheet = workBook.Worksheets.get_Item(1) as Excel.Worksheet;

            workSheet.Cells[1, 1] = "index";
            workSheet.Cells[1, 2] = "cell";
            workSheet.Cells[1, 3] = "mat";
            workSheet.Cells[1, 4] = "atom density";
            workSheet.Cells[1, 5] = "gram density";
            workSheet.Cells[1, 6] = "volume";
            workSheet.Cells[1, 7] = "mass";
            workSheet.Cells[1, 8] = "neutron pieces";
            workSheet.Cells[1, 9] = "photon importance";
            workSheet.Cells[1, 10] = "photon wt importnace";
            workSheet.Cells[1, 11] = "generation";
            

            ArrayList data = new ArrayList();
            //string[] lines = System.IO.File.ReadAllLines("C:\\result_File\\"+Path.GetFileName(Program.outputFilePath));

            using (StreamReader sr = new StreamReader("C:\\result_File\\" + Path.GetFileName(path)))
            {
                int count = 0;
                while (!sr.EndOfStream)
                {
                    string lines = sr.ReadLine();
                    int count2 = 1;
                    if (Regex.IsMatch(lines, pattern))
                    {
                        string d = lines;
                        //data.Add(lines[j].Split(' ').Where(line => !string.IsNullOrEmpty(line)).Select(line => line.Trim()));
                        IEnumerable<string> query = lines.Split(' ').Where(line => !string.IsNullOrEmpty(line))
                            .Select(line => line.Trim());
                        foreach (string value in query)
                        {
                            workSheet.Cells[2 + count, count2] = value;
                            count2 += 1;
                        }
                        count += 1;
                    }
                }
            }
            workSheet.Columns.AutoFit();                                    // 열 너비 자동 맞춤
            string excel_path = Path.Combine(@"C:\excel_File\", Path.GetFileNameWithoutExtension(path)+".xlsx");
            workBook.SaveAs(excel_path, Excel.XlFileFormat.xlWorkbookDefault);    // 엑셀 파일 저장

            workBook.Close(true);
            excelApp.Quit();
        }
        private static DateTime Delay(int MS)
        {
            // Thread 와 Timer보다 효율 적으로 사용할 수 있음.
            DateTime ThisMoment = DateTime.Now;
            TimeSpan duration = new TimeSpan(0, 0, 0, 0, MS);
            DateTime AfterWards = ThisMoment.Add(duration);

            while (AfterWards >= ThisMoment)
            {
                System.Windows.Forms.Application.DoEvents();
                ThisMoment = DateTime.Now;
            }
            return DateTime.Now;
        }
    }
    
}