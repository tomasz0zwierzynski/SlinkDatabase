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
   public partial class UpdateTown : ContextedForm {

      private List<TownSizeString> townSizes;

      private int selectedTownId;
      TownRaw selectedTown;


      public UpdateTown(MySqlContext _context, int _selectedTownId) : base(_context) {
         InitializeComponent();


         selectedTownId = _selectedTownId;
         selectedTown = readTownOf(selectedTownId);

         nameTB.Text = selectedTown.Name;
         commentTB.Text = selectedTown.Comment;
         distanceTB.Value = selectedTown.Distance;

         try {
            townSizes = TownSizeGet.Read(context, false);
         }
         catch (Exception ex) {
            MessageBox.Show("Something went wrong, when opening from database!\n" + ex.Message);
            Return = -2;
            this.Close();
         }

         GenericForm.FillComboBox(comboBox, townSizes, selectedTown.Size);

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
                  string name = (!reader.IsDBNull(1)) ? reader.GetString(1) : "";
                  int distance = (!reader.IsDBNull(3)) ? reader.GetInt32(3) : 0;
                  int size = (!reader.IsDBNull(2)) ? reader.GetInt32(2) : 0;
                  string comment = (!reader.IsDBNull(4)) ? reader.GetString(4) : "";

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
         int town_size = ((TownSizeString)comboBox.SelectedItem).Id;
         int distance = Decimal.ToInt32(distanceTB.Value);
         string comment = commentTB.Text;

         using (MySqlConnection connection = new MySqlConnection(context.ConnectionString)) {
            MySqlCommand command = new MySqlCommand(Query.updateTown, connection);
            Parser.AddWithValue(command, "@id", selectedTownId);
            Parser.AddWithValue(command, "@name", name);
            Parser.AddWithValue(command, "@size", town_size);
            Parser.AddWithValue(command, "@distance", distance);
            Parser.AddWithValue(command, "@comment", comment);

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
