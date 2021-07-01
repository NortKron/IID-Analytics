using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace IIDA.Model
{
    class DataAccessorMDF : DataAccessorBase
    {
        SqlConnection myConnection;

        public override void InitConnection(string connectString)
        {
            myConnection = new(connectString);
            myConnection.Open();
        }

        public override void CloseConnection()
        {
            myConnection.Close();
        }

        public override string TestConnection(string connectString)
        {
            try
            {
                myConnection = new (connectString);
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

        public override string GetConnectionString(string filePath)
        {
            return String.Format(@"Data Source=(LocalDB)\MSSQLLocalDB; AttachDbFilename='{0}'; Integrated Security=True", filePath);
        }

        public override void GetData()
        {
            throw new NotImplementedException();
        }
    }
}
