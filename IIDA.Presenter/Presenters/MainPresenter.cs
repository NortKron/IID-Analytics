using System;
using System.Collections.Generic;
using System.Text;

using System.Diagnostics;

using IIDA.Model;

namespace IIDA.Presenter
{
    public class MainPresenter
    {
        // Main form
        private readonly IMainForm _view;

        // Вывод сообщений
        private readonly IMessageService _messageService;

        ModelBase dataReader;

        public MainPresenter(IMainForm view, IMessageService service)
        {
            _view = view;
            _messageService = service;

            _view.initializeConnection += new EventHandler(_view_InitializeConnection);

            _view.filePathMDF = Properties.Settings.Default.PathFile_MDF;
            _view.filePathACS = Properties.Settings.Default.PathFile_ACS;
            _view.FileDBFormat = Properties.Settings.Default.FileDBFormat;


            dataReader = new ModelBase();
            dataReader.SetParameters(
                Properties.Settings.Default.PathFile_MDF,
                Properties.Settings.Default.PathFile_ACS,
                Properties.Settings.Default.FileDBFormat);
            
        }

        void _view_InitializeConnection(object sender, EventArgs args)
        {
            if (dataReader.IsValidParameters())
            {
                dataReader.InitConnection();
            }
            else
            {
                _messageService.ShowExclamation("Invalid parameters connection!");                 
            }            
        }
    }
}
