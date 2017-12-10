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
   public partial class AddTown : Form {

      private MySqlContext context;
      private List<TownSize> townSizes;

      public int Return { get; set; }
      public long LastInsertId { get; set; }

      public AddTown(MySqlContext _context) {
         InitializeComponent();
         context = _context;
         Return = -1;

         townSizes = new List<TownSize>();
         readTownSizes();

         foreach (object obj in townSizes) {
            comboBox.Items.Add(obj);
         }

         comboBox.SelectedIndex = 0;
      }

      private void readTownSizes() {
         string commandText = "SELECT `id`, `size_name`, `lower_limit`, `upper_limit`, `comment` FROM `town_sizes`; ";
         using (MySqlConnection connection = new MySqlConnection(context.ConnectionString)) {
            MySqlCommand command = new MySqlCommand(commandText, connection);

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
                  townSizes.Add(new TownSize(id, size_name, lower_limit, upper_limit, comment));
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

      private void addLink_FormClosed(object sender, FormClosedEventArgs e) {

      }

      private void buttonOK_Click(object sender, EventArgs e) {
         if (addTownToDatabase()) {
            Return = 1;
            this.Close();
         }
      }

      private bool addTownToDatabase() {
         if (nameTB.Text == "") {
            MessageBox.Show("Town name cannot be empty");
            return false;
         }

         if (distanceTB.Text == "") {
            MessageBox.Show("Distance cannot be empty");
            return false;
         }

         string name = nameTB.Text;
         int town_size = ((TownSize)comboBox.SelectedItem).Id;
         int distance = Decimal.ToInt32(distanceTB.Value);
         string comment = commentTB.Text;

         string commandText = "INSERT INTO `towns` (`id`, `name`, `size`, `distance` ,`comment`) VALUES(NULL, @name, @size, @distance, @comment) ";
         using (MySqlConnection connection = new MySqlConnection(context.ConnectionString)) {
            MySqlCommand command = new MySqlCommand(commandText, connection);
            command.Parameters.AddWithValue("@name", name);
            command.Parameters.AddWithValue("@size", town_size);
            command.Parameters.AddWithValue("@distance", distance);
            if (comment == "") {
               command.Parameters.AddWithValue("@comment", DBNull.Value);
            }
            else {
               command.Parameters.AddWithValue("@comment", comment);
            }

            try {
               connection.Open();
               command.ExecuteNonQuery();
               LastInsertId = command.LastInsertedId;
               connection.Close();
            }
            catch (Exception ex) {
               MessageBox.Show("Something went wrong, when saving to database!\n" + ex.Message);
            }

         }

         return true;
      }

      private void buttonNEXT_Click(object sender, EventArgs e) {
         if (addTownToDatabase()) {
            Return = 2;
            this.Close();
         }
      }

      private void buttonCANCEL_Click(object sender, EventArgs e) {
         Return = 0;
         this.Close();
      }

      private void distMaps_Click(object sender, EventArgs e) {
         string destination = nameTB.Text;
         string search = "https://www.google.com/maps/dir/?api=1&origin=Żory&destination=" + destination;
         System.Diagnostics.Process.Start(search);
      }

   }
}
