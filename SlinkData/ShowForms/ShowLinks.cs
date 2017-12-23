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
   public partial class ShowLinks : ContextedForm {


      private SortableBindingList<LinkString> links;


      public ShowLinks(MySqlContext _context) : base(_context) {
         InitializeComponent();

         links = new SortableBindingList<LinkString>();
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
                  string url = (!reader.IsDBNull(1)) ? reader.GetString(1) : "";
                  string comment = (!reader.IsDBNull(2)) ? reader.GetString(2) : "";
                  string link_type = (!reader.IsDBNull(3)) ? reader.GetString(3) : "";

                  links.Add(new LinkString(id, link_type, url, comment));
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
         int correpsondingId = ((LinkString)dataGridView1.CurrentCell.OwningRow.DataBoundItem).Id;
         UpdateLink updateLinkForm = new UpdateLink(context, correpsondingId);
         updateLinkForm.ShowDialog();

         if (updateLinkForm.Return == 1) {
            ShowLinks showLinksForm = new ShowLinks(context);
            showLinksForm.Show();
            Dispose();
            Close();
         }
      }

      private void ShowLinks_Load(object sender, EventArgs e) {
         Size = (Size)Properties.Settings.Default["ShowLinksSize"];
         Location = (Point)Properties.Settings.Default["ShowLinksLocation"];
      }

      private void ShowLinks_LocationChanged(object sender, EventArgs e) {
         Properties.Settings.Default["ShowLinksLocation"] = Location;
         Properties.Settings.Default.Save();
      }

      private void ShowLinks_SizeChanged(object sender, EventArgs e) {
         Properties.Settings.Default["ShowLinksSize"] = Size;
         Properties.Settings.Default.Save();
      }
   }
}
