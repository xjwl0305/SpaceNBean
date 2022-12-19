using System;
using System.Collections;
using System.IO;
using System.Windows.Forms;

namespace SpaceAndBean.IO
{
    public class SaveInput
    {
        public static ArrayList CollectionToArrayList(DataGridViewRowCollection collection)
        {
            ArrayList arrayList = new ArrayList();
            for (int i = 0; i < collection.Count - 1; i++)
            {
                DataGridViewRow row = collection[i];
                String[] data = new string[row.Cells.Count];

                for (int j = 0; j < row.Cells.Count; j++)
                {
                    //빈칸검사

                    if (row.Cells[j].Value == null) data[j] = "";
                    else data[j] = row.Cells[j].Value.ToString().Trim();
                }

                arrayList.Add(data);
            }

            return arrayList;
        }
        
        public static String Save(ArrayList cellCardRow,  ArrayList surfaceCardRow,  ArrayList materialCardRow,  ArrayList tallyCardRow)
        {
            DateTime today = DateTime.Today;
            String filename = DateTime.Now.ToString("yyyy_MM_dd_HH_mm_ss"); 
            //String filename = String.Format("{0}_{1}_{2}_{3}_{4}_{5}.txt", 
            //    today.Year.ToString(), today.Month.ToString(), today.Day.ToString(), today.Hour.ToString(), today.Minute.ToString(), today.Second.ToString());
            
            String savePath = @Program.outputFileDir + @"\" + @filename + @"_result.txt";
            Program.outputFilePath = @Program.outputFileDir +@"\" + @filename + @"_result.txt";
            String resultPath = @"C:\result_File\" + @filename + @"_result.txt";
            
            FileStream fs = new FileStream(savePath, FileMode.OpenOrCreate);
            StreamWriter sw = new StreamWriter(fs);
            
            // Material Index Array
            ArrayList materialIndexArrayList = new ArrayList();

            //파일이름
            sw.WriteLine(filename.Split('.')[0]);
            sw.WriteLine("c mcnp6 i={0} o={1} $ exe command ", @savePath, resultPath);
            
            //input, output 경로 정의

            //Cell Card
            sw.WriteLine("c cell cards");
            
            //Cell Card Basic
            for (int i = 0; i < Program.CellCardBasic.Count; i++)
            {
                sw.WriteLine((String)Program.CellCardBasic[i]);
                materialIndexArrayList.Add(Program.CellCardBasic[i].ToString().Split(' ')[0]);
            }
            
            //Cell Card
            for (int i = 0; i < cellCardRow.Count; i++)
            {
                String[] data = new string[8];
                String[] row = (String[])cellCardRow[i];
                for (int j = 0; j < row.Length; j++)
                {
                    //빈칸검사
                    if (row[j] == null) data[j] = "";
                    else data[j] = row[j].Trim();
                }

                String str = String.Format("{0}     {1} {2} {3} {4} {5}", data[0], data[1], data[2], data[3], data[4],
                    data[5]);
                materialIndexArrayList.Add(data[0]);
                sw.WriteLine(str);
            }
            
            //Cell Card Air
            
            String airCellCard = String.Format("{0}     1   -51", (Int64.Parse((String)materialIndexArrayList[materialIndexArrayList.Count-1]) + 1).ToString());
            String impOption = " imp:p=1 imp:n=1";
            for (int i = 0; i < materialIndexArrayList.Count; i++)
            {
                airCellCard += String.Format(" #{0}", (String)(materialIndexArrayList[i]));
                if ((airCellCard + impOption).Length > 124)
                {
                    sw.WriteLine(airCellCard);
                    airCellCard = "     ";
                }
            }
            sw.WriteLine(airCellCard + impOption);
            

            sw.WriteLine("");
            //Surface Card
            sw.WriteLine("c surface cards");
            
            //Surface Basic
            for (int i = 0; i < Program.SurfaceCardBasic.Count; i++)
            {
                sw.WriteLine((String)Program.SurfaceCardBasic[i]);
            }
            
            //Surface Card
            for (int i = 0; i < surfaceCardRow.Count; i++)
            {
                String[] row = (String[])surfaceCardRow[i];
                String[] data = new string[12];
                for (int j = 0; j < row.Length; j++)
                {
                    //빈칸검사
                    if (row[j] == null) data[j] = "";
                    else data[j] = row[j].Trim();
                }

                sw.WriteLine("{0}     px {1}", data[0], data[1]);
                sw.WriteLine("{0}     px {1}", data[2], data[3]);
                sw.WriteLine("{0}     py {1}", data[4], data[5]);
                sw.WriteLine("{0}     py {1}", data[6], data[7]);
                sw.WriteLine("{0}     pz {1}", data[8], data[9]);
                sw.WriteLine("{0}     pz {1}", data[10], data[11]);
                
            }

            sw.WriteLine("");
            
            //Data cards
            sw.WriteLine("c data cards");
            for (int i = 0; i < Program.DataCardBasic.Count; i++)
            {
                sw.WriteLine((String)Program.DataCardBasic[i]);
            }
            
            //Material Card
            sw.WriteLine("c material cards");
            
            //Material Card Basic
            for (int i = 0; i < Program.MaterialCardBasic.Count; i++)
            {
                sw.WriteLine((String)Program.MaterialCardBasic[i]);
            }
            
            //Material Card
            for (int i = 0; i < materialCardRow.Count; i++)
            {
                String[] row = (String[])materialCardRow[i];
                String[] data = new string[5];
                for (int j = 0; j < row.Length; j++)
                {
                    //빈칸검사
                    if (row[j] == null) data[j] = "";
                    else data[j] = row[j].Trim();
                }

                if (i > 0 && data[0] == ((String[])materialCardRow[i-1])[0])
                {
                    String str = String.Format("         {0} {1} {2} {3}", data[1], data[2], data[3], data[4]);
                    sw.WriteLine(str);
                }
                else
                {
                    String str = String.Format("{0}     {1} {2} {3} {4}", data[0], data[1], data[2], data[3], data[4]);
                    sw.WriteLine(str);
                }

                
            }

            //Tally Card
            sw.WriteLine("c tally cards");
            
            //Tally Card Basic
            for (int i = 0; i < Program.TallyCardBasic.Count; i++)
            {
                sw.WriteLine((String)Program.TallyCardBasic[i]);
            }
            
            //Tally Card
            for (int i = 0; i < tallyCardRow.Count; i++)
            {
                String[] row = (String[])tallyCardRow[i];
                String[] data = new string[3];
                for (int j = 0; j < row.Length; j++)
                {
                    //빈칸검사
                    if (row[j] == null) data[j] = "";
                    else data[j] = row[j].Trim();
                }
                String str = String.Format("{0}:{1} {2}", data[0], data[1], data[2]);
                sw.WriteLine(str);
            }
            
            sw.Close();
            fs.Close();
                
            try
            {
                
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message.ToString() );
            }


            return savePath;
        }
    }
}