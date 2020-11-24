using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using System.Data.OleDb;
using System.Data.SqlClient;
using System.Diagnostics;

namespace IIDA.View
{
    public partial class Form_ManagerConnections : Form
    {
        private OpenFileDialog openFileDialog1;

        public Form_ManagerConnections()
        {
            InitializeComponent();
            openFileDialog1 = new OpenFileDialog()
            {
                FileName = "Select a database file",
                Title = "Open a database file"
            };
        }

        private void Form_ManagerConnections_Load(object sender, EventArgs e)
        {
            switch (Properties.Settings.Default.FileDBFormat)
            {
                case 0:
                    radioButton_MDF.Checked = true;
                    break;

                case 1:
                    radioButton_ACS.Checked = true;
                    break;

                case 2:
                    radioButton_SQL.Checked = true;
                    break;

                default:
                    radioButton_MDF.Checked = true;
                    break;
            }

            textBox1.Text = Properties.Settings.Default.PathFile_MDF;
            textBox2.Text = Properties.Settings.Default.PathFile_ACS;
            TabControl.SelectedIndex = Properties.Settings.Default.FileDBFormat;
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.PathFile_MDF = textBox1.Text;
            Properties.Settings.Default.PathFile_ACS = textBox2.Text;
            Properties.Settings.Default.FileDBFormat = TabControl.SelectedIndex;

            Properties.Settings.Default.Save();
            this.Close();
        }        

        private void button_Test_Click(object sender, EventArgs e)
        {
            if (!File.Exists(textBox1.Text))
            {
                MessageBox.Show("Не удаётся найти файл! Проверьте правильность пути файла", "Файл не найден", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string connectString;

            if (radioButton_MDF.Checked)
            {
                connectString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='" +
                    textBox1.Text + 
                    "';Integrated Security=True";

                SqlConnection myConnection = new SqlConnection(connectString);
                myConnection.Open();

                MessageBox.Show("Соединение с локальной базой данных установлено!", "Соединение с БД", MessageBoxButtons.OK, MessageBoxIcon.Information);
                myConnection.Close();
            } 
            else
            {
                connectString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source='" +
                    textBox2.Text + "';";

                OleDbConnection myConnection = new OleDbConnection(connectString);
                myConnection.Open();

                MessageBox.Show("Соединение с БД MS Access установлено!", "Соединение с БД", MessageBoxButtons.OK, MessageBoxIcon.Information);
                myConnection.Close();
            }
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_OpenDialog_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = radioButton_MDF.Checked ? "MDF files (*.mdf)|*.mdf" : "Acess files (*.accdb)|*.accdb";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (radioButton_MDF.Checked)
                    textBox1.Text = openFileDialog1.FileName;
                else
                    textBox2.Text = openFileDialog1.FileName;
                /*
                try
                {
                    var filePath = openFileDialog1.FileName;
                    using (Stream str = openFileDialog1.OpenFile())
                    {
                        Process.Start("notepad.exe", filePath);
                    }
                }
                catch (SecurityException ex)
                {
                    MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                    $"Details:\n\n{ex.StackTrace}");
                }
                */
            }
        }

        private void radioButtons_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_MDF.Checked) TabControl.SelectedIndex = 0;
            if (radioButton_ACS.Checked) TabControl.SelectedIndex = 1;
            if (radioButton_SQL.Checked) TabControl.SelectedIndex = 2;
        }

        private void Form_ManagerConnections_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) this.Close();
        }
    }
}
