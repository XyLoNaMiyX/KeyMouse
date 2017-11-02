using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

using System.IO;

namespace KeyMouse
{
    static class Program
    {
        public static string LckFile = Path.GetTempPath() + "\\keymouse.lck";

        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            if (File.Exists(LckFile))
            {
                MessageBox.Show("Ya hay una instancia de KeyMouse en ejecución. " +
                    "Compruebe la bandeja del sistema.\r\nSi cree que esto no es así, vacíe la " +
                    "carpeta temporal (que puede encontrar en %TEMP%)", "La aplicación está en ejecución",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            File.Create(LckFile);
            AppDomain.CurrentDomain.UnhandledException += UnhandledException;
            Application.ApplicationExit += ApplicationExit;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new MainF());
        }

        static void UnhandledException(object sender, EventArgs e) {
            File.Delete(LckFile);
            Application.Exit();
        }

        static void ApplicationExit(object sender, EventArgs e) { File.Delete(LckFile); }
    }
}
