using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using IIDA.Model;

namespace IIDA.Presenter
{
    public class ManagerConnections
    {
        // Form managerConnections
        private readonly IManagerConnections _view;

        // Вывод сообщений
        private readonly IMessageService _messageService;

        ModelBase dataModel;

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
            string filePath = _view.FileDBFormat == 0 ? _view.filePathMDF : _view.filePathACS;

            dataModel = new ModelBase();
            dataModel.InitConnection();

            dataModel.SetParameters(
                _view.filePathMDF,
                _view.filePathACS,
                _view.FileDBFormat);

            if (!dataModel.IsValidParameters())
            {
                _messageService.ShowError("Не удаётся найти файл: \n"
                    + filePath + "\n\n"
                    + "Проверьте правильность пути файла");
                return;
            }

            _messageService.ShowMessage(dataModel.TestConnection());
            dataModel.CloseConnection();
        }
    }
}
