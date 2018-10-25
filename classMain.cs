using System;
using System.Windows.Forms;

namespace Unturned_Uconomy_Utility
{
    static class classMain
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            EmbeddedAssembly.Load("Unturned_Uconomy_Utility.libs.MySql.Data.dll", "MySql.Data.dll");

            AppDomain.CurrentDomain.AssemblyResolve += new ResolveEventHandler(CurrentDomain_AssemblyResolve);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            new frmWelcome().Show();
            Application.Run(new frmMain());
        }

        private static System.Reflection.Assembly CurrentDomain_AssemblyResolve(object sender, ResolveEventArgs args)
        {
            return EmbeddedAssembly.Get(args.Name);
        }
    }
}
