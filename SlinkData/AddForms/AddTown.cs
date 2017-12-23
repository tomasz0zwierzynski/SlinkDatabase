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
   public partial class AddTown : ContextedForm {

      private List<TownSizeString> townSizes;


      public AddTown(MySqlContext _context) : base(_context) {
         InitializeComponent();

         try {
            townSizes = TownSizeGet.Read(context, false);
         }catch(Exception ex) {
            MessageBox.Show("Something went wrong, when opening from database!\n" + ex.Message);
            Return = -2;
            this.Close();
         }

         GenericForm.FillComboBox(comboBox, townSizes, true);

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
         int town_size = ((TownSizeString)comboBox.SelectedItem).Id;
         int distance = Decimal.ToInt32(distanceTB.Value);
         string comment = commentTB.Text;

         using (MySqlConnection connection = new MySqlConnection(context.ConnectionString)) {
            MySqlCommand command = new MySqlCommand(Query.insertIntoTowns, connection);
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
