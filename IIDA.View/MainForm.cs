using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using IIDA.Presenter.Views;

namespace IIDA.View
{    
    public partial class MainForm : Form, IMainForm
    {
        public MainForm()
        {
            InitializeComponent();

            // this is new verson

            // Назначение обработчиков событий компанентам
            //button1.Click += new EventHandler(button1_Click);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Внутренняя логика компонента

            eventClick(this, EventArgs.Empty);
        }

        public string SomeText
        {
            get { return "Something text"; }
        }

        public event EventHandler eventClick;

    }
}
