using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelaMenuPIM
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormLogin());
        }

        public static bool IsInDesignMode(ContainerControl container)
        {
            if (Application.ExecutablePath.IndexOf(value:"devenv.exe", StringComparison.OrdinalIgnoreCase)> -1)
            {
                container.Controls.Add(new Label()
                {
                    Text = container.GetType().Name,
                    AutoSize = false,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Dock = DockStyle.Fill
                });
                return true;
            }
            return false;
        }
    }
}
