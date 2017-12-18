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
   public partial class ShowLinks : Form {

      private MySqlContext context;
      private SortableBindingList<Link> links;

      public int Return { get; set; }
      public long LastInsertId { get; set; }

      public ShowLinks(MySqlContext _context) {
         InitializeComponent();
         context = _context;
         Return = -1;

         links = new SortableBindingList<Link>();
         readLinks();

         var source = new BindingSource(links, null);
         dataGridView1.DataSource = source;
         foreach (DataGridViewColumn column in dataGridView1.Columns) {
            dataGridView1.Columns[column.Name].SortMode = DataGridViewColumnSortMode.Automatic;
            dataGridView1.Columns[column.Name].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
         }
      }

      private void readLinks() { //Proper select must be queued -> instead of linkType ID -> linkType name
         using (MySqlConnection connection = new MySqlConnection(context.ConnectionString)) {
            MySqlCommand command = new MySqlCommand(Query.showLinks, connection);

            try {
               connection.Open();
               MySqlDataReader reader;
               reader = command.ExecuteReader();

               while (reader.Read()) {
                  int id = reader.GetInt32(0);
                  string url = reader.GetString(1);
                  string comment = "";
                  if (!reader.IsDBNull(2)) {
                     comment = reader.GetString(2);
                  }
                  string link_type = reader.GetString(3);
                  links.Add(new Link(id, link_type, url, comment));
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
         int correpsondingId = ((Link)dataGridView1.CurrentCell.OwningRow.DataBoundItem).Id;
         UpdateLink updateLinkForm = new UpdateLink(context, correpsondingId);
         updateLinkForm.ShowDialog();

         if (updateLinkForm.Return == 1) {
            ShowLinks showLinksForm = new ShowLinks(context);
            showLinksForm.Show();
            Dispose();
            Close();
         }
      }
   }
}
