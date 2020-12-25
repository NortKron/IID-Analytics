using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Diagnostics;

using IIDA.Presenter;

namespace IIDA.View
{
    public partial class MainForm : Form, IMainForm
    {
        MessageService service;

        public MainForm()
        {
            // TODO: Установить соединение с базой данных
            
            InitializeComponent();            

            foreach (var language in Language.Load())
            {
                toolStripComboBox1.Items.Add(language);
            }

            //toolStripComboBox1.SelectedIndex = 0;   

            service = new MessageService();            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private Language getSelectedLanguage()
        {
            return (Language)comboBox2.SelectedItem;
        }

        public string SomeText
        {
            get { return "Something text"; }
        }

        #region Presenter Interface Methods
        public event EventHandler eventClick;

        #endregion Presenter Interface Methods

        #region Menu Events

        private void MainMenu_ProjectManager_Click(object sender, EventArgs e) => tabControl_Main.SelectedIndex = 0;

        private void MainMenu_Calcs_Click(object sender, EventArgs e) => OpenTabWindow(new Form_Calcs());

        private void MainMenu_Map_Click(object sender, EventArgs e) => OpenTabWindow(new Form_Map());

        private void MainMenu_Table_Click(object sender, EventArgs e) => OpenTabWindow(new Form_TableFeatures());
        
        private void MainMenu_Report_Click(object sender, EventArgs e) => OpenTabWindow(new Form_Reports());

        private void MainMenu_About_Click(object sender, EventArgs e) => new Form_About().ShowDialog();

        private void MainMenu_Settings_Click(object sender, EventArgs e) => new Form_Settings().ShowDialog();

        private void MainMenu_ManagerConnection_Click(object sender, EventArgs e)
        {
            Form_ManagerConnections form = new Form_ManagerConnections();
            ManagerConnections presenter = new ManagerConnections(form, service);

            form.ShowDialog();
        }

        private void MainMenu_Web_Click(object sender, EventArgs e) => MessageBox.Show("Вэбсайт проекта недоступен!", "Вэбсайт", MessageBoxButtons.OK, MessageBoxIcon.Information);

        private void MainMenu_Exit_Click(object sender, EventArgs e) => Application.Exit();
        #endregion Menu Events

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

        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //var language = getSelectedLanguage();
            //languageBindingSource.DataSource = language;
            //pictureBox1.Load(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Languages", language.Image));
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Visible = !tableLayoutPanel1.Visible;

            button1.Text = tableLayoutPanel1.Visible ? "Скрыть нижнюю панель" : "Показать нижнюю панель";
            tableLayoutPanel5.RowStyles[0].Height = tableLayoutPanel1.Visible ? 35 : 100;
            tableLayoutPanel5.RowStyles[2].Height = tableLayoutPanel1.Visible ? 65 : 0;
        }

        private void toolBtn_Test_Click(object sender, EventArgs e)
        {
            eventClick(this, EventArgs.Empty);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // TODO: Разоравать соединение с базой данных
        }
    }
}
