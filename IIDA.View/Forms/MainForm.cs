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

        }

        public string SomeText
        {
            get { return "Something text"; }
        }

        public event EventHandler eventClick;

        private void MainMenu_ProjectManager_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }

        private void MainMenu_Calcs_Click(object sender, EventArgs e)
        {
            Form_Calcs newForm = new Form_Calcs();
            OpenTabWindow(newForm);
        }

        private void MainMenu_Map_Click(object sender, EventArgs e)
        {
            Form_Map newForm = new Form_Map();
            OpenTabWindow(newForm);
        }

        private void MainMenu_About_Click(object sender, EventArgs e)
        {
            Form_About newForm = new Form_About();
            OpenTabWindow(newForm);
        }

        private void MainMenu_Table_Click(object sender, EventArgs e)
        {
            Form_TableFeatures newForm = new Form_TableFeatures();
            OpenTabWindow(newForm);
        }

        private void MainMenu_Report_Click(object sender, EventArgs e)
        {
            Form_Reports newForm = new Form_Reports();
            OpenTabWindow(newForm);
        }

        private void OpenTabWindow(Form newForm)
        {   
            foreach (TabPage tabPage in tabControl1.TabPages)
            {
                if (tabPage.Text == newForm.Text)
                {
                    tabControl1.SelectedTab = tabPage;
                    return;
                }
            }

            TabPage newTabPage = new TabPage();

            newForm.TopLevel = false;
            newForm.Visible = true;
            newForm.FormBorderStyle = FormBorderStyle.None;
            newForm.Dock = DockStyle.Fill;

            newTabPage.Controls.Add(newForm);
            newTabPage.Text = newForm.Text;

            tabControl1.TabPages.Add(newTabPage);
            tabControl1.SelectedIndex = tabControl1.TabPages.Count - 1;
        }
    }
}
