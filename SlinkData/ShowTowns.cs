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
   public partial class ShowTowns : Form {

      private MySqlContext context;
      private BindingList<TownExt> towns;

      public int Return { get; set; }
      public long LastInsertId { get; set; }

      public ShowTowns(MySqlContext _context) {
         InitializeComponent();
         context = _context;
         Return = -1;

         towns = new BindingList<TownExt>();
         readTowns();

         var source = new BindingSource(towns, null);
         dataGridView1.DataSource = source;
      }

      private void readTowns() { //Proper select must be queued -> instead of linkType ID -> linkType name
         string commandText = "SELECT `towns`.`id`, `towns`.`name`, `towns`.`distance`, `town_sizes`.`size_name` FROM `towns` JOIN `town_sizes`ON `towns`.`size` = `town_sizes`.`id` ORDER BY `towns`.`name`;";
         using (MySqlConnection connection = new MySqlConnection(context.ConnectionString)) {
            MySqlCommand command = new MySqlCommand(commandText, connection);

            try {
               connection.Open();
               MySqlDataReader reader;
               reader = command.ExecuteReader();

               while (reader.Read()) {
                  int id = reader.GetInt32(0);
                  string name = reader.GetString(1);
                  int distance = 0;
                  if (!reader.IsDBNull(2)) {
                     distance = reader.GetInt32(2);
                  }
                  string size = reader.GetString(3);
                  towns.Add(new TownExt(id, name, distance, size));
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
