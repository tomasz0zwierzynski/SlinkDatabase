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
   public partial class UpdatePerson : Form {
      private MySqlContext context;
      private List<Link> links;
      private List<Occupation> occupations;

      private int selectedPersonId;
      PersonRaw selectedPerson;

      public int Return { get; set; }
      public long LastInsertId { get; set; }

      public UpdatePerson(MySqlContext _context, int _selectedPersonId) {
         InitializeComponent();
         context = _context;
         Return = -1;

         selectedPersonId = _selectedPersonId;
         selectedPerson = readPersonOf(selectedPersonId);

         forenameTB.Text = selectedPerson.Forename;
         surnameTB.Text = selectedPerson.Surname;
         aliasTB.Text = selectedPerson.Alias;
         phoneTB.Text = selectedPerson.Phonenumber;
         emailTB.Text = selectedPerson.Mail;
         commentTB.Text = selectedPerson.Comment;

         links = new List<Link>();
         links.Add(new Link(0, "", "", "")); //A NULL link
         readLinks();
         Link currentLink = null;
         foreach (Link obj in links) {
            linkCB.Items.Add(obj);
            if (obj.Id == selectedPerson.Link) {
               currentLink = obj;
            }
         }
         if (currentLink != null) {
            linkCB.SelectedIndex = linkCB.Items.IndexOf(currentLink);
         }


         occupations = new List<Occupation>();
         occupations.Add(new Occupation(0, "", "")); //A NULL occupy
         readOccupations();
         Occupation currentOccupation1 = null;
         Occupation currentOccupation2 = null;
         foreach (Occupation obj in occupations) {
            occupationCB.Items.Add(obj);
            occupation2CB.Items.Add(obj);
            if (obj.Id == selectedPerson.Occupy1) {
               currentOccupation1 = obj;
            }
            if (obj.Id == selectedPerson.Occupy2) {
               currentOccupation2 = obj;
            }
         }
         if (currentOccupation1 != null) {
            occupationCB.SelectedIndex = occupationCB.Items.IndexOf(currentOccupation1);
         }
         if (currentOccupation2 != null) {
            occupation2CB.SelectedIndex = occupation2CB.Items.IndexOf(currentOccupation2);
         }

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
                  string forename = "";
                  if (!reader.IsDBNull(1)) {
                     forename = reader.GetString(1);
                  }
                  string surname = "";
                  if (!reader.IsDBNull(2)) {
                     surname = reader.GetString(2);
                  }
                  string alias = "";
                  if (!reader.IsDBNull(3)) {
                     alias = reader.GetString(3);
                  }
                  int occupy1 = 0;
                  if (!reader.IsDBNull(4)) {
                     occupy1 = reader.GetInt32(4);
                  }
                  int occupy2 = 0;
                  if (!reader.IsDBNull(5)) {
                     occupy2 = reader.GetInt32(5);
                  }
                  string phonenumber = "";
                  if (!reader.IsDBNull(6)) {
                     phonenumber = reader.GetString(6);
                  }
                  string mail = "";
                  if (!reader.IsDBNull(7)) {
                     mail = reader.GetString(7);
                  }
                  int link = 0;
                  if (!reader.IsDBNull(8)) {
                     link = reader.GetInt32(8);
                  }
                  string comment = "";
                  if (!reader.IsDBNull(9)) {
                     comment = reader.GetString(9);
                  }

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

      private void readOccupations() {
         using (MySqlConnection connection = new MySqlConnection(context.ConnectionString)) {
            MySqlCommand command = new MySqlCommand(Query.selectOccupations, connection);

            try {
               connection.Open();
               MySqlDataReader reader;
               reader = command.ExecuteReader();

               while (reader.Read()) {
                  int id = reader.GetInt32(0);
                  string name = reader.GetString(1);
                  string description = "";
                  if (!reader.IsDBNull(2)) {
                     description = reader.GetString(2);
                  }
                  occupations.Add(new Occupation(id, name, description));
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

      private void readLinks() { //Proper select must be queued -> instead of linkType ID -> linkType name
         using (MySqlConnection connection = new MySqlConnection(context.ConnectionString)) {
            MySqlCommand command = new MySqlCommand(Query.selectLinks, connection);

            try {
               connection.Open();
               MySqlDataReader reader;
               reader = command.ExecuteReader();

               while (reader.Read()) {
                  int id = reader.GetInt32(0);
                  string url = reader.GetString(1);
                  string comment = "";
                  if (!reader.IsDBNull(2)) {
                     comment = reader.GetString(2);
                  }
                  string link_type = reader.GetString(3);
                  links.Add(new Link(id, link_type, url, comment));
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
         int occupy = ((Occupation)occupationCB.SelectedItem).Id;
         int occupy2 = ((Occupation)occupation2CB.SelectedItem).Id;
         string phone = phoneTB.Text;
         string email = emailTB.Text;
         int link = ((Link)linkCB.SelectedItem).Id;
         string comment = commentTB.Text;

         using (MySqlConnection connection = new MySqlConnection(context.ConnectionString)) {
            MySqlCommand command = new MySqlCommand(Query.updatePerson, connection);
            command.Parameters.AddWithValue("@id", selectedPersonId);
            if (forename == "") {
               command.Parameters.AddWithValue("@forename", DBNull.Value);
            }else {
               command.Parameters.AddWithValue("@forename", forename);
            }

            if (surname == "") {
               command.Parameters.AddWithValue("@surname", DBNull.Value);
            }
            else {
               command.Parameters.AddWithValue("@surname", surname);
            }

            if (alias == "") {
               command.Parameters.AddWithValue("@alias", DBNull.Value);
            }
            else {
               command.Parameters.AddWithValue("@alias", alias);
            }

            if (occupy == 0) {
               command.Parameters.AddWithValue("@occupation", DBNull.Value);
            }
            else {
               command.Parameters.AddWithValue("@occupation", occupy);
            }

            if (occupy2 == 0) {
               command.Parameters.AddWithValue("@occupation2", DBNull.Value);
            }
            else {
               command.Parameters.AddWithValue("@occupation2", occupy2);
            }

            if (phone == "") {
               command.Parameters.AddWithValue("@phonenumber", DBNull.Value);
            }
            else {
               command.Parameters.AddWithValue("@phonenumber", phone);
            }

            if (email == "") {
               command.Parameters.AddWithValue("@email", DBNull.Value);
            }
            else {
               command.Parameters.AddWithValue("@email", email);
            }

            if (link == 0) {
               command.Parameters.AddWithValue("@link", DBNull.Value);
            }
            else {
               command.Parameters.AddWithValue("@link", link);
            }

            if (comment == "") {
               command.Parameters.AddWithValue("@comment", DBNull.Value);
            }
            else {
               command.Parameters.AddWithValue("@comment", comment);
            }

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
         AddLink addLinkForm = new AddLink(context);
         addLinkForm.ShowDialog();
         long linkId = addLinkForm.LastInsertId;
         int respond = addLinkForm.Return;
         addLinkForm.Dispose();

         if (respond == 1 || respond == 2) {
            //added
            links.Clear();
            readLinks();
            var LastAddedLink = links.OrderByDescending(item => item.Id).First();
            linkCB.Items.Clear();
            foreach (object obj in links) {
               linkCB.Items.Add(obj);
            }
            linkCB.SelectedItem = LastAddedLink;
         }

      }

   }
}
