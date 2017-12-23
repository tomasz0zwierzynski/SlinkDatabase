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
   public partial class ShowFestivals : ContextedForm {

      private SortableBindingList<Festival> festivals;


      public ShowFestivals(MySqlContext _context) : base(_context) {
         InitializeComponent();

         festivals = new SortableBindingList<Festival>();
         readFestivals();

         var source = new BindingSource(festivals, null);
         dataGridView1.DataSource = source;
         foreach (DataGridViewColumn column in dataGridView1.Columns) {
            dataGridView1.Columns[column.Name].SortMode = DataGridViewColumnSortMode.Automatic;
            dataGridView1.Columns[column.Name].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
         }
      }

      private void readFestivals() {
         using (MySqlConnection connection = new MySqlConnection(context.ConnectionString)) {
            MySqlCommand command = new MySqlCommand(Query.showFestivals, connection);

            try {
               connection.Open();
               MySqlDataReader reader;
               reader = command.ExecuteReader();

               while (reader.Read()) {
                  int id = reader.GetInt32(0);
                  string name = reader.GetString(1);
                  string town = (!reader.IsDBNull(2)) ? reader.GetString(2) : "";
                  string link = (!reader.IsDBNull(3)) ? reader.GetString(3) : "";
                  string mail = (!reader.IsDBNull(4)) ? reader.GetString(4) : "";
                  string start = (!reader.IsDBNull(5)) ? reader.GetString(5) : "";
                  string deadline = (!reader.IsDBNull(6)) ? reader.GetString(6) : "";
                  string manager = (!reader.IsDBNull(7)) ? reader.GetString(7) : "";
                  string rank = (!reader.IsDBNull(8)) ? reader.GetString(8) : "";
                  string comment = (!reader.IsDBNull(9)) ? reader.GetString(9) : "";

                  festivals.Add(new Festival(id, name, town, link, mail, start, deadline, manager, rank, comment));
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

      private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
         int correpsondingId = ((Festival)dataGridView1.CurrentCell.OwningRow.DataBoundItem).Id;
         UpdateFestival updateFestivalForm = new UpdateFestival(context, correpsondingId);
         updateFestivalForm.ShowDialog();

         if (updateFestivalForm.Return == 1) {
            ShowFestivals showFestivalsForm = new ShowFestivals(context);
            showFestivalsForm.Show();
            Dispose();
            Close();
         }
      }

      private void ShowFestivals_Load(object sender, EventArgs e) {
         Size = (Size)Properties.Settings.Default["ShowFestivalsSize"];
         Location = (Point)Properties.Settings.Default["ShowFestivalsLocation"];
      }

      private void ShowFestivals_SizeChanged(object sender, EventArgs e) {
         Properties.Settings.Default["ShowFestivalsSize"] = Size;
         Properties.Settings.Default.Save();
      }

      private void ShowFestivals_LocationChanged(object sender, EventArgs e) {
         Properties.Settings.Default["ShowFestivalsLocation"] = Location;
         Properties.Settings.Default.Save();
      }
   }
}
