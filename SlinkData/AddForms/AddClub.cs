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
   public partial class AddClub : ContextedForm { 
      private List<LinkString> links;
      private List<RankString> ranks;
      private List<TownString> towns;
      private List<PersonString> people;

      public AddClub(MySqlContext _context) :base(_context) {
         InitializeComponent();

         try {
            links = LinkGet.Read(context, true);
            ranks = RankGet.Read(context, false);
            towns = TownGet.Read(context, false);
            people = PersonGet.Read(context, true);
         }catch (Exception ex){
            MessageBox.Show("Something went wrong, when opening from database!\n" + ex.Message);
            Return = -2;
            this.Close();
         }

         GenericForm.FillComboBox<LinkString>(linkCB, links, true);
         GenericForm.FillComboBox<RankString>(rankCB, ranks, true);
         GenericForm.FillComboBox<TownString>(townCB, towns, true);
         GenericForm.FillComboBox<PersonString>(managerCB, people, true);
      }      
      
      private bool addClubToDatabase() {
         if (nameTB.Text == "") {
            MessageBox.Show("Name must be filled!");
            return false;
         }

         string name = nameTB.Text;
         int town = ((TownString)townCB.SelectedItem).Id;
         int link = ((LinkString)linkCB.SelectedItem).Id;
         int rank = ((RankString)rankCB.SelectedItem).Id;
         string email = emailTB.Text;
         string facebook = facebookTB.Text;
         int manager = ((PersonString)managerCB.SelectedItem).Id;
         string comment = commentTB.Text;

         using (MySqlConnection connection = new MySqlConnection(context.ConnectionString)) {
            MySqlCommand command = new MySqlCommand(Query.insertIntoClubs, connection);
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
         if (addClubToDatabase()) {
            Return = 1;
            this.Close();
         }
      }

      private void buttonNEXT_Click(object sender, EventArgs e) {
         if (addClubToDatabase()) {
            Return = 2;
            this.Close();
         }
      }

      private void buttonCANCEL_Click(object sender, EventArgs e) {
         Return = 0;
         this.Close();
      }

   }
}
