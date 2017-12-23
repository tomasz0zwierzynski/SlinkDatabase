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
   public partial class UpdatePerson : ContextedForm {

      private List<LinkString> links;
      private List<OccupationString> occupations;

      private int selectedPersonId;
      PersonRaw selectedPerson;


      public UpdatePerson(MySqlContext _context, int _selectedPersonId) : base(_context) {
         InitializeComponent();

         selectedPersonId = _selectedPersonId;
         selectedPerson = readPersonOf(selectedPersonId);

         forenameTB.Text = selectedPerson.Forename;
         surnameTB.Text = selectedPerson.Surname;
         aliasTB.Text = selectedPerson.Alias;
         phoneTB.Text = selectedPerson.Phonenumber;
         emailTB.Text = selectedPerson.Mail;
         commentTB.Text = selectedPerson.Comment;

         try {
            links = LinkGet.Read(context, true);
            occupations = OccupationGet.Read(context, true);
         }
         catch (Exception ex) {
            MessageBox.Show("Something went wrong, when opening from database!\n" + ex.Message);
            Return = -2;
            this.Close();
         }
         GenericForm.FillComboBox(linkCB, links, selectedPerson.Link);
         GenericForm.FillComboBox(occupationCB, occupations, selectedPerson.Occupy1);
         GenericForm.FillComboBox(occupation2CB, occupations, selectedPerson.Occupy2);

      }

      private PersonRaw readPersonOf(int id) {
         PersonRaw person = null;
         using (MySqlConnection connection = new MySqlConnection(context.ConnectionString)) {
            MySqlCommand command = new MySqlCommand(Query.selectPerson, connection);
            command.Parameters.AddWithValue("@id", id);
            try {
               connection.Open();
               MySqlDataReader reader;
               reader = command.ExecuteReader();

               while (reader.Read()) {
                  string forename = (!reader.IsDBNull(1)) ? reader.GetString(1) : "";
                  string surname = (!reader.IsDBNull(2)) ? reader.GetString(2) : "";
                  string alias = (!reader.IsDBNull(3)) ? reader.GetString(3) : "";
                  int occupy1 = (!reader.IsDBNull(4)) ? reader.GetInt32(4) : 0;
                  int occupy2 = (!reader.IsDBNull(5)) ? reader.GetInt32(5) : 0;
                  string phonenumber = (!reader.IsDBNull(6)) ? reader.GetString(6) : "";
                  string mail = (!reader.IsDBNull(7)) ? reader.GetString(7) : "";
                  int link = (!reader.IsDBNull(8)) ? reader.GetInt32(8) : 0;
                  string comment = (!reader.IsDBNull(9)) ? reader.GetString(9) : "";

                  person = new PersonRaw(id,forename,surname,alias,phonenumber,mail,comment,link,occupy1,occupy2);
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

         return person;
      }
            
      private void addLink_FormClosed(object sender, FormClosedEventArgs e) {

      }

      private void buttonOK_Click(object sender, EventArgs e) {
         if (updatePerson()) {
            Return = 1;
            this.Close();
         }
      }

      private bool updatePerson() {
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
            MySqlCommand command = new MySqlCommand(Query.updatePerson, connection);
            Parser.AddWithValue(command, "@id", selectedPersonId);
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

      private void buttonCANCEL_Click(object sender, EventArgs e) {
         Return = 0;
         this.Close();
      }

      private void addLink_Click(object sender, EventArgs e) {
         GenericForm.ShowForm<LinkString, AddLink, LinkGet>(context, links, linkCB);
      }

   }
}
