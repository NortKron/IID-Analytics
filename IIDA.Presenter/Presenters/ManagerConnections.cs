using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IIDA.Presenter
{
    public class ManagerConnections
    {
        // Form magagerConnections
        private readonly IManagerConnections _view;

        // Вывод сообщений
        private readonly IMessageService _messageService;

        public ManagerConnections(IManagerConnections view, IMessageService service)
        {
            _view = view;
            _messageService = service;
            
            _view.btnTestConnection += new EventHandler(TestConnection);

            _view.filePathACS = Properties.Settings.Default.PathFile_ACS;            
            _view.filePathMDF = Properties.Settings.Default.PathFile_MDF;
            _view.FileDBFormat = Properties.Settings.Default.FileDBFormat;
        }

        void TestConnection(object sender, EventArgs e)
        {
            _messageService.ShowMessage(_view.filePathACS);

            /*
            string filePath = radioButton_MDF.Checked ? textBox1.Text : textBox2.Text;

            if (!File.Exists(filePath))
            {
                //MessageBox.Show("Не удаётся найти файл! Проверьте правильность пути файла", "Файл не найден", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _messageService.ShowError("Не удаётся найти файл! Проверьте правильность пути файла");
                return;
            }

            string connectString;

            if (radioButton_MDF.Checked)
            {
                connectString = @"Data Source=(LocalDB)\MSSQLLocalDB; AttachDbFilename='" +
                    textBox1.Text +
                    "'; Integrated Security=True";

                SqlConnection myConnection = new SqlConnection(connectString);
                myConnection.Open();

                //MessageBox.Show("Соединение с локальной базой данных установлено!", "Соединение с БД", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _messageService.ShowMessage("Соединение с локальной базой данных установлено!");
                myConnection.Close();
            }
            else
            {
                connectString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = '" +
                    textBox2.Text + "'";

                OleDbConnection myConnection = new OleDbConnection(connectString);
                myConnection.Open();

                //MessageBox.Show("Соединение с БД MS Access установлено!", "Соединение с БД", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _messageService.ShowMessage("Соединение с БД MS Access установлено!");
                myConnection.Close();
            }
            */
        }
    }
}
