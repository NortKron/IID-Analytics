using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

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

        public override string TestConnection(string connectString)
        {
            try
            {
                myConnection = new OleDbConnection(connectString);
                myConnection.Open();
                // TODO : Get something data
                myConnection.Close();
            }
            catch (Exception err)
            {
                return "Connection failed \nErr: " + err.Message;
            }

            return "Connection is good";
        }

        public override void CloseConnection()
        {
            myConnection.Close();
        }
        
        public override void GetData()
        {

        }

        public override string GetConnectionString(string filePath)
        {
            return String.Format(@"Provider=Microsoft.ACE.OLEDB.12.0; Data Source='{0}';", filePath);
        }
    }
}
