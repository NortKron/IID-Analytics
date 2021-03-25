using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.OleDb;

namespace IIDA.Model
{
    class DataAccessorACS : DataAccessorBase
    {
        OleDbConnection myConnection;
        OleDbCommand command;
        OleDbDataReader reader;

        public override void InitConnection(string connectString)
        {
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
        }

        public override void TestConnection(string connectString)
        {
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();

            // TODO : Get something data

            myConnection.Close();
        }

        public override void CloseConnection()
        {
            myConnection.Close();
        }
        
        public override void GetData()
        {

        }

    }
}
