using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using IIDA.Presenter;

namespace IIDA.View
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
		[STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new MainForm());

            // TODO: ������������ � ��?

            // Init pattern parts
            MainForm form = new();
            MessageService service = new();
            MainPresenter presenter = new(form, service);

            Application.Run(form);
        }
    }
}
