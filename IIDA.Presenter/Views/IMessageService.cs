using System;
using System.Collections.Generic;
using System.Text;

namespace IIDA.Presenter
{
    public interface IMessageService
    {
        void ShowMessage(string message);
        void ShowExclamation(string exclamation);
        void ShowError(string error);
    }
}
