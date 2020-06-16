using System;
using System.Windows.Forms;

namespace NicroD_IT_Enterprise_Table
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            using (var context = new BDC())
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new MainForm(context));
            }
        }
    }
}
