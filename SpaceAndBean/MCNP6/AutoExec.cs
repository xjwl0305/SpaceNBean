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
        public static ProcessStartInfo MCNP;
        public static ArrayList path_list = new ArrayList();
        public static FileSystemWatcher watcher;
        public static NorisProgress NorisProgress;
        private static int EXEC_COUNT = 10; //mcnp 실행횟수
        public static void Exec_MCNP()
        {
            // 파일 생성 감지
            EXEC_COUNT = Int32.Parse(Program.executeNum);
            NorisProgress = new NorisProgress(0, EXEC_COUNT+1,"Init..");
            NorisProgress.Show();
            watcher = new FileSystemWatcher(@Program.resultPathDir+@"\");
            watcher.Filter = "*.txt";
            watcher.IncludeSubdirectories = true;
            watcher.EnableRaisingEvents = true;
            watcher.Created += FileSystemWatcher_Created;
            MCNP = new ProcessStartInfo();
            MCNP.FileName = @"cmd";
            //MCNP.Arguments = "/k %HOMEDRIVE%%HOMEPATH%\\mcnp_env_620.bat";
            MCNP.RedirectStandardInput = true;
            MCNP.RedirectStandardOutput = true;
            MCNP.RedirectStandardError = true;
            MCNP.CreateNoWindow = true;
            MCNP.Verb = "runas";
            MCNP.UseShellExecute = false;
            //MCNP.UserName = "RWIZ";
            
            
            //myStreamWriter = p.StandardInput;
            
            Exec_command();
            /*for (int i = 0; i < 10; i++)
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
            */
            /*
            foreach (string path in path_list)
            {
                Change_To_CSV(path);
            }
            */
        }

        public static void Exec_command()
        {

            if (Exec_count > EXEC_COUNT)
            {
                // 유클리드 거리 계산
                NorisProgress.Close();
                NorisProgress = new NorisProgress(0, EXEC_COUNT+1, "Init..");
                NorisProgress.Show();
                NorisProgress.update("Calculate " + Path.GetFileName((String)path_list[0]), 1);

                while (!Access.IsAccessAble((String)path_list[0]))
                {
                    Application.DoEvents();
                    Thread.Sleep(100);
                }
                
                double minDistance =
                    GetDistance.Get((String)path_list[0],
                        Decimal.Parse(Program.tally4, System.Globalization.NumberStyles.Float),
                        Decimal.Parse(Program.tally14, System.Globalization.NumberStyles.Float), "1000000");

                int minIndex = 0;
                for (int i = 1; i < path_list.Count; i++)
                {
                    Application.DoEvents();
                    NorisProgress.Invoke(new Action((() =>
                    {
                        NorisProgress.update("Calculate " + Path.GetFileName((String)path_list[i]), 1);
                    })));
                    
                    while (!Access.IsAccessAble((String)path_list[i]))
                    {
                        Application.DoEvents();
                        Thread.Sleep(100);

                    }
                    double distance =
                        GetDistance.Get((String)path_list[i],
                            Decimal.Parse(Program.tally4, System.Globalization.NumberStyles.Float),
                            Decimal.Parse(Program.tally14, System.Globalization.NumberStyles.Float), "1000000");
                    if (distance < 0)
                    {
                        continue;
                    }
                    
                    if (distance < minDistance)
                    {
                        minDistance = distance;
                        minIndex = i;
                    }
                }
                NorisProgress.Close();
                NorisProgress = null;
                
                //최적해만 csv 출력합니다.
                Change_To_CSV((String)path_list[minIndex]);
                watcher.Created -= FileSystemWatcher_Created;
                MessageBox.Show("Done");
                return;
                
            }
            
            p = Process.Start(MCNP);
            
            myStreamWriter = p.StandardInput;
            NorisProgress.update("mcnp6 "+Path.GetFileName(Program.inputFilePath),1);
            myStreamWriter.WriteLine("del runt*");
            myStreamWriter.WriteLine("cmd /k %HOMEDRIVE%%HOMEPATH%\\mcnp_env_620.bat");
            myStreamWriter.WriteLine("mcnp6 i=" + Program.inputFilePath + " o=" + @Program.resultPathDir + "\\" + Path.GetFileName(Program.inputFilePath));
            
            path_list.Add(@Program.resultPathDir + "\\" + Path.GetFileName(Program.inputFilePath));
            
            
            
            /*using (StreamWriter myStreamWriter = p.StandardInput)
            {
                myStreamWriter.WriteLine("mcnp6 i=" + Program.outputFilePath + " o=C:\\result_File\\" +
                                         Path.GetFileName(Program.outputFilePath));
            }*/
            
        }
        
        public static void FileSystemWatcher_Created(object sender, FileSystemEventArgs e)
        {
            try
            {
                //myStreamWriter.Close();
                double pxStart = Double.Parse(Program.var_inputs[0]);
                double pxEnd = Double.Parse(Program.var_inputs[1]);
                double pyStart = Double.Parse(Program.var_inputs[2]);
                double pyEnd = Double.Parse(Program.var_inputs[3]);
                double pzStart = Double.Parse(Program.var_inputs[4]);
                double pzEnd = Double.Parse(Program.var_inputs[5]);

                Program.SurfaceCardArrayList = MakeSurfaceCard.Make(Program.MaterialCardArrayList, pxStart, pxEnd, pyStart, pyEnd, pzStart, pzEnd);
                Program.CellCardArrayList =
                    MakeCellCard.Make(Program.MaterialCardArrayList, Program.SurfaceCardArrayList);
                SaveInput.Save(Program.CellCardArrayList, Program.SurfaceCardArrayList, Program.MaterialCardArrayList,
                    Program.TallyCardArrayList);
                
                //Delay(3000);
                Exec_count += 1;
                Exec_command();
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.ToString());
            }
        }
        
        public static void Change_To_CSV(string path)
        {
            if (!Access.IsAccessAble(path))
            {
                Thread.Sleep(1000);
                Change_To_CSV(path);
                return;
            }
            
            //string[] path = Directory.GetFiles("C:\\result_File\\", "*.txt", SearchOption.TopDirectoryOnly);
            string pattern =
                @"\s+\d{1,3}\s+\d{1,3}\s+\d{1,3}\s+[a-zA-Z0-9-+.]{8,15}\s+[a-zA-Z0-9-+.]{8,15}\s+[a-zA-Z0-9-+.]{8,15}\s+[a-zA-Z0-9-+.]{8,15}\s+\d\s+[a-zA-Z0-9-+.]{8,15}\s+[a-zA-Z0-9-+.]{8,15}\s+[a-zA-Z0-9-+.]{8,15}";
            string pattern1 =
                @"\s+\d{1,8}\s+[a-zA-Z0-9-+.]{8,15}\s+[a-zA-Z0-9-+.]{1,15}\s+[a-zA-Z0-9-+.]{1,15}\s+[a-zA-Z0-9-+.]{1,15}\s+\d{1,6}\s+[a-zA-Z0-9-+.]{8,15}\s+[a-zA-Z0-9-+.]{1,15}\s+[a-zA-Z0-9-+.]{1,15}\s+[a-zA-Z0-9-+.]{1,15}\s+\d{1,6}";
            
            var excelApp = new Excel.Application();
            var workBook = excelApp.Workbooks.Add();                            // 워크북 추가
            var workSheet = workBook.Worksheets.get_Item(1) as Excel.Worksheet;
            var workSheet1 = workBook.Worksheets.Add(After: workBook.Worksheets.Item[workBook.Worksheets.Count]) as Excel.Worksheet;

            workSheet.Name = "print 60";
            workSheet1.Name = "1tally";

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

            workSheet1.Cells[1, 2] = "tally4";
            workSheet1.Cells[1, 7] = "tally14";
            workSheet1.Cells[2, 1] = "nps";
            workSheet1.Cells[2, 2] = "mean";
            workSheet1.Cells[2, 3] = "error";
            workSheet1.Cells[2, 4] = "vov";
            workSheet1.Cells[2, 5] = "slope";
            workSheet1.Cells[2, 6] = "fom";
            workSheet1.Cells[2, 7] = "mean";
            workSheet1.Cells[2, 8] = "error";
            workSheet1.Cells[2, 9] = "vov";
            workSheet1.Cells[2, 10] = "slope";
            workSheet1.Cells[2, 11] = "fom";


            ArrayList data = new ArrayList();
            //string[] lines = System.IO.File.ReadAllLines("C:\\result_File\\"+Path.GetFileName(Program.outputFilePath));

            try
            {
            using (StreamReader sr = new StreamReader(@Program.resultPathDir + @"\" + Path.GetFileName(path)))
                {
                    int count = 0;
                    int count_tally = 0;
                    while (!sr.EndOfStream)
                    {
                        string lines = sr.ReadLine();
                        int count2 = 1;
                        int count_tally2 = 1;
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

                        if (Regex.IsMatch(lines, pattern1))
                        {
                            
                            IEnumerable<string> query = lines.Split(' ').Where(line => !string.IsNullOrEmpty(line))
                                .Select(line => line.Trim());
                            foreach (string value in query)
                            {
                                workSheet1.Cells[3 + count_tally, count_tally2] = value;
                                count_tally2 += 1;
                            }
                            count_tally += 1;
                        }
                    }
                }
                workSheet.Columns.AutoFit();                                    // 열 너비 자동 맞춤
                workSheet1.Columns.AutoFit();
                String excel_path = Path.Combine(@Program.excelPathDir+@"\", Path.GetFileNameWithoutExtension(path)+".xlsx");
                workBook.SaveAs(excel_path, Excel.XlFileFormat.xlWorkbookDefault);    // 엑셀 파일 저장

                workBook.Close(true);
                excelApp.Quit();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            
        }
        public static DateTime Delay(int MS)
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