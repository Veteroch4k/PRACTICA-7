using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace PRACTICA_OIB
{
    public static class Program
    {
        [STAThread]
        public static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new registration_window());


        }
    }
}