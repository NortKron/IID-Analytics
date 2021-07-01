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
using System.Data.OleDb;
using System.Data.SqlClient;

using IIDA.Presenter;

namespace IIDA.View
{
    public partial class MainForm : Form, IMainForm
    {
        MessageService service;

        public string filePathMDF { get; set; }
        public string filePathACS { get; set; }
        public int FileDBFormat { get; set; }

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

        private void MainForm_Load(object sender, EventArgs args)
        {
            initializeConnection(this, EventArgs.Empty);


        }

        private Language getSelectedLanguage()
        {
            return (Language)comboBox2.SelectedItem;
        }

        #region Presenter Interface Methods

        public event EventHandler eventClick;
        public event EventHandler initializeConnection;

        #endregion Presenter Interface Methods

        #region Menu Events

        private void MainMenu_ProjectManager_Click(object sender, EventArgs args) => tabControl_Main.SelectedIndex = 0;

        private void MainMenu_Calcs_Click(object sender, EventArgs args) => OpenTabWindow(new Form_Calcs());

        private void MainMenu_Map_Click(object sender, EventArgs args) => OpenTabWindow(new Form_Map());

        private void MainMenu_Table_Click(object sender, EventArgs args) => OpenTabWindow(new Form_TableFeatures());

        private void MainMenu_Report_Click(object sender, EventArgs args) => OpenTabWindow(new Form_Reports());

        private void MainMenu_About_Click(object sender, EventArgs args) => new Form_About().ShowDialog();

        private void MainMenu_Settings_Click(object sender, EventArgs args) => new Form_Settings().ShowDialog();

        private void MainMenu_ManagerConnection_Click(object sender, EventArgs args)
        {
            Form_ManagerConnections form = new Form_ManagerConnections();
            ManagerConnections presenter = new ManagerConnections(form, service);

            form.ShowDialog();
        }

        private void MainMenu_Web_Click(object sender, EventArgs args) => MessageBox.Show("Вэбсайт проекта недоступен!", "Вэбсайт", MessageBoxButtons.OK, MessageBoxIcon.Information);

        private void MainMenu_Exit_Click(object sender, EventArgs args) => Application.Exit();
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

        private void MainForm_KeyDown(object sender, KeyEventArgs args)
        {
            // Сочетание клавиш Ctrl + W закрывает активную вкладку TabControl
            if (args.Control && args.KeyCode == Keys.W)
            {
                // Не закрывать вкладку "Менеджер проектов"
                if (tabControl_Main.SelectedIndex != 0)
                {
                    int currentTabIndex = tabControl_Main.SelectedIndex;
                    tabControl_Main.TabPages.RemoveAt(currentTabIndex);

                    // При закрытии вкладки переключиться на предыдущую вкладку
                    tabControl_Main.SelectedIndex = currentTabIndex - 1;
                }
            }
        }

        private void MainForm_SizeChanged(object sender, EventArgs args)
        {
            toolStripStatusLabel1.Text = "change";
        }

        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs args)
        {
            //var language = getSelectedLanguage();
            //languageBindingSource.DataSource = language;
            //pictureBox1.Load(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Languages", language.Image));
        }

        private void button1_Click(object sender, EventArgs args)
        {
            tableLayoutPanel1.Visible = !tableLayoutPanel1.Visible;

            button1.Text = tableLayoutPanel1.Visible ? "Скрыть нижнюю панель" : "Показать нижнюю панель";
            tableLayoutPanel5.RowStyles[0].Height = tableLayoutPanel1.Visible ? 35 : 100;
            tableLayoutPanel5.RowStyles[2].Height = tableLayoutPanel1.Visible ? 65 : 0;
        }

