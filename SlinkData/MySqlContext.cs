using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;


namespace SlinkData {
   public class MySqlContext {

      private const string server = "***";
      private const string database = "***";
      private const string uid = "***";
      private const string password = "***";

      public string ConnectionString { get; }
      private string lastError;

      public MySqlContext() {
         ConnectionString  = "SERVER=" + server + ";" 
                           + "DATABASE=" + database + ";"
                           + "UID=" + uid + ";"
                           + "PASSWORD=" + password + ";";
      }

      public bool IsConnectionPossible() {
         bool result = false;
         using ( MySqlConnection connection = new MySqlConnection(ConnectionString)) {
            try {
               connection.Open();
               result = true;
               connection.Close();
            } catch (Exception ex) {
               lastError = ex.Message;
            }
         }
         return result;
      }
      

      public string GetLastError() {
         return lastError;
      }
   }
}
