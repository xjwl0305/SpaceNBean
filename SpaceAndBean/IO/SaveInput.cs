using System;
using System.IO;
using System.Windows.Forms;

namespace SpaceAndBean.IO
{
    public class SaveInput
    {
        public static bool Save(String fileName, DataGridViewRowCollection cellCardRow,  DataGridViewRowCollection surfaceCardRow,  DataGridViewRowCollection materialCardRow,  DataGridViewRowCollection tallyCardRow)
        {
            string savePath = @Program.outputFilePath + @"\" + @fileName;
            FileStream fs = new FileStream(savePath, FileMode.OpenOrCreate);
            StreamWriter sw = new StreamWriter(fs);
            
            
            //파일이름
            sw.WriteLine(fileName.Split('.')[0]);
            sw.WriteLine("c mcnp6 i={0} o={1} $ exe command ", @Program.inputFilePath, @savePath);
            
            //input, output 경로 정의

            //Cell Card
            sw.WriteLine("c cell cards");
            
            //Cell Card Basic
            for (int i = 0; i < Program.CellCardBasic.Count; i++)
            {
                sw.WriteLine((String)Program.CellCardBasic[i]);
            }
            
            //Cell Card
            for (int i = 0; i < cellCardRow.Count - 1; i++)
            {
                String[] data = new string[8];
                DataGridViewRow row = cellCardRow[i];
                for (int j = 0; j < row.Cells.Count; j++)
                {
                    //빈칸검사
                    if (row.Cells[j].Value == null) data[j] = "";
                    else data[j] = row.Cells[j].Value.ToString().Trim();
                }

                String str = String.Format("{0}     {1} {2} {3} {4} {5}", data[0], data[1], data[2], data[3], data[4],
                    data[5]);
                sw.WriteLine(str);
            }

            sw.WriteLine("");
            //Surface Card
            sw.WriteLine("c surface cards");
            
            //Surface Basic
            for (int i = 0; i < Program.SurfaceCardBasic.Count; i++)
            {
                sw.WriteLine((String)Program.SurfaceCardBasic[i]);
            }
            
            //Surface Card
            for (int i = 0; i < surfaceCardRow.Count - 1; i++)
            {
                DataGridViewRow row = surfaceCardRow[i];
                String[] data = new string[12];
                for (int j = 0; j < row.Cells.Count; j++)
                {
                    //빈칸검사
                    if (row.Cells[j].Value == null) data[j] = "";
                    else data[j] = row.Cells[j].Value.ToString().Trim();
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
            for (int i = 0; i < materialCardRow.Count - 1; i++)
            {
                DataGridViewRow row = materialCardRow[i];
                String[] data = new string[5];
                for (int j = 0; j < row.Cells.Count; j++)
                {
                    //빈칸검사
                    if (row.Cells[j].Value == null) data[j] = "";
                    else data[j] = row.Cells[j].Value.ToString().Trim();
                }

                if (i > 0 && data[0] == materialCardRow[i-1].Cells[0].Value.ToString() )
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
            for (int i = 0; i < tallyCardRow.Count - 1; i++)
            {
                DataGridViewRow row = tallyCardRow[i];
                String[] data = new string[3];
                for (int j = 0; j < row.Cells.Count; j++)
                {
                    //빈칸검사
                    if (row.Cells[j].Value == null) data[j] = "";
                    else data[j] = row.Cells[j].Value.ToString().Trim();
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


            return true;
        }
    }
}