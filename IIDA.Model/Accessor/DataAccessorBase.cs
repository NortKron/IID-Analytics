using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IIDA.Model
{
    /*
     * Паттерн Factory Method
     * 
     * Базовый класс для работы с базами данными разных типов 
     * 1) Локальная БД MS Access
     * 2) Локальная БД в формате MDF
     * 3) Удалённая БД на SQL Server
     * 
    */

    abstract class DataAccessorBase
    {
        public abstract void InitConnection(string connectString);
        public abstract void TestConnection(string connectString);
        public abstract void CloseConnection();
        public abstract void GetData();
    }
}
