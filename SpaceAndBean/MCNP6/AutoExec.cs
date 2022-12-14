using System;
using System.Diagnostics;
using System.IO;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace SpaceAndBean.MCNP6
{
    public class AutoExec
    {
        public static int Exec_count = 0;
        public static void Exec_MCNP()
        {
            FileSystemWatcher watcher = new FileSystemWatcher("C:\\output_File", "*.*");
            
            ProcessStartInfo MCNP = new ProcessStartInfo();
            MCNP.FileName = "C:\\Windows\\System32\\cmd.exe";
            MCNP.RedirectStandardInput = true;
            MCNP.RedirectStandardOutput = true;
            MCNP.UseShellExecute  = false;
            Process p = Process.Start(MCNP);
            StreamWriter myStreamWriter = p.StandardInput;
            myStreamWriter.WriteLine("mcnp6 i="+Program.outputFilePath+"input.txt o=C:\\output_File\\result"+Exec_count.ToString()+".txt");
            
            watcher.Created += FileSystemWatcher_Created;
        }

        public static void FileSystemWatcher_Created(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine("Created result file : {0}", e.Name);
            Exec_count += 1;
        }
    }
}