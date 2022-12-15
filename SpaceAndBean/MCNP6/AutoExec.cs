using System;
using System.Diagnostics;
using System.IO;
using System.Security.Cryptography;
using System.Windows.Forms;
using SpaceAndBean.IO;
using SpaceAndBean.RandomCreate;

namespace SpaceAndBean.MCNP6
{
    public class AutoExec
    {
        public static int Exec_count = 0;
        public static void Exec_MCNP()
        {
            FileSystemWatcher watcher = new FileSystemWatcher("C:\\output_File", "*.*");
            if (Exec_count > 100)
            {
                watcher.Created -= FileSystemWatcher_Created;
                return;
            }
            ProcessStartInfo MCNP = new ProcessStartInfo();
            MCNP.FileName = "C:\\Windows\\System32\\cmd.exe";
            MCNP.RedirectStandardInput = true;
            MCNP.RedirectStandardOutput = true;
            MCNP.UseShellExecute  = false;
            Process p = Process.Start(MCNP);
            StreamWriter myStreamWriter = p.StandardInput;
            myStreamWriter.WriteLine("%HOMEDRIVE%%HOMEPATH%\\mcnp_env_620.bat");
            myStreamWriter.WriteLine("mcnp6 i="+Program.outputFilePath+" o=C:\\output_File\\result"+Exec_count.ToString()+".txt");

            watcher.Created += FileSystemWatcher_Created;
        }

        public static void FileSystemWatcher_Created(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine("Created result file : {0}, count : {1}", e.Name, Exec_count);
            Program.CellCardArrayList = MakeCellCard.Make(Program.MaterialCardArrayList, Program.SurfaceCardArrayList);
            SaveInput.Save(Program.CellCardArrayList, Program.SurfaceCardArrayList, Program.MaterialCardArrayList,
                Program.TallyCardArrayList);
            Exec_count += 1;
            Exec_MCNP();
        }
    }
}