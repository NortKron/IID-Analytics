using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Forms;

using IIDA.Presenter;

namespace IIDA.View
{
    public partial class Form_ManagerConnections : Form, IManagerConnections
    {
        private const string PARAMETER_FILEFILTER_MDF = "MDF files (*.mdf)|*.mdf";
        private const string PARAMETER_FILEFILTER_ACS = "Access files (*.accdb)|*.accdb";
        private const string PARAMETER_FILEFILTER_SQL = "";

        private OpenFileDialog openFileDialog1;

        #region IManagerConnections methods
        public string filePathMDF
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }

        public string filePathACS
        {
            get { return textBox2.Text; }            
            set { textBox2.Text = value; }
        }
        
        public int FileDBFormat
        {
            get { return TabControl.SelectedIndex; }
            set { TabControl.SelectedIndex = value; }
        }
        
        public event EventHandler btnTestConnection;
        public event EventHandler btnSaveSettings;

        #endregion IManagerConnections methods

        public Form_ManagerConnections()
        {
            InitializeComponent();

            openFileDialog1 = new OpenFileDialog()
            {
                FileName = "Select a database file",
                Title = "Open a database file"
            };
        }


        private void Form_ManagerConnections_Load(object sender, EventArgs args)
        {
            radioButton_MDF.Checked = (TabControl.SelectedIndex == 0);
            radioButton_ACS.Checked = (TabControl.SelectedIndex == 1);
            radioButton_SQL.Checked = (TabControl.SelectedIndex == 2);
        }

        private void button_OK_Click(object sender, EventArgs args)
        {
            btnSaveSettings(this, EventArgs.Empty);
            this.Close();
        }

        private void button_Test_Click(object sender, EventArgs args) => btnTestConnection(this, EventArgs.Empty);
        private void button_Cancel_Click(object sender, EventArgs args) => this.Close();

        private void button_OpenDialog_Click(object sender, EventArgs args)
        {
            openFileDialog1.Filter = (radioButton_MDF.Checked ? PARAMETER_FILEFILTER_MDF :
                 radioButton_ACS.Checked ? PARAMETER_FILEFILTER_ACS : PARAMETER_FILEFILTER_SQL);

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (radioButton_MDF.Checked)
                {
                    textBox1.Text = openFileDialog1.FileName;
                }

                if (radioButton_ACS.Checked)
                {
                    textBox2.Text = openFileDialog1.FileName;
                }

                if (radioButton_SQL.Checked)
                {
                    // Check SQL string connection
                }
            }
        }

        private void radioButtons_CheckedChanged(object sender, EventArgs args)
        {
            if (radioButton_MDF.Checked) TabControl.SelectedIndex = 0;
            if (radioButton_ACS.Checked) TabControl.SelectedIndex = 1;
            if (radioButton_SQL.Checked) TabControl.SelectedIndex = 2;
        }

        private void Form_ManagerConnections_KeyDown(object sender, KeyEventArgs args)
        {
            if (args.KeyCode == Keys.Escape) this.Close();
        }       
    }
}
