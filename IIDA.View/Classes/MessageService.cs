using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using IIDA.Presenter;

namespace IIDA.View
{    
    public class MessageService : IMessageService
    {
        /*
         * Здесь комментарий номер 1
         */
        public void ShowMessage(string message)
        {            
            MessageBox.Show(message, "Заголовок информационного сообщения", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void ShowExclamation(string exclamation)
        {
            MessageBox.Show(exclamation, "Заголовок сообщения с предупреждением", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public void ShowError(string error)
        {
            MessageBox.Show(error, "Заголовок сообщения об ошибке", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
