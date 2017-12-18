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
   public partial class AddPerson : Form {
      private MySqlContext context;
      private List<Link> links;
      private List<Occupation> occupations;

      public int Return { get; set; }
      public long LastInsertId { get; set; }

      public AddPerson(MySqlContext _context) {
         InitializeComponent();
         context = _context;
         Return = -1;

         links = new List<Link>();
         links.Add(new Link(0, "", "", "")); //A NULL link
         readLinks();
         foreach (object obj in links) {
            linkCB.Items.Add(obj);
         }
         linkCB.SelectedIndex = 0;

         
         occupations = new List<Occupation>();
         occupations.Add(new Occupation(0, "", "")); //A NULL occupy
         readOccupations();
         foreach (object obj in occupations) {
            occupationCB.Items.Add(obj);
            occupation2CB.Items.Add(obj);
         }
         occupationCB.SelectedIndex = 0;
         occupation2CB.SelectedIndex = 0;
         
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
         int occupy = ((Occupation)occupationCB.SelectedItem).Id;
         int occupy2 = ((Occupation)occupation2CB.SelectedItem).Id;
         string phone = phoneTB.Text;
         string email = emailTB.Text;
         int link = ((Link)linkCB.SelectedItem).Id;
         string comment = commentTB.Text;

         using (MySqlConnection connection = new MySqlConnection(context.ConnectionString)) {
            MySqlCommand command = new MySqlCommand(Query.insertIntoPeople, connection);
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
