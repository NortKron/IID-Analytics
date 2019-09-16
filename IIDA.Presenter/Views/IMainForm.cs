using System;
using System.Collections.Generic;
using System.Text;

namespace IIDA.Presenter.Views
{
    // Интерфей для работы с Presenter
    public interface IMainForm
    {
        string SomeText { get; }
        event EventHandler eventClick;
    }
}
