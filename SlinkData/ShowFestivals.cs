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
   public partial class ShowFestivals : Form {
      private MySqlContext context;
      private BindingList<Festival> festivals;

      public int Return { get; set; }
      public long LastInsertId { get; set; }

      public ShowFestivals(MySqlContext _context) {
         InitializeComponent();
         context = _context;
         Return = -1;

         festivals = new BindingList<Festival>();
         readFestivals();

         var source = new BindingSource(festivals, null);
         dataGridView1.DataSource = source;
      }

      private void readFestivals() { //Proper select must be queued -> instead of linkType ID -> linkType name
         string commandText = "SELECT 	`festivals`.`id`, `festivals`.`name`, `towns`.`name` AS `town`, `links`.`url` AS `link`, `festivals`.`e-mail`,`festivals`.`start_date`, `festivals`.`application_date`,		CONCAT(COALESCE(`people`.`forename`, ''), ' \"', COALESCE(`people`.`alias`, ''), '\" ', COALESCE(`people`.`surname`, '')) AS `manager`,        `ranks`.`rank_name` AS `rank`,        `festivals`.`comment`FROM `festivals`LEFT JOIN `links` ON( `festivals`.`link` IS NOT NULL AND `festivals`.`link` = `links`.`id`)LEFT JOIN `people`ON(`festivals`.`manager` IS NOT NULL AND `festivals`.`manager` = `people`.`id`)LEFT JOIN `ranks` ON(`festivals`.`rank` IS NOT NULL AND `festivals`.`rank` = `ranks`.`id`)LEFT JOIN `towns` ON( `festivals`.`town` IS NOT NULL AND `festivals`.`town` = `towns`.`id`)ORDER BY `name`; ";
         using (MySqlConnection connection = new MySqlConnection(context.ConnectionString)) {
            MySqlCommand command = new MySqlCommand(commandText, connection);

            try {
               connection.Open();
               MySqlDataReader reader;
               reader = command.ExecuteReader();

               while (reader.Read()) {
                  int id = reader.GetInt32(0);
                  string name = reader.GetString(1);
                  string town = "";
                  if (!reader.IsDBNull(2)) {
                     town = reader.GetString(2);
                  }
                  string link = "";
                  if (!reader.IsDBNull(3)) {
                     link = reader.GetString(3);
                  }
                  string mail = "";
                  if (!reader.IsDBNull(4)) {
                     mail = reader.GetString(4);
                  }
                  string start = "";
                  if (!reader.IsDBNull(5)) {
                     start = reader.GetString(5);
                  }
                  string deadline = "";
                  if (!reader.IsDBNull(6)) {
                     deadline = reader.GetString(6);
                  }
                  string manager = "";
                  if (!reader.IsDBNull(7)) {
                     manager = reader.GetString(7);
                  }
                  string rank = "";
                  if (!reader.IsDBNull(8)) {
                     rank = reader.GetString(8);
                  }
                  string comment = "";
                  if (!reader.IsDBNull(9)) {
                     comment = reader.GetString(9);
                  }
                  festivals.Add(new Festival(id, name, town, link,mail, start, deadline, manager, rank, comment));
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
