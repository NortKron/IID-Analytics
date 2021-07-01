using System;
using System.Collections.Generic;
using System.Text;

namespace IIDA.Presenter
{
    // Интерфей для работы с Presenter
    public interface IMainForm
    {
        // TODO: Этих полей здесь быть не должно!
        string filePathMDF { get; set; }
        string filePathACS { get; set; }
        int FileDBFormat { get; set; }

        event EventHandler initializeConnection;

        //bool LetInit();

    }
}
