using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IIDA.Presenter
{
    public interface IManagerConnections
    {
        string filePathMDF { get; set; }
        string filePathACS { get; set; }        
        int FileDBFormat { get; set; }

        event EventHandler btnTestConnection;
    }
}
