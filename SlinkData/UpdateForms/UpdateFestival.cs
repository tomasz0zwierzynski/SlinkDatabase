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
   public partial class UpdateFestival : ContextedForm {

      private List<LinkString> links;
      private List<RankString> ranks;
      private List<TownString> towns;
      private List<PersonString> people;

      private int selectedFestivalId;
      FestivalRaw selectedFestival;


      public UpdateFestival(MySqlContext _context, int _selectedFestivalId) :base(_context) {
         InitializeComponent();

         selectedFestivalId = _selectedFestivalId;
         selectedFestival = readFestivalOf(selectedFestivalId);

         //Put data from query to input boxes views
         nameTB.Text = selectedFestival.Name;
         emailTB.Text = selectedFestival.Mail;
         commentTB.Text = selectedFestival.Comment;

         try {
            links = LinkGet.Read(context, true);
            ranks = RankGet.Read(context, false);
            towns = TownGet.Read(context, true);
            people = PersonGet.Read(context, true);
         }
         catch (Exception ex) {
            MessageBox.Show("Something went wrong, when opening from database!\n" + ex.Message);
            Return = -2;
            this.Close();
         }

         GenericForm.FillComboBox(linkCB, links, selectedFestival.Link);
         GenericForm.FillComboBox(rankCB, ranks, selectedFestival.Rank);
         GenericForm.FillComboBox(townCB, towns, selectedFestival.Town);
         GenericForm.FillComboBox(managerCB, people, selectedFestival.Manager);

         if (selectedFestival.Deadline != "") {
            deadlineDP.Value = DateTime.Parse(selectedFestival.Deadline);
            deadlineNull.Checked = false;
         }
         else {
            deadlineNull.Checked = true;
         }

         if (selectedFestival.Start != "") {
            startDP.Value = DateTime.Parse(selectedFestival.Start);
            startNull.Checked = false;
         }
         else {
            startNull.Checked = true;
         }

      }

      private FestivalRaw readFestivalOf(int id) {
         FestivalRaw festival = null;
         using (MySqlConnection connection = new MySqlConnection(context.ConnectionString)) {
            MySqlCommand command = new MySqlCommand(Query.selectFestival, connection);
            command.Parameters.AddWithValue("@id", id);
            try {
               connection.Open();
               MySqlDataReader reader;
               reader = command.ExecuteReader();

               while (reader.Read()) {
                  string name = reader.GetString(1);
                  int town = (!reader.IsDBNull(2)) ? reader.GetInt32(2) : 0;
                  int link = (!reader.IsDBNull(3)) ? reader.GetInt32(3) : 0;
                  string mail = (!reader.IsDBNull(4)) ? reader.GetString(4) : "";
                  string start = (!reader.IsDBNull(5)) ? reader.GetString(5) : "";
                  string deadline = (!reader.IsDBNull(6)) ? reader.GetString(6) : "";
                  int manager = (!reader.IsDBNull(7)) ? reader.GetInt32(7) : 0;
                  int rank = (!reader.IsDBNull(8)) ? reader.GetInt32(8) : 0;
                  string comment = (!reader.IsDBNull(9)) ? reader.GetString(9) : "";

                  festival = new FestivalRaw(id, name, town, link, mail, start, deadline, manager, rank, comment);
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
         
         return festival;
      }
      
      private bool updateFestival() {
         if (nameTB.Text == "") {
            MessageBox.Show("Name must be filled!");
            return false;
         }

         string name = nameTB.Text;
         int town = ((TownString)townCB.SelectedItem).Id;
         int link = ((LinkString)linkCB.SelectedItem).Id;
         int rank = ((RankString)rankCB.SelectedItem).Id;
         string email = emailTB.Text;
         int manager = ((PersonString)managerCB.SelectedItem).Id;
         string comment = commentTB.Text;
         string deadline = deadlineNull.Checked ? "" : deadlineDP.Value.ToString("yyyy-MM-dd");
         string start = startNull.Checked ? "" : startDP.Value.ToString("yyyy-MM-dd");

         //Update query should be
         using (MySqlConnection connection = new MySqlConnection(context.ConnectionString)) {
            MySqlCommand command = new MySqlCommand(Query.updateFestival, connection);

            Parser.AddWithValue(command, "@id", selectedFestivalId);
            Parser.AddWithValue(command, "@name", name);
            Parser.AddWithValue(command, "@town", town);
            Parser.AddWithValue(command, "@link", link);
            Parser.AddWithValue(command, "@rank", rank);
            Parser.AddWithValue(command, "@email", email);
            Parser.AddWithValue(command, "@manager", manager);
            Parser.AddWithValue(command, "@comment", comment);
            Parser.AddWithValue(command, "@application", deadline);
            Parser.AddWithValue(command, "@start", start);

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

      private void addTown_Click(object sender, EventArgs e) {
         GenericForm.ShowForm<TownString, AddTown, TownGet>(context, towns, townCB);
      }

      private void addLink_Click(object sender, EventArgs e) {
         GenericForm.ShowForm<LinkString, AddLink, LinkGet>(context, links, linkCB);
      }

      private void addPerson_Click(object sender, EventArgs e) {
         GenericForm.ShowForm<PersonString, AddPerson, PersonGet>(context, people, managerCB);
      }

      private void buttonOK_Click(object sender, EventArgs e) {
         if (updateFestival()) {
            Return = 1;
            this.Close();
         }
      }

      private void buttonCANCEL_Click(object sender, EventArgs e) {
         Return = 0;
         this.Close();
      }

      private void deadlineDP_ValueChanged(object sender, EventArgs e) {
         deadlineNull.Checked = false;
      }

      private void startDP_ValueChanged(object sender, EventArgs e) {
         startNull.Checked = false;
      }
   }
}
