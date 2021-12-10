using System;

namespace IIDA.Presenter
{
    public interface IManagerConnections
    {
        string filePathMDF { get; set; }
        string filePathACS { get; set; }
        int FileDBFormat { get; set; }

        event EventHandler btnTestConnection;
        event EventHandler btnSaveSettings;
    }
}
