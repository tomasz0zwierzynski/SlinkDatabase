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
   public partial class AddPerson : ContextedForm {

   
      private List<LinkString> links;
      private List<OccupationString> occupations;


      public AddPerson(MySqlContext _context) : base(_context) {
         InitializeComponent();

         try {
            links = LinkGet.Read(context, true);
            occupations = OccupationGet.Read(context, true);
         }
         catch (Exception ex) {
            MessageBox.Show("Something went wrong, when opening from database!\n" + ex.Message);
            Return = -2;
            this.Close();
         }
         GenericForm.FillComboBox(linkCB, links, true);
         GenericForm.FillComboBox(occupationCB, occupations, true);
         GenericForm.FillComboBox(occupation2CB, occupations, true);

      }
          
      private void addLink_FormClosed(object sender, FormClosedEventArgs e) {

      }

      private void buttonOK_Click(object sender, EventArgs e) {
         if (addPersonToDatabase()) {
            Return = 1;
            this.Close();
         }
      }

      private bool addPersonToDatabase() {
         if (forenameTB.Text == "" && surnameTB.Text=="" && aliasTB.Text=="") {
            MessageBox.Show("At least one of three name fields should be filled");
            return false;
         }

         string forename = forenameTB.Text;
         string surname = surnameTB.Text;
         string alias = aliasTB.Text;
         int occupy = ((OccupationString)occupationCB.SelectedItem).Id;
         int occupy2 = ((OccupationString)occupation2CB.SelectedItem).Id;
         string phone = phoneTB.Text;
         string email = emailTB.Text;
         int link = ((LinkString)linkCB.SelectedItem).Id;
         string comment = commentTB.Text;

         using (MySqlConnection connection = new MySqlConnection(context.ConnectionString)) {
            MySqlCommand command = new MySqlCommand(Query.insertIntoPeople, connection);
            Parser.AddWithValue(command, "@forename", forename);
            Parser.AddWithValue(command, "@surname", surname);
            Parser.AddWithValue(command, "@alias", alias);
            Parser.AddWithValue(command, "@occupation", occupy);
            Parser.AddWithValue(command, "@occupation2", occupy2);
            Parser.AddWithValue(command, "@phonenumber", phone);
            Parser.AddWithValue(command, "@email", email);
            Parser.AddWithValue(command, "@link", link);
            Parser.AddWithValue(command, "@comment", comment);
           
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

      private void buttonNEXT_Click(object sender, EventArgs e) {
         if (addPersonToDatabase()) {
            Return = 2;
            this.Close();
         }
      }

      private void buttonCANCEL_Click(object sender, EventArgs e) {
         Return = 0;
         this.Close();
      }

      private void addLink_Click(object sender, EventArgs e) {
         GenericForm.ShowForm<LinkString, AddLink, LinkGet>(context, links, linkCB);
      }

   }
}
