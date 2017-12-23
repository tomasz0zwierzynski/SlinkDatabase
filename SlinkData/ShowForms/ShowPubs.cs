using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SlinkData {
   public partial class ShowPubs : ContextedForm {

      private SortableBindingList<Pub> pubs;


      public ShowPubs(MySqlContext _context) : base(_context){
         InitializeComponent();


         pubs = new SortableBindingList<Pub>();
         readPubs();

         var source = new BindingSource(pubs, null);
         dataGridView1.DataSource = source;
         foreach (DataGridViewColumn column in dataGridView1.Columns) {
            dataGridView1.Columns[column.Name].SortMode = DataGridViewColumnSortMode.Automatic;
            dataGridView1.Columns[column.Name].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
         }
      }

      private void readPubs() { 
         using (MySqlConnection connection = new MySqlConnection(context.ConnectionString)) {
            MySqlCommand command = new MySqlCommand(Query.showPubs, connection);

            try {
               connection.Open();
               MySqlDataReader reader;
               reader = command.ExecuteReader();

               while (reader.Read()) {
                  int id = reader.GetInt32(0);
                  string name = (!reader.IsDBNull(1)) ? reader.GetString(1) : "";
                  string town = (!reader.IsDBNull(2)) ? reader.GetString(2) : "";
                  string rank = (!reader.IsDBNull(3)) ? reader.GetString(3) : "";
                  string manager = (!reader.IsDBNull(4)) ? reader.GetString(4) : "";
                  string mail = (!reader.IsDBNull(5)) ? reader.GetString(5) : "";
                  string link = (!reader.IsDBNull(6)) ? reader.GetString(6) : "";
                  string facebook = (!reader.IsDBNull(7)) ? reader.GetString(7) : "";
                  string comment = (!reader.IsDBNull(8)) ? reader.GetString(8) : "";

                  pubs.Add(new Pub(id, name, town, rank, manager, mail,link, facebook,comment));
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
         if (e.ColumnIndex == 4) {
            string email = ((Pub)dataGridView1.CurrentCell.OwningRow.DataBoundItem).Mail;
            if (email != "") {
               Process.Start("mailto:" + email);
               return;
            }
         }

         if (e.ColumnIndex == 5) {
            string link = ((Pub)dataGridView1.CurrentCell.OwningRow.DataBoundItem).Link;
            if (link != "") {
               if (Uri.IsWellFormedUriString(link, UriKind.Absolute)) {

                  ProcessStartInfo sInfo = new ProcessStartInfo(new Uri(link).AbsoluteUri);
                  Process.Start(sInfo);
                  return;
               }
            }
         }

         if (e.ColumnIndex == 6) {
            string link = ((Pub)dataGridView1.CurrentCell.OwningRow.DataBoundItem).Facebook;
            if (link != "") {
               if (Uri.IsWellFormedUriString(link, UriKind.Absolute)) {

                  ProcessStartInfo sInfo = new ProcessStartInfo(new Uri(link).AbsoluteUri);
                  Process.Start(sInfo);
                  return;
               }
            }
         }

         int correpsondingId = ((Pub)dataGridView1.CurrentCell.OwningRow.DataBoundItem).Id;
         UpdateClub updateClubForm = new UpdateClub(context, correpsondingId);
         updateClubForm.ShowDialog();

         if (updateClubForm.Return == 1) {
            ShowPubs showPubsForm = new ShowPubs(context);
            showPubsForm.Show();
            Dispose();
            Close();
         }
      }

      private void ShowPubs_Load(object sender, EventArgs e) {
         Size = (Size)Properties.Settings.Default["ShowPubsSize"];
         Location = (Point)Properties.Settings.Default["ShowPubsLocation"];
      }

      private void ShowPubs_SizeChanged(object sender, EventArgs e) {
         Properties.Settings.Default["ShowPubsSize"] = Size;
         Properties.Settings.Default.Save();
      }

      private void ShowPubs_LocationChanged(object sender, EventArgs e) {
         Properties.Settings.Default["ShowPubsLocation"] = Location;
         Properties.Settings.Default.Save();
      }
   }
}
