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
   public partial class ShowFestivals : Form {
      private MySqlContext context;
      private SortableBindingList<Festival> festivals;

      public int Return { get; set; }
      public long LastInsertId { get; set; }

      public ShowFestivals(MySqlContext _context) {
         InitializeComponent();
         context = _context;
         Return = -1;

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
                  string town = "";
                  if (!reader.IsDBNull(2)) {
                     town = reader.GetString(2);
                  }
                  string link = "";
                  if (!reader.IsDBNull(3)) {
                     link = reader.GetString(3);
                  }
                  string mail = "";
                  if (!reader.IsDBNull(4)) {
                     mail = reader.GetString(4);
                  }
                  string start = "";
                  if (!reader.IsDBNull(5)) {
                     start = reader.GetString(5);
                  }
                  string deadline = "";
                  if (!reader.IsDBNull(6)) {
                     deadline = reader.GetString(6);
                  }
                  string manager = "";
                  if (!reader.IsDBNull(7)) {
                     manager = reader.GetString(7);
                  }
                  string rank = "";
                  if (!reader.IsDBNull(8)) {
                     rank = reader.GetString(8);
                  }
                  string comment = "";
                  if (!reader.IsDBNull(9)) {
                     comment = reader.GetString(9);
                  }
                  festivals.Add(new Festival(id, name, town, link,mail, start, deadline, manager, rank, comment));
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
   }
}
