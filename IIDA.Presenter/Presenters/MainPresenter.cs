using System;
using System.Collections.Generic;
using System.Text;

using IIDA.Model;

namespace IIDA.Presenter
{
    public class MainPresenter
    {
        // Main form
        private readonly IMainForm _view;

        // Вывод сообщений
        private readonly IMessageService _messageService;

        public MainPresenter(IMainForm view, IMessageService service)
        {
            _view = view;
            _messageService = service;

            _view.eventClick += new EventHandler(_view_eventClick);
        }
        
        void _view_eventClick(object sender, EventArgs args)
        {
            string str = @"Test message";

            _messageService.ShowMessage(str);
            //Properties.Settings.Default.set1;
        }
    }
}
