using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SandboxConsole.Workspace
{
    class Wrk_01_Asciidoc_to_html_and_pdf
    {

        public static void Run()
        {
            Console.WriteLine("Sanbox Console");

            var process = new Process();
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.Arguments = "/c asciidoctorj.bat -b pdf Qt.adoc";
            process.StartInfo.WorkingDirectory = @"D:\ccp_wrks\KnowledgeManagement\content\GuiFrameworks\Qt";
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.CreateNoWindow = true;

            process.Start();
            string output = process.StandardOutput.ReadToEnd();
            process.WaitForExit();

            Console.WriteLine(output);
        }
    }
}
