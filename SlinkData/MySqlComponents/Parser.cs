using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlinkData {
   public static class Parser {
      public static void AddWithValue<T_type>(MySqlCommand command,string parameter,T_type value) where T_type : IComparable {
         if ( typeof(T_type) == typeof(int)) {
            if ( (dynamic)value == 0) {
               command.Parameters.AddWithValue(parameter, DBNull.Value);
            }
            else {
               command.Parameters.AddWithValue(parameter, value);
            }
         }
         if ( typeof(T_type) == typeof(string)) {
            if ((dynamic)value == "") {
               command.Parameters.AddWithValue(parameter, DBNull.Value);
            }
            else {
               command.Parameters.AddWithValue(parameter, value);
            }
         }
      }
   }
}
