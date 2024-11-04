using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AS2_BiologyQuiz
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        /// 
        public static int helpNumber; //for loading help screen
        public static int timerStop; //for pausing timer on help screen
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmSplash());

    }
}
}


