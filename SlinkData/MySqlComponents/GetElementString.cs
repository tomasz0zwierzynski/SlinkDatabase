using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlinkData {

   class LinkGet {

      public static List<LinkString> Read(MySqlContext context, bool isNullLinkNeeded) {
         List<LinkString> links = new List<LinkString>();

         if (isNullLinkNeeded) {
            links.Add(new LinkString(0, "", "", ""));
         }

         using (MySqlConnection connection = new MySqlConnection(context.ConnectionString)) {
            MySqlCommand command = new MySqlCommand(Query.selectLinks, connection);

            try {
               connection.Open();
               MySqlDataReader reader;
               reader = command.ExecuteReader();

               while (reader.Read()) {
                  int id = reader.GetInt32(0);
                  string url = reader.GetString(1);
                  string comment = "";
                  if (!reader.IsDBNull(2)) {
                     comment = reader.GetString(2);
                  }
                  string link_type = reader.GetString(3);
                  links.Add(new LinkString(id, link_type, url, comment));
               }

               reader.Close();
               connection.Close();
            }
            catch (Exception ex) {
               throw ex;               
            }

         }

         return links;
      }

   }

   class RankGet {
      public static List<RankString> Read(MySqlContext context, bool isNullRankNeeded) {
         List<RankString> ranks = new List<RankString>();

         if (isNullRankNeeded) {
            ranks.Add(new RankString(0,"",0,""));
         }

         using (MySqlConnection connection = new MySqlConnection(context.ConnectionString)) {
            MySqlCommand command = new MySqlCommand(Query.selectRanks, connection);

            try {
               connection.Open();
               MySqlDataReader reader;
               reader = command.ExecuteReader();

               while (reader.Read()) {
                  int id = reader.GetInt32(0);
                  string rank_name = reader.GetString(1);
                  int rank_value = reader.GetInt32(2);
                  string comment = "";
                  if (!reader.IsDBNull(3)) {
                     comment = reader.GetString(3);
                  }
                  ranks.Add(new RankString(id, rank_name, rank_value, comment));
               }

               reader.Close();
               connection.Close();
            }
            catch (Exception ex) {
               throw ex;
            }
         }
         
         return ranks;
      }
   }

   class TownGet {
      public static List<TownString> Read(MySqlContext context, bool isNullTownNeeded) {
         List<TownString> towns = new List<TownString>();

         if (isNullTownNeeded) {
            towns.Add(new TownString(0,""));
         }

         using (MySqlConnection connection = new MySqlConnection(context.ConnectionString)) {
            MySqlCommand command = new MySqlCommand(Query.selectTowns, connection);

            try {
               connection.Open();
               MySqlDataReader reader;
               reader = command.ExecuteReader();

               while (reader.Read()) {
                  int id = reader.GetInt32(0);
                  string name = reader.GetString(1);
                  towns.Add(new TownString(id, name));
               }

               reader.Close();
               connection.Close();
            }
            catch (Exception ex) {
               throw ex;
            }
         }

         return towns;
      }
   }

   class TownSizeGet {
      public static List<TownSizeString> Read(MySqlContext context, bool isNullSizeNeeded) {
         List<TownSizeString> townSizes = new List<TownSizeString>();

         if (isNullSizeNeeded) {
            townSizes.Add(new TownSizeString(0, "", 0, 0, ""));
         }

         using (MySqlConnection connection = new MySqlConnection(context.ConnectionString)) {
            MySqlCommand command = new MySqlCommand(Query.selectTownSizes, connection);

            try {
               connection.Open();
               MySqlDataReader reader;
               reader = command.ExecuteReader();

               while (reader.Read()) {
                  int id = reader.GetInt32(0);
                  string size_name = reader.GetString(1);
                  int lower_limit = reader.GetInt32(2);
                  int upper_limit = reader.GetInt32(3);
                  string comment = "";
                  if (!reader.IsDBNull(4)) {
                     comment = reader.GetString(4);
                  }
                  townSizes.Add(new TownSizeString(id, size_name, lower_limit, upper_limit, comment));
               }

               reader.Close();
               connection.Close();
            }
            catch (Exception ex) {
               throw ex;
            }
         }

         return townSizes;
      }
   }

   class PersonGet {
      public static List<PersonString> Read(MySqlContext context, bool isNullPersonNeeded) {
         List<PersonString> people = new List<PersonString>();

         if (isNullPersonNeeded) {
            people.Add(new PersonString(0,"","","",""));
         }

         using (MySqlConnection connection = new MySqlConnection(context.ConnectionString)) {
            MySqlCommand command = new MySqlCommand(Query.selectPeople, connection);

            try {
               connection.Open();
               MySqlDataReader reader;
               reader = command.ExecuteReader();

               while (reader.Read()) {
                  int id = reader.GetInt32(0);
                  string forename = "";
                  if (!reader.IsDBNull(1)) {
                     forename = reader.GetString(1);
                  }
                  string surname = "";
                  if (!reader.IsDBNull(2)) {
                     surname = reader.GetString(2);
                  }
                  string alias = "";
                  if (!reader.IsDBNull(3)) {
                     alias = reader.GetString(3);
                  }
                  string comment = "";
                  if (!reader.IsDBNull(4)) {
                     comment = reader.GetString(4);
                  }
                  people.Add(new PersonString(id, forename, surname, alias, comment));
               }

               reader.Close();
               connection.Close();
            }
            catch (Exception ex) {
               throw ex;
            }
         }

         return people;
      }
   }

   class LinkTypeGet {
      public static List<LinkTypeString> Read(MySqlContext context, bool isNullTypeNeeded) {
         List<LinkTypeString> linkTypes = new List<LinkTypeString>();

         if (isNullTypeNeeded) {
            linkTypes.Add(new LinkTypeString(0, "", ""));
         }

         using (MySqlConnection connection = new MySqlConnection(context.ConnectionString)) {
            MySqlCommand command = new MySqlCommand(Query.selectLinkTypes, connection);

            try {
               connection.Open();
               MySqlDataReader reader;
               reader = command.ExecuteReader();

               while (reader.Read()) {
                  int id = reader.GetInt32(0);
                  string name = reader.GetString(1);
                  string description = "";
                  if (!reader.IsDBNull(2)) {
                     description = reader.GetString(2);
                  }
                  linkTypes.Add(new LinkTypeString(id, name, description));
               }

               reader.Close();
               connection.Close();
            }
            catch (Exception ex) {
               throw ex;
            }

         }

         return linkTypes;
      }
   }

   class OccupationGet {
      public static List<OccupationString> Read(MySqlContext context, bool isNullOccupyNeeded) {
         List<OccupationString> occupations = new List<OccupationString>();

         if (isNullOccupyNeeded) {
            occupations.Add(new OccupationString(0,"",""));
         }

         using (MySqlConnection connection = new MySqlConnection(context.ConnectionString)) {
            MySqlCommand command = new MySqlCommand(Query.selectOccupations, connection);

            try {
               connection.Open();
               MySqlDataReader reader;
               reader = command.ExecuteReader();

               while (reader.Read()) {
                  int id = reader.GetInt32(0);
                  string name = reader.GetString(1);
                  string description = "";
                  if (!reader.IsDBNull(2)) {
                     description = reader.GetString(2);
                  }
                  occupations.Add(new OccupationString(id, name, description));
               }

               reader.Close();
               connection.Close();
            }
            catch (Exception ex) {
               throw ex;
            }

         }

         return occupations;
      }
   }
}
