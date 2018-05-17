using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Cronometro
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
//#if (!DEBUG)
//            WindowsIdentity identity = WindowsIdentity.GetCurrent();
//            WindowsPrincipal principal = new WindowsPrincipal(identity);
            
            
//            if (!principal.IsInRole(WindowsBuiltInRole.Administrator))
//            {
//                if (MessageBox.Show("Você deve executar este aplicativo como administrador. \n Deseja reiniciar o aplicativo no modo de administrador.", "Permissão", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
//                {
//                    Application.Exit();
//                }
//                else
//                {
//                    ProcessStartInfo proc = new ProcessStartInfo();
//                    proc.UseShellExecute = true;
//                    proc.WorkingDirectory = Environment.CurrentDirectory;
//                    proc.FileName = Application.ExecutablePath;
//                    proc.Verb = "runas";

//                    try
//                    {
//                        Process.Start(proc);
//                    }
//                    catch
//                    {
//                        // The user refused the elevation.
//                        // Do nothing and return directly ...
//                        return;
//                    }
//                    Application.Exit();
//                }
//            }
//            else            
//#endif
            Application.Run(new Login());
        }
    }
}
