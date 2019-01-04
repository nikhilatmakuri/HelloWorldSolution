using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using HelloWorld.DataAccess.Interface;

namespace HelloWorld.DataAccess.Implementation
{
    public class DataService : IDataService
    {
        public string GetKeyWordById(int id)
        {
            string result = ConfigurationManager.AppSettings["APIKeyWord"];
            return string.Format("{0} {1}", result, id.ToString());

            // Sample Code to get the exact result from the DB tables.
            //string connectionString = ConfigurationManager.AppSettings["DataServices"];

            //string queryString = string.Format("SELECT KeyWord FROM KeyWords WHERE Id = {0}", id);
            //using (SqlConnection connection = new SqlConnection(connectionString))
            //{
            //    SqlCommand command = new SqlCommand(queryString, connection);
               
            //    try
            //    {
            //        connection.Open();
            //        var returnValue = command.ExecuteScalar();

            //        result = returnValue.ToString();
            //        return string.Format("{0} {1}", result, id.ToString()) ;
            //    }
            //    catch (Exception ex)
            //    {
            //        throw ex;
            //    }
                
            //}
        }

        public string GetKeyWords()
        {
            //Hard Coded response. When a specfic table or source exists can be modified accordingly.

            return ConfigurationManager.AppSettings["APIKeyWord"];
            //throw new NotImplementedException();
        }
    }
}
