using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SlinkData {
   
   public partial class ShowPeople : Form {
      
      private MySqlContext context;
      private BindingList<PersonExt> people;

      public int Return { get; set; }
      public long LastInsertId { get; set; }

      public ShowPeople(MySqlContext _context) {
         InitializeComponent();
         context = _context;
         Return = -1;

         people = new BindingList<PersonExt>();
         readPeople();

         var source = new BindingSource(people, null);
         dataGridView1.DataSource = source;
      }

      private void readPeople() { //Proper select must be queued -> instead of linkType ID -> linkType name
         string commandText = "SELECT 	`people`.`id`, CONCAT( COALESCE(`people`.`forename`, ''),' \"',COALESCE(`people`.`alias`, ''),'\" ',COALESCE(`people`.`surname`, '')) AS `name`,`people`.`phonenumber`, `people`.`e-mail`, `people`.`comment`, `links`.`url` AS `link_name`,`occ1`.`name` AS `occupation 1`,`occ2`.`name` AS `occupation 2`FROM `people`LEFT JOIN `links` ON( `people`.`link` IS NOT NULL AND `people`.`link` = `links`.`id`)LEFT JOIN `occupations` `occ1` ON(`people`.`occupation` IS NOT NULL AND `people`.`occupation` = `occ1`.`id`)LEFT JOIN `occupations` `occ2` ON(`people`.`occupation2` IS NOT NULL AND `people`.`occupation2` = `occ2`.`id`)ORDER BY `name`; ";
         using (MySqlConnection connection = new MySqlConnection(context.ConnectionString)) {
            MySqlCommand command = new MySqlCommand(commandText, connection);

            try {
               connection.Open();
               MySqlDataReader reader;
               reader = command.ExecuteReader();

               while (reader.Read()) {
                  int id = reader.GetInt32(0);
                  string name = reader.GetString(1);
                  string phonenumber = "";
                  if (!reader.IsDBNull(2)) {
                     phonenumber = reader.GetString(2);
                  }
                  string mail = "";
                  if (!reader.IsDBNull(3)) {
                     mail = reader.GetString(3);
                  }
                  string comment = "";
                  if (!reader.IsDBNull(4)) {
                     comment = reader.GetString(4);
                  }
                  string link = "";
                  if (!reader.IsDBNull(5)) {
                     link = reader.GetString(5);
                  }
                  string occupy1 = "";
                  if (!reader.IsDBNull(6)) {
                     occupy1 = reader.GetString(6);
                  }
                  string occupy2 = "";
                  if (!reader.IsDBNull(7)) {
                     occupy2 = reader.GetString(7);
                  }

                  people.Add(new PersonExt(id, name, phonenumber, mail, comment, link, occupy1,occupy2));
               }

               reader.Close();
               connection.Close();
            }
            catch (Exception ex) {
               MessageBox.Show("Something went wrong, when opening from database!\n" + ex.Message);
               Return = -2;
               this.Close();
            }

         }
      }
      
   }
   
}
