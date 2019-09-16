﻿using System;
using System.Collections.Generic;
using System.Text;

using IIDA.Model;
using IIDA.Presenter.Views;

namespace IIDA.Presenter.Presenters
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
        
        void _view_eventClick(object sender, EventArgs e)
        {
            string str = _view.SomeText;

            _messageService.ShowMessage(str);
        }

    }
}
