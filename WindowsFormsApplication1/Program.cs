using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    static class Program
    {
        static Login login;
        static string userName;
        [STAThread]
        
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Login login = new Login();
            //Application.Run(login);

            Application.Run(new Inicio("Desarrollador"));



        }

        
    }
}
