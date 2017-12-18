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
      private SortableBindingList<TownExt> towns;

      public int Return { get; set; }
      public long LastInsertId { get; set; }

      public ShowTowns(MySqlContext _context) {
         InitializeComponent();
         context = _context;
         Return = -1;

         towns = new SortableBindingList<TownExt>();
         readTowns();

         var source = new BindingSource(towns, null);
         dataGridView1.DataSource = source;
         foreach (DataGridViewColumn column in dataGridView1.Columns) {
            dataGridView1.Columns[column.Name].SortMode = DataGridViewColumnSortMode.Automatic;
            dataGridView1.Columns[column.Name].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
         }
      }

      private void readTowns() {
         using (MySqlConnection connection = new MySqlConnection(context.ConnectionString)) {
            MySqlCommand command = new MySqlCommand(Query.showTowns, connection);

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

      private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
         int correpsondingId = ((TownExt)dataGridView1.CurrentCell.OwningRow.DataBoundItem).Id;
         UpdateTown updateTownForm = new UpdateTown(context, correpsondingId);
         updateTownForm.ShowDialog();

         if (updateTownForm.Return == 1) {
            ShowTowns showTownsForm = new ShowTowns(context);
            showTownsForm.Show();
            Dispose();
            Close();
         }
      }
   }
}
