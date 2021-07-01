using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

using System.Diagnostics;

namespace IIDA.Model
{
    public class ModelBase
    {
        // Методы работы с базой данных
        // Загрузка и сохранение данных

        public int FileDBFormat = 0;

        DataAccessorBase accessor;

        // Список параметров для подключения к БД
        List<string> listParameters;

        public ModelBase()
        {
            // Все параметры по-умолчанию пустые
            listParameters = new List<string> { "", "", "" };
        }

        public void SetParameters(string filePathMDF, string filePathACS, int FileDBFormat)
        {
            listParameters[0] = filePathMDF;
            listParameters[1] = filePathACS;
            //listParameters[2] = filePathSQL;

            this.FileDBFormat = FileDBFormat;
        }

        public void InitConnection()
        {
            switch (FileDBFormat)
            {
                case 0:
                    accessor = new DataAccessorMDF();
                    break;

                case 1:
                    accessor = new DataAccessorACS();
                    break;

                case 2:
                    //accessor = new DataAccessorSQL();
                    break;

                default:
                    break;
            }
        }

        public string TestConnection()
        {
            //Debug.Print(">> " + listParameters.ElementAt(FileDBFormat));
            return accessor.TestConnection(accessor.GetConnectionString(listParameters.ElementAt(FileDBFormat)));
        }

        public bool IsValidParameters() =>
            listParameters.ElementAt(FileDBFormat).Length > 0 && File.Exists(listParameters.ElementAt(FileDBFormat));

        public void CloseConnection() => accessor.CloseConnection();
    }
}
