using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SpaceAndBean.RandomCreate;

namespace SpaceAndBean
{
    static class Program
    {
        // 기본 데이터들
        public static StringBuilder input_data = new StringBuilder();
        public static ArrayList cell_cards_basic = new ArrayList();
        public static ArrayList surface_cards_basic = new ArrayList();
        public static ArrayList data_cards_basic = new ArrayList();
        public static ArrayList source_cards_basic = new ArrayList();
        public static ArrayList material_cards_basic = new ArrayList();
        public static ArrayList tally_cards_basic = new ArrayList();

        public static ArrayList CellCardBasic = new ArrayList();
        public static ArrayList SurfaceCardBasic = new ArrayList();
        public static ArrayList DataCardBasic = new ArrayList();
        public static ArrayList SourceCardBasic = new ArrayList();
        public static ArrayList MaterialCardBasic = new ArrayList();
        public static ArrayList TallyCardBasic = new ArrayList();

        // 자동생성 및 VAR_INPUT ArrayList
        public static ArrayList CellCardArrayList = new ArrayList();
        public static ArrayList SurfaceCardArrayList = new ArrayList();
        public static ArrayList MaterialCardArrayList = new ArrayList();
        public static ArrayList TallyCardArrayList = new ArrayList();
        
        public static String[] var_inputs = new String[6];
        public static String inputFilePath = null;
        public static String outputFilePath = null;
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            DirectoryInfo di = new DirectoryInfo(@"C:\input_File");
            DirectoryInfo di2 = new DirectoryInfo(@"C:\output_File");
            DirectoryInfo di3 = new DirectoryInfo(@"C:\basic_File");
            if (di.Exists == false)
            {
                di.Create();
            }
            if (di2.Exists == false)
            {
                di2.Create();
            }
            if (di2.Exists == false)
            {
                di3.Create();
            }
            //String basic_path = @"C:\basic_File\a_ne_2.txt";
            //ReadBasic(basic_path);
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MaterialInputForm());
            
            
        }

        public static void CreateBasic()
        {
            int materialCardCound = MaterialCardArrayList.Count;
            double pxStart = Double.Parse(var_inputs[0]);
            double pxEnd = Double.Parse(var_inputs[1]);
            double pyStart = Double.Parse(var_inputs[2]);
            double pyEnd = Double.Parse(var_inputs[3]);
            double pzStart = Double.Parse(var_inputs[4]);
            double pzEnd = Double.Parse(var_inputs[5]);

            SurfaceCardArrayList.AddRange(MakeSurfaceCard.Make(materialCardCound, pxStart, pxEnd, pyStart, pyEnd, pzStart, pzEnd));
            CellCardArrayList.AddRange(MakeCellCard.Make(MaterialCardArrayList, SurfaceCardArrayList));
        }
        
        
        public static void ReadBasic(String basic_path)
        {
            // basic file 한줄 씩 읽기
            StreamReader sr = new StreamReader(@"C:\basic_File\a_ne_2.txt");
            String input_file_name = "input_"+DateTime.Now.ToString("yyyy-MM-dd_hh:mm:ss");
            String output_file_name = "output_"+DateTime.Now.ToString("yyyy-MM-dd_hh:mm:ss");
            // 제목 입력
            input_data.AppendLine(input_file_name);
            // input file , output file 경로 입력
            String io_path = "c mncp6 i=" + @"C:\input_file\" + input_file_name + ".txt " + @"o=C:\output_file\" +
                             output_file_name + ".txt";
            input_data.AppendLine(io_path);
            // cell card basic 입력
            int cell_cards_buffer = 0;
            int surface_cards_buffer = 0;
            int data_cards_buffer = 0;
            int source_cards_buffer = 0;
            int material_cards_buffer = 0;
            int tally_cards_buffer = 0;
            char[] delimiterChars = { ' ', ':' };
            string material_stack = "";
            while (sr.Peek() >= 0) 
            {
                String s = sr.ReadLine().ToString();
                if (s.Replace(" ", "") == "ccellcards")
                {
                    cell_cards_buffer = 1;
                    surface_cards_buffer = 0;
                    data_cards_buffer = 0;
                    source_cards_buffer = 0;
                    material_cards_buffer = 0;
                    tally_cards_buffer = 0;
                    input_data.AppendLine("c cell cards");
                    continue;
                }
                if (s.Replace(" ", "") == "csurfacecards")
                {
                    surface_cards_buffer = 1;
                    cell_cards_buffer = 0;
                    data_cards_buffer = 0;
                    source_cards_buffer = 0;
                    material_cards_buffer = 0;
                    tally_cards_buffer = 0;
                    input_data.AppendLine("c surface cards");
                    continue;
                }
                if (s.Replace(" ", "") == "cdatacards")
                {
                    data_cards_buffer = 1;
                    cell_cards_buffer = 0;
                    surface_cards_buffer = 0;
                    source_cards_buffer = 0;
                    material_cards_buffer = 0;
                    tally_cards_buffer = 0;
                    input_data.AppendLine("c data cards");
                    continue;
                }
                if (s.Replace(" ", "") == "csourcecards")
                {
                    source_cards_buffer = 1;
                    cell_cards_buffer = 0;
                    surface_cards_buffer = 0;
                    data_cards_buffer = 0;
                    material_cards_buffer = 0;
                    tally_cards_buffer = 0;
                    input_data.AppendLine("c source cards");
                    continue;
                }
                if (s.Replace(" ", "") == "cmaterialcards")
                {
                    material_cards_buffer = 1;
                    cell_cards_buffer = 0;
                    surface_cards_buffer = 0;
                    data_cards_buffer = 0;
                    source_cards_buffer = 0;
                    tally_cards_buffer = 0;
                    input_data.AppendLine("c material cards");
                    continue;
                }
                if (s.Replace(" ", "") == "ctallycards")
                {
                    tally_cards_buffer = 1;
                    cell_cards_buffer = 0;
                    surface_cards_buffer = 0;
                    data_cards_buffer = 0;
                    source_cards_buffer = 0;
                    material_cards_buffer = 0;
                    input_data.AppendLine("c tally cards");
                    continue;
                }
                if (s == "")
                {
                    cell_cards_buffer = 0;
                    surface_cards_buffer = 0;
                    data_cards_buffer = 0;
                    source_cards_buffer = 0;
                    material_cards_buffer = 0;
                    tally_cards_buffer = 0;
                    input_data.AppendLine();
                }
                if (cell_cards_buffer == 1)
                {
                    CellCardBasic.Add(s);
                    string[] words = s.Split(delimiterChars, StringSplitOptions.RemoveEmptyEntries);
                    cell_cards_basic.Add(words);
                }
                if (surface_cards_buffer == 1)
                {
                    SurfaceCardBasic.Add(s);
                    string[] words = s.Split(delimiterChars, StringSplitOptions.RemoveEmptyEntries);
                    surface_cards_basic.Add(words);
                }
                if (data_cards_buffer == 1)
                {
                    DataCardBasic.Add(s);
                    string[] words = s.Split(delimiterChars, StringSplitOptions.RemoveEmptyEntries);
                    data_cards_basic.Add(words);
                }
                if (source_cards_buffer == 1)
                {
                    SourceCardBasic.Add(s);
                    string[] words = s.Split(delimiterChars, StringSplitOptions.RemoveEmptyEntries);
                    source_cards_basic.Add(words);
                }
                if (material_cards_buffer == 1)
                {
                    MaterialCardBasic.Add(s);
                    string[] words = s.Split(delimiterChars, StringSplitOptions.RemoveEmptyEntries);
                    List<string> list = new List<string>(words.ToList());
                    if (words[0].Contains("m"))
                    {
                        material_stack = words[0];
                        if (list.Count > 3)
                        {
                            if (list[3].Contains("$"))
                            {
                                list.Add(list[3]);
                                list[3] = "";
                            }
                        }
                        words = list.ToArray();
                    }
                    else
                    {
                        list.Insert(0, material_stack);
                        if (list.Count > 3)
                        {
                            if (list[3].Contains("$"))
                            {
                                list.Add(list[3]);
                                list[3] = "";
                            }
                        }
                        words = list.ToArray();
                    }
                    material_cards_basic.Add(words);
                }
                if (tally_cards_buffer == 1)
                {
                    TallyCardBasic.Add(s);
                    string[] words = s.Split(delimiterChars, StringSplitOptions.RemoveEmptyEntries);
                    tally_cards_basic.Add(words);
                }
            }
        }
    }
}