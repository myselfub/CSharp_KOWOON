using Kowoon.Mains;
using System;
using System.Windows.Forms;

namespace Kowoon
{
    internal static class Program
    {
        ///Version: 1.0
        ///Author: ±Ë¿Ø∫Û(Kim Yu Bin)
        ///E-Mail: fd9100@naver.com
        ///Create Date: 2021.08.02
        ///Last Update Date: 2021.08.21
        private static Main _main = null;

        public static Main GetMain()
        {
            if (_main == null || _main.IsDisposed)
            {
                _main = new Main();
            }
            return _main;
        }


        [STAThread]
        private static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            _main = new Main();
            Application.Run(_main);
        }
    }
}