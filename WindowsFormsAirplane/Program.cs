using System;
using System.Windows.Forms;

namespace WindowsFormsAirplane
{
    public delegate void planeDelegate(ITransport plane);

    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>        
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormParking());
        }
    }
}
