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
   
   public partial class ShowPeople : ContextedForm {
      

      private SortableBindingList<PersonExt> people;


      public ShowPeople(MySqlContext _context) : base(_context){
         InitializeComponent();

         people = new SortableBindingList<PersonExt>();
         readPeople();

         var source = new BindingSource(people, null);
         dataGridView1.DataSource = source;
         foreach (DataGridViewColumn column in dataGridView1.Columns) {
            dataGridView1.Columns[column.Name].SortMode = DataGridViewColumnSortMode.Automatic;
            dataGridView1.Columns[column.Name].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
         }
      }

      private void readPeople() { //Proper select must be queued -> instead of linkType ID -> linkType name
         //string commandText = "SELECT 	`people`.`id`, CONCAT( COALESCE(`people`.`forename`, ''),' \"',COALESCE(`people`.`alias`, ''),'\" ',COALESCE(`people`.`surname`, '')) AS `name`,`people`.`phonenumber`, `people`.`e-mail`, `people`.`comment`, `links`.`url` AS `link_name`,`occ1`.`name` AS `occupation 1`,`occ2`.`name` AS `occupation 2`FROM `people`LEFT JOIN `links` ON( `people`.`link` IS NOT NULL AND `people`.`link` = `links`.`id`)LEFT JOIN `occupations` `occ1` ON(`people`.`occupation` IS NOT NULL AND `people`.`occupation` = `occ1`.`id`)LEFT JOIN `occupations` `occ2` ON(`people`.`occupation2` IS NOT NULL AND `people`.`occupation2` = `occ2`.`id`)ORDER BY `name`; ";
         using (MySqlConnection connection = new MySqlConnection(context.ConnectionString)) {
            MySqlCommand command = new MySqlCommand(Query.showPeople, connection);

            try {
               connection.Open();
               MySqlDataReader reader;
               reader = command.ExecuteReader();

               while (reader.Read()) {
                  int id = reader.GetInt32(0);
                  string name = (!reader.IsDBNull(1)) ? reader.GetString(1) : "";
                  string phonenumber = (!reader.IsDBNull(2)) ? reader.GetString(2) : "";
                  string mail = (!reader.IsDBNull(3)) ? reader.GetString(3) : "";
                  string comment = (!reader.IsDBNull(4)) ? reader.GetString(4) : "";
                  string link = (!reader.IsDBNull(5)) ? reader.GetString(5) : "";
                  string occupy1 = (!reader.IsDBNull(6)) ? reader.GetString(6) : "";
                  string occupy2 = (!reader.IsDBNull(7)) ? reader.GetString(7) : "";

                  people.Add(new PersonExt(id, name, phonenumber, mail, comment, link, occupy1,occupy2));
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
         int correpsondingId = ((PersonExt)dataGridView1.CurrentCell.OwningRow.DataBoundItem).Id;
         UpdatePerson updatePersonForm = new UpdatePerson(context, correpsondingId);
         updatePersonForm.ShowDialog();

         if (updatePersonForm.Return == 1) {
            ShowPeople showPeopleForm = new ShowPeople(context);
            showPeopleForm.Show();
            Dispose();
            Close();
         }
      }

      private void ShowPeople_Load(object sender, EventArgs e) {
         Size = (Size)Properties.Settings.Default["ShowPeopleSize"];
         Location = (Point)Properties.Settings.Default["ShowPeopleLocation"];
      }

      private void ShowPeople_SizeChanged(object sender, EventArgs e) {
         Properties.Settings.Default["ShowPeopleSize"] = Size;
         Properties.Settings.Default.Save();
      }

      private void ShowPeople_LocationChanged(object sender, EventArgs e) {
         Properties.Settings.Default["ShowPeopleLocation"] = Location;
         Properties.Settings.Default.Save();
      }
   }
   
}
