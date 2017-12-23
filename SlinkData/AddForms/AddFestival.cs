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
   public partial class AddFestival : ContextedForm {
      private List<LinkString> links;
      private List<RankString> ranks;
      private List<TownString> towns;
      private List<PersonString> people;


      public AddFestival(MySqlContext _context) : base(_context) {
         InitializeComponent();

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

         GenericForm.FillComboBox(linkCB, links, true);
         GenericForm.FillComboBox(rankCB, ranks, true);
         GenericForm.FillComboBox(townCB, towns, true);
         GenericForm.FillComboBox(managerCB, people, true);
      }

      private bool addFestivalToDatabase() {
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

         using (MySqlConnection connection = new MySqlConnection(context.ConnectionString)) {
            MySqlCommand command = new MySqlCommand(Query.insertIntoFestivals, connection);

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
         if (addFestivalToDatabase()) {
            Return = 1;
            this.Close();
         }
      }

      private void buttonNEXT_Click(object sender, EventArgs e) {
         if (addFestivalToDatabase()) {
            Return = 2;
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
