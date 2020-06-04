using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using IIDA.Presenter;

namespace IIDA.View
{    
    public partial class MainForm : Form, IMainForm
    {
        public MainForm()
        {
            InitializeComponent();

            // TODO: Установить соединение с базой данных

        }

        public string SomeText
        {
            get { return "Something text"; }
        }

        public event EventHandler eventClick;

        private void MainMenu_ProjectManager_Click(object sender, EventArgs e) => tabControl_Main.SelectedIndex = 0;

        private void MainMenu_Calcs_Click(object sender, EventArgs e) => OpenTabWindow(new Form_Calcs());

        private void MainMenu_Map_Click(object sender, EventArgs e) => OpenTabWindow(new Form_Map());

        private void MainMenu_Table_Click(object sender, EventArgs e) => OpenTabWindow(new Form_TableFeatures());
        
        private void MainMenu_Report_Click(object sender, EventArgs e) => OpenTabWindow(new Form_Reports());

        private void MainMenu_About_Click(object sender, EventArgs e) => new Form_About().ShowDialog();

        private void MainMenu_Settings_Click(object sender, EventArgs e) => new Form_Settings().ShowDialog();

        private void MainMenu_Exit_Click(object sender, EventArgs e) => Application.Exit();

        private void MainMenu_Web_Click(object sender, EventArgs e) => System.Diagnostics.Process.Start("https://vtd-pb.ru/");        

        // Открыть новое окно во вкладке TabControl
        private void OpenTabWindow(Form newForm)
        {   
            foreach (TabPage tabPage in tabControl_Main.TabPages)
            {
                if (tabPage.Text == newForm.Text)
                {
                    tabControl_Main.SelectedTab = tabPage;
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

            tabControl_Main.TabPages.Add(newTabPage);
            tabControl_Main.SelectedIndex = tabControl_Main.TabPages.Count - 1;
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {   
            // Сочетание клавиш Ctrl + W закрывает активную вкладку TabControl
            if (e.Control && e.KeyCode == Keys.W)
            {
                if (tabControl_Main.SelectedIndex != 0)
                {
                    int currentTabIndex = tabControl_Main.SelectedIndex;
                    tabControl_Main.TabPages.RemoveAt(currentTabIndex);

                    // При закрытии вкладки переключиться на предыдущую вкладку
                    tabControl_Main.SelectedIndex = currentTabIndex - 1;
                }
            }
        }

        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "change";
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // TODO: Разоравать соединение с базой данных             
        }
    }
}
