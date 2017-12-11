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
   public partial class ShowPubs : Form {
      private MySqlContext context;
      private BindingList<Pub> pubs;

      public int Return { get; set; }
      public long LastInsertId { get; set; }

      public ShowPubs(MySqlContext _context) {
         InitializeComponent();
         context = _context;
         Return = -1;

         pubs = new BindingList<Pub>();
         readPubs();

         var source = new BindingSource(pubs, null);
         dataGridView1.DataSource = source;
      }

      private void readPubs() { //Proper select must be queued -> instead of linkType ID -> linkType name
         string commandText = "SELECT 	`clubs`.`id`, `clubs`.`name` AS `club_name`, `towns`.`name` AS `town`,`ranks`.`rank_name` AS `rank`, CONCAT(COALESCE(`people`.`forename`, ''), ' \"',COALESCE(`people`.`alias`,''), '\" ',COALESCE(`people`.`surname`,'')) AS `manager`,`clubs`.`e-mail`,`links`.`url` AS `link`,`clubs`.`comment` FROM `clubs` LEFT JOIN `towns`ON (`clubs`.`town` IS NOT NULL AND `clubs`.`town` = `towns`.`id`) LEFT JOIN `ranks` ON (`clubs`.`rank` IS NOT NULL AND `clubs`.`rank` = `ranks`.`id`) LEFT JOIN `people`ON (`clubs`.`manager` IS NOT NULL AND `clubs`.`manager` = `people`.`id`) LEFT JOIN `links` ON (`clubs`.`link` IS NOT NULL AND`clubs`.`link` = `links`.`id`) ORDER BY `clubs`.`rank` DESC; ";
         using (MySqlConnection connection = new MySqlConnection(context.ConnectionString)) {
            MySqlCommand command = new MySqlCommand(commandText, connection);

            try {
               connection.Open();
               MySqlDataReader reader;
               reader = command.ExecuteReader();

               while (reader.Read()) {
                  int id = reader.GetInt32(0);
                  string name = reader.GetString(1);
                  string town = reader.GetString(2);
                  string rank = reader.GetString(3);
                  string manager = "";
                  if (!reader.IsDBNull(4)) {
                     manager = reader.GetString(4);
                  }
                  string mail = "";
                  if (!reader.IsDBNull(5)) {
                     mail = reader.GetString(5);
                  }
                  string link = "";
                  if (!reader.IsDBNull(6)) {
                     link = reader.GetString(6);
                  }
                  string comment = "";
                  if (!reader.IsDBNull(7)) {
                     comment = reader.GetString(7);
                  }

                  pubs.Add(new Pub(id, name, town, rank, manager, mail,link, comment));
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
