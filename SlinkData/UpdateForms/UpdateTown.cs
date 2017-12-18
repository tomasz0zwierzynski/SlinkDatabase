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
   public partial class UpdateTown : Form {

      private MySqlContext context;
      private List<TownSize> townSizes;

      private int selectedTownId;
      TownRaw selectedTown;

      public int Return { get; set; }
      public long LastInsertId { get; set; }

      public UpdateTown(MySqlContext _context, int _selectedTownId) {
         InitializeComponent();
         context = _context;
         Return = -1;

         selectedTownId = _selectedTownId;
         selectedTown = readTownOf(selectedTownId);

         nameTB.Text = selectedTown.Name;
         commentTB.Text = selectedTown.Comment;
         distanceTB.Value = selectedTown.Distance;

         townSizes = new List<TownSize>();
         readTownSizes();
         TownSize currentTownSize = null;
         foreach (TownSize obj in townSizes) {
            comboBox.Items.Add(obj);
            if (obj.Id == selectedTown.Size) {
               currentTownSize = obj;
            }
         }
         comboBox.SelectedIndex = comboBox.Items.IndexOf(currentTownSize);
        
      }

      private TownRaw readTownOf(int id) {
         TownRaw town = null;
         using (MySqlConnection connection = new MySqlConnection(context.ConnectionString)) {
            MySqlCommand command = new MySqlCommand(Query.selectTown, connection);
            command.Parameters.AddWithValue("@id", id);
            try {
               connection.Open();
               MySqlDataReader reader;
               reader = command.ExecuteReader();

               while (reader.Read()) {
                  string name = reader.GetString(1);
                  int size = reader.GetInt32(2);
                  int distance = 0;
                  if (!reader.IsDBNull(3)) {
                     distance = reader.GetInt32(3);
                  }
                  string comment = "";
                  if (!reader.IsDBNull(4)) {
                     comment = reader.GetString(4);
                  }

                  town = new TownRaw(id, name, distance, size, comment);
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

         return town;
      }

      private void readTownSizes() {
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
         if (updateTown()) {
            Return = 1;
            this.Close();
         }
      }

      private bool updateTown() {
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

         using (MySqlConnection connection = new MySqlConnection(context.ConnectionString)) {
            MySqlCommand command = new MySqlCommand(Query.updateTown, connection);
            command.Parameters.AddWithValue("@id", selectedTownId);
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
