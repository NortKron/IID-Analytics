using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.OleDb;
using System.Data.SqlClient;

namespace IIDA.Presenter
{
    public class ManagerConnections
    {
        // Form managerConnections
        private readonly IManagerConnections _view;

        // Вывод сообщений
        private readonly IMessageService _messageService;

        public ManagerConnections(IManagerConnections view, IMessageService service)
        {
            _view = view;
            _messageService = service;
            
            _view.btnTestConnection += new EventHandler(TestConnection);
            _view.btnSaveSettings += new EventHandler(SaveSettings);

            _view.filePathMDF = Properties.Settings.Default.PathFile_MDF;
            _view.filePathACS = Properties.Settings.Default.PathFile_ACS;            
            _view.FileDBFormat = Properties.Settings.Default.FileDBFormat;
        }

        void SaveSettings(object sender, EventArgs args)
        {
            Properties.Settings.Default.PathFile_MDF = _view.filePathMDF;
            Properties.Settings.Default.PathFile_ACS = _view.filePathACS;
            Properties.Settings.Default.FileDBFormat = _view.FileDBFormat;
            Properties.Settings.Default.Save();
        }

        void TestConnection(object sender, EventArgs args)
        {
            //_messageService.ShowMessage(_view.filePathACS);
                                   
            string filePath = _view.FileDBFormat == 0 ? _view.filePathMDF : _view.filePathACS;

            if (!File.Exists(filePath))
            {
                _messageService.ShowError("Не удаётся найти файл! Проверьте правильность пути файла");
                return;
            }

            string connectString;

            try
            {
                switch (_view.FileDBFormat)
                {
                    case 0:

                        connectString = @"Data Source=(LocalDB)\MSSQLLocalDB; AttachDbFilename='" +
                            _view.filePathMDF + "'; Integrated Security=True";

                        SqlConnection myConnectionMDF = new SqlConnection(connectString);
                        myConnectionMDF.Open();

                        _messageService.ShowMessage("Соединение с локальной базой данных установлено!");
                        myConnectionMDF.Close();

                        break;

                    case 1:

                        connectString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = '" +
                            _view.filePathACS + "'";

                        OleDbConnection myConnectionACS = new OleDbConnection(connectString);
                        myConnectionACS.Open();

                        _messageService.ShowMessage("Соединение с БД MS Access установлено!");
                        myConnectionACS.Close();

                        break;

                    case 2:
                        // Test SQL Server connetction
                        break;
                }

            } 
            catch (IOException err)
            {
                _messageService.ShowMessage("Не удалось соединиться с Базой данных! \nПричина:\n\n"
                    + "Message : " + err.Message
                    + "\nSource : " + err.Source);
            }            
        }
    }
}
