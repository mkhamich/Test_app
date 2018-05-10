using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            String FileNametime = DateTime.Now.ToString("yyyyMMddHHmm");

            String StartTime = DateTime.Now.ToString("MM/dd/yy HH:mm:ss");
            string[] start = { StartTime + " START" };
            System.IO.File.AppendAllLines(FileNametime + " DrugIncrementTest.log", start);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new DispenceCountForm());
        }
    }
}
