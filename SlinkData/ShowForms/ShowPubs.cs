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
      private SortableBindingList<Pub> pubs;

      public int Return { get; set; }
      public long LastInsertId { get; set; }

      public ShowPubs(MySqlContext _context) {
         InitializeComponent();
         context = _context;
         Return = -1;

         pubs = new SortableBindingList<Pub>();
         readPubs();

         var source = new BindingSource(pubs, null);
         dataGridView1.DataSource = source;
         foreach (DataGridViewColumn column in dataGridView1.Columns) {
            dataGridView1.Columns[column.Name].SortMode = DataGridViewColumnSortMode.Automatic;
            dataGridView1.Columns[column.Name].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
         }
      }

      private void readPubs() { //Proper select must be queued -> instead of linkType ID -> linkType name
         using (MySqlConnection connection = new MySqlConnection(context.ConnectionString)) {
            MySqlCommand command = new MySqlCommand(Query.showPubs, connection);

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

      private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
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
   }
}
