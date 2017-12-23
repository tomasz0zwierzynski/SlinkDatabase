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
   public partial class UpdateClub : ContextedForm {

      private List<LinkString> links;
      private List<RankString> ranks;
      private List<TownString> towns;
      private List<PersonString> people;

      private int selectedClubId;
      PubRaw selectedClub;


      public UpdateClub(MySqlContext _context, int _selectedClubId) : base(_context){
         InitializeComponent();

         selectedClubId = _selectedClubId;
         selectedClub = readClubOf(selectedClubId);

         //Put data from query to input boxes views
         nameTB.Text = selectedClub.Name;
         emailTB.Text = selectedClub.Mail;
         commentTB.Text = selectedClub.Comment;
         facebookTB.Text = selectedClub.Facebook;

         try {
            links = LinkGet.Read(context, true);
            ranks = RankGet.Read(context, false);
            towns = TownGet.Read(context, false);
            people = PersonGet.Read(context, true);
         }
         catch (Exception ex) {
            MessageBox.Show("Something went wrong, when opening from database!\n" + ex.Message);
            Return = -2;
            this.Close();
         }

         GenericForm.FillComboBox<LinkString>(linkCB, links, selectedClub.Link);
         GenericForm.FillComboBox<RankString>(rankCB, ranks, selectedClub.Rank);
         GenericForm.FillComboBox<TownString>(townCB, towns, selectedClub.Town);
         GenericForm.FillComboBox<PersonString>(managerCB, people, selectedClub.Manager);
      }

      private PubRaw readClubOf(int id) {
         PubRaw club = null;
         using (MySqlConnection connection = new MySqlConnection(context.ConnectionString)) {
            MySqlCommand command = new MySqlCommand(Query.selectPub, connection);
            command.Parameters.AddWithValue("@id", id);


            try {
               connection.Open();
               MySqlDataReader reader;
               reader = command.ExecuteReader();

               while (reader.Read()) {
                  string name = (!reader.IsDBNull(1)) ? reader.GetString(1) : "";
                  int town = (!reader.IsDBNull(2)) ? reader.GetInt32(2) : 0;
                  int link = (!reader.IsDBNull(3)) ? reader.GetInt32(3) : 0;
                  int rank = (!reader.IsDBNull(4)) ? reader.GetInt32(4) : 0;
                  int manager = (!reader.IsDBNull(5)) ? reader.GetInt32(5) : 0;
                  string mail = (!reader.IsDBNull(6)) ? reader.GetString(6) : "";
                  string facebook = (!reader.IsDBNull(7)) ? reader.GetString(7) : "";
                  string comment = (!reader.IsDBNull(8)) ? reader.GetString(8) : "";

                  club = new PubRaw(id,name,town,rank,manager,mail,link,facebook,comment);
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

         return club;
      }
      
      private bool updateClub() {
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
         string facebook = facebookTB.Text;
         string comment = commentTB.Text;

         using (MySqlConnection connection = new MySqlConnection(context.ConnectionString)) {
            MySqlCommand command = new MySqlCommand(Query.updatePub, connection);
            Parser.AddWithValue<int>(command,"@id", selectedClubId);
            Parser.AddWithValue<string>(command, "@name", name);
            Parser.AddWithValue<int>(command, "@town", town);
            Parser.AddWithValue<int>(command, "@link", link);
            Parser.AddWithValue<int>(command, "@rank", rank);
            Parser.AddWithValue<string>(command, "@email", email);
            Parser.AddWithValue<string>(command, "@facebook", facebook);
            Parser.AddWithValue<int>(command, "@manager", manager);
            Parser.AddWithValue<string>(command, "@comment", comment);

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
         if (updateClub()) {
            Return = 1;
            this.Close();
         }
      }

      private void buttonCANCEL_Click(object sender, EventArgs e) {
         Return = 0;
         this.Close();
      }
   }
}