        private void toolBtn_Test2_Click(object sender, EventArgs args)
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();
            textBox1.Text = "";
        }

        private void toolBtn_Test_Click(object sender, EventArgs args)
        {
            //eventClick(this, EventArgs.Empty);
            //Task num = await Task.WhenAny(GetData());

            //Thread potok1 = new Thread(GetData); // создание отдельного потока
            //potok1.Start(); // запуск потока

            // КОД 3 - здесь код после запуска второго потока
            //potok1. .Abort(); // остановка потока

            //Task task = GetData();
            //task.Wait();

            //GetDataAsync();

            try
            {
                Task.Run(() => GetDataAsync());
            }
            catch (Exception e)
            {
                toolStripStatusLabel1.Text = "Exception";
                service.ShowError(e.Message);
            }
            //GetDataM();

            //Debug.Print("Start");
            //new Thread(new ThreadStart(GetData)).Start();
        }

        private async void GetDataM()
        {
            //textBox1.Text = GetData();
            //Task prc = await GetData();
            //if (prc.IsCompleted) return;

            //await Task.Run(() => GetData());

            DataGridViewTextBoxColumn[] header =
                {
                    new DataGridViewTextBoxColumn()
                    {
                        Name = "NameCol1",
                        HeaderText = "Title1"
                    },

                    new DataGridViewTextBoxColumn()
                    {
                        Name = "NameCol3",
                        HeaderText = "Title3"
                    },

                    new DataGridViewTextBoxColumn()
                    {
                        Name = "NameCol3",
                        HeaderText = "Title3"
                    }
                };

            /*
            DataGridViewRow[] rows = 
                {
                    new object[] { 4, 5, 6 },
                    new object[] { 7, 8, 9 },
                    new object[] { 10, 11, 12 }
                };
            */
            object[] mas = new object[]
            {
                new object[] { 4, 5, 6 },
                new object[] { 7, 8, 9 },
                new object[] { 10, 11, 12 }
            };

            object[] row1 = new object[] { "Meatloaf", "Main Dish", "ground beef", "**" };
            string[] row2 = new string[] { "Key Lime Pie", "Dessert",
                "lime juice, evaporated milk", "****" };
            string[] row3 = new string[] { "Orange-Salsa Pork Chops", "Main Dish",
                "pork chops, salsa, orange juice", "****" };

            string[] row4 = new string[] { "Black Bean and Rice Salad", "Salad",
                "black beans, brown rice", "****" };
            string[] row5 = new string[] { "Chocolate Cheesecake", "Dessert",
                "cream cheese", "***" };
            string[] row6 = new string[] { "Black Bean Dip", "Appetizer",
                "black beans, sour cream", "***" };

            object[] rows = new object[] { row1, row2, row3 };

            //DataGridViewColumn colmn = { "q", "w", "e" };
            //string[] colmn = { "q", "w", "e" };
            //dataGridView1.Columns.Add(colmn);

            //dataGridView1.Columns.Add(new DataGridViewTextBoxColumn(){ Name = "clmn1" });
            //dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "clmn2" });
            //dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "clmn3" });

            dataGridView1.Columns.AddRange(header);
            dataGridView1.Rows.Add(mas);
        }

        private async Task GetDataAsync()
        {
            string connectString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source='" + filePathACS + "';";

            toolStripStatusLabel1.Text = "Connecting";
            OleDbConnection myConnection = new OleDbConnection(connectString);
            await myConnection.OpenAsync();
            //myConnection.Open();

            string query =
                //"SELECT top 1000 ID_Key, Feature_Index, Type_Index, Latitude, Longitude, Altitude FROM Tablitca_osobennostei";
                "SELECT Top 10000 * FROM Tablitca_osobennostei";
            //"SELECT * FROM Tablitca_osobennostei";
            //"SELECT * FROM Menedzher_proektov"; // Tablitca_osobennostei";

            // создаем объект OleDbCommand для выполнения запроса к БД MS Access
            //OleDbCommand command = new OleDbCommand(query, myConnection);

            // получаем объект OleDbDataReader для чтения табличного результата запроса SELECT
            //OleDbDataReader reader = command.ExecuteReader();

            toolStripStatusLabel1.Text = "Query execute";
            var reader = new OleDbCommand(query, myConnection).ExecuteReader();

            //Debug.Print("Start head");
            toolStripStatusLabel1.Text = "Getting headers";

            List<DataGridViewTextBoxColumn> header =
                await GetHeadersAsync(reader);
                //new List<DataGridViewTextBoxColumn>();
            dataGridView1.Columns.AddRange(header.ToArray());
            /*
            // Заполнение заголовков
            for (int i = 0; i < reader.FieldCount; i++)
            {
                //Debug.Print(reader.GetName(i;

                dataGridView1.Columns.Add(reader.GetName(i), reader.GetName(i));
                
                header.Add(new DataGridViewTextBoxColumn()
                {
                    Name = reader.GetName(i)
                    //HeaderText = "Lala" + i
                });
                
            }
            */
            toolStripStatusLabel1.Text = "Getting rows";
            //object[] obj;
            List<object[]> data = await GetRowsAsync(reader);
            //new List<object[]>();
            //int num;

            foreach (object[] row in data)
            {
                //Debug.Print(row[0].ToString());
                dataGridView1.Rows.Add(row);
            }
            /*
            // Заполнение строк            
            while (await reader.ReadAsync())
            {
                //dataGridView1.DataSource
                //reader.GetColumnSchema()
                    
                obj = new object[reader.FieldCount];
                num = reader.GetValues(obj);

                //data.Add(obj);
                dataGridView1.Rows.Add(obj);

                //Debug.Print(">> num = " + num);
                //Debug.Print(reader["ID_Key"].ToString());
            }
            */
            toolStripStatusLabel1.Text = "Closing connection";

            //await myConnection.CloseAsync();
            await myConnection.CloseAsync();

            //dataGridView1.Columns.AddRange(header.ToArray());
            //dataGridView1.Rows.AddRange(data);            

            /*
            Invoke(new EventHandler(delegate (object sender, EventArgs e)
            {
                dataGridView1.Columns.AddRange(header.ToArray());

                foreach (object[] row in data)
                {
                    //Debug.Print(row[0].ToString());
                    dataGridView1.Rows.Add(row);
                }
            }), new object[2] { this, null });
            */

            Debug.Print("End");
        }

        private async Task<List<DataGridViewTextBoxColumn>> GetHeadersAsync(OleDbDataReader reader)
        {
            List<DataGridViewTextBoxColumn> header = new List<DataGridViewTextBoxColumn>();

            for (int i = 0; i < reader.FieldCount; i++)
            {
                header.Add(new DataGridViewTextBoxColumn()
                {
                    Name = reader.GetName(i)
                });
            }

            return header;
        }

        private async Task<List<object[]>> GetRowsAsync(OleDbDataReader reader)
        {
            object[] obj;
            int num;
            List<object[]> data = new List<object[]>();

            while (await reader.ReadAsync())
            {
                obj = new object[reader.FieldCount];
                num = reader.GetValues(obj);
                data.Add(obj);
            }

            return data;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs args)
        {
            // TODO: Разорвать соединение с базой данных
        }
    }
}
