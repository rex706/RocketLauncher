using System;
using System.Windows.Forms;

namespace Rocket_Launcher
{
    static class Program
    {
        /// <summary>
        /// Easily change Rocket League's resolution to work with dual-monitor split screen.
        /// </summary>

        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1(args));
        }
    }
}
