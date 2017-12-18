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
   public partial class UpdateFestival : Form {

      private MySqlContext context;
      private List<Link> links;
      private List<Rank> ranks;
      private List<Town> towns;
      private List<Person> people;

      private int selectedFestivalId;
      FestivalRaw selectedFestival;

      public int Return { get; set; }
      public long LastInsertId { get; set; }

      public UpdateFestival(MySqlContext _context, int _selectedFestivalId) {
         InitializeComponent();
         context = _context;
         Return = -1;

         selectedFestivalId = _selectedFestivalId;
         selectedFestival = readFestivalOf(selectedFestivalId);

         //Put data from query to input boxes views
         nameTB.Text = selectedFestival.Name;
         emailTB.Text = selectedFestival.Mail;
         commentTB.Text = selectedFestival.Comment;

         links = new List<Link>();
         links.Add(new Link(0, "", "", "")); //A NULL link
         readLinks();
         Link currentLink = null;
         foreach (Link obj in links) {
            linkCB.Items.Add(obj);
            if (obj.Id == selectedFestival.Link) {
               currentLink = obj;
            }
         }
         if( currentLink != null) {
            linkCB.SelectedIndex = linkCB.Items.IndexOf(currentLink);
         }
         
                  
         ranks = new List<Rank>();
         readRanks();
         Rank currentRank = null;
         foreach (Rank obj in ranks) {
            rankCB.Items.Add(obj);
            if(obj.Id == selectedFestival.Rank) {
               currentRank = obj;
            }
         }
         rankCB.SelectedIndex = rankCB.Items.IndexOf(currentRank);

         towns = new List<Town>();
         towns.Add(new Town(0, "")); //A NULL TOWN
         readTowns();
         Town currentTown = null;
         foreach (Town obj in towns) {
            townCB.Items.Add(obj);
            if (obj.Id == selectedFestival.Town) {
               currentTown = obj;
            }
         }
         if ( currentTown != null) {
            townCB.SelectedIndex = townCB.Items.IndexOf(currentTown);
         }

         people = new List<Person>();
         people.Add(new Person(0, "", "", "", "")); //A NULL person
         readPeople();
         Person currentPerson = null;
         foreach (Person obj in people) {
            managerCB.Items.Add(obj);
            if (obj.Id == selectedFestival.Manager) {
               currentPerson = obj;
            }
         }
         if (currentPerson != null) {
            managerCB.SelectedIndex = managerCB.Items.IndexOf(currentPerson);
         }

         if (selectedFestival.Deadline != "") {
            deadlineDP.Value = DateTime.Parse(selectedFestival.Deadline);
            deadlineNull.Checked = false;
         }else {
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
                  int town = 0;
                  if (!reader.IsDBNull(2)) {
                     town = reader.GetInt32(2);
                  }
                  int link = 0;
                  if (!reader.IsDBNull(3)) {
                     link = reader.GetInt32(3);
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
                  int manager = 0;
                  if (!reader.IsDBNull(7)) {
                     manager = reader.GetInt32(7);
                  }
                  int rank = 0;
                  if (!reader.IsDBNull(8)) {
                     rank = reader.GetInt32(8);
                  }
                  string comment = "";
                  if (!reader.IsDBNull(9)) {
                     comment = reader.GetString(9);
                  }

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

      private void readRanks() {
         using (MySqlConnection connection = new MySqlConnection(context.ConnectionString)) {
            MySqlCommand command = new MySqlCommand(Query.selectRanks, connection);

            try {
               connection.Open();
               MySqlDataReader reader;
               reader = command.ExecuteReader();

               while (reader.Read()) {
                  int id = reader.GetInt32(0);
                  string rank_name = reader.GetString(1);
                  int rank_value = reader.GetInt32(2);
                  string comment = "";
                  if (!reader.IsDBNull(3)) {
                     comment = reader.GetString(3);
                  }
                  ranks.Add(new Rank(id, rank_name, rank_value, comment));
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

      private void readTowns() {
         using (MySqlConnection connection = new MySqlConnection(context.ConnectionString)) {
            MySqlCommand command = new MySqlCommand(Query.selectTowns, connection);

            try {
               connection.Open();
               MySqlDataReader reader;
               reader = command.ExecuteReader();

               while (reader.Read()) {
                  int id = reader.GetInt32(0);
                  string name = reader.GetString(1);
                  towns.Add(new Town(id, name));
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

      private void readPeople() {
         using (MySqlConnection connection = new MySqlConnection(context.ConnectionString)) {
            MySqlCommand command = new MySqlCommand(Query.selectPeople, connection);

            try {
               connection.Open();
               MySqlDataReader reader;
               reader = command.ExecuteReader();

               while (reader.Read()) {
                  int id = reader.GetInt32(0);
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
                  string comment = "";
                  if (!reader.IsDBNull(4)) {
                     comment = reader.GetString(4);
                  }
                  people.Add(new Person(id, forename, surname, alias, comment));
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

      private bool updateFestival() {
         if (nameTB.Text == "") {
            MessageBox.Show("Name must be filled!");
            return false;
         }

         string name = nameTB.Text;
         int town = ((Town)townCB.SelectedItem).Id;
         int link = ((Link)linkCB.SelectedItem).Id;
         int rank = ((Rank)rankCB.SelectedItem).Id;
         string email = emailTB.Text;
         int manager = ((Person)managerCB.SelectedItem).Id;
         string comment = commentTB.Text;
         string deadline = deadlineDP.Value.ToString("yyyy-MM-dd");
         string start = startDP.Value.ToString("yyyy-MM-dd");

         //Update query should be
         using (MySqlConnection connection = new MySqlConnection(context.ConnectionString)) {
            MySqlCommand command = new MySqlCommand(Query.updateFestival, connection);

            command.Parameters.AddWithValue("@id", selectedFestivalId);
            command.Parameters.AddWithValue("@name", name);
            if (town == 0) {
               command.Parameters.AddWithValue("@town", DBNull.Value);
            }else {
               command.Parameters.AddWithValue("@town", town);
            }
            if (link == 0) {
               command.Parameters.AddWithValue("@link", DBNull.Value);
            }
            else {
               command.Parameters.AddWithValue("@link", link);
            }
            command.Parameters.AddWithValue("@rank", rank);
            if (email == "") {
               command.Parameters.AddWithValue("@email", DBNull.Value);
            }
            else {
               command.Parameters.AddWithValue("@email", email);
            }
            if (manager == 0) {
               command.Parameters.AddWithValue("@manager", DBNull.Value);
            }
            else {
               command.Parameters.AddWithValue("@manager", manager);
            }
            if (comment == "") {
               command.Parameters.AddWithValue("@comment", DBNull.Value);
            }
            else {
               command.Parameters.AddWithValue("@comment", comment);
            }
            if (deadlineNull.Checked) {
               command.Parameters.AddWithValue("@application", DBNull.Value);
            }else {
               command.Parameters.AddWithValue("@application", deadline);
            }
            if (startNull.Checked) {
               command.Parameters.AddWithValue("@start", DBNull.Value);
            }
            else {
               command.Parameters.AddWithValue("@start", start);
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

      private void addTown_Click(object sender, EventArgs e) {
         AddTown addTownForm = new AddTown(context);
         addTownForm.ShowDialog();
         long townId = addTownForm.LastInsertId;
         int respond = addTownForm.Return;
         addTownForm.Dispose();

         if (respond == 1 || respond == 2) {
            //added
            towns.Clear();
            readTowns();
            var LastAddedLink = towns.OrderByDescending(item => item.Id).First();
            townCB.Items.Clear();
            foreach (object obj in towns) {
               townCB.Items.Add(obj);
            }
            townCB.SelectedItem = LastAddedLink;
         }
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

      private void addPerson_Click(object sender, EventArgs e) {
         AddPerson addPersonForm = new AddPerson(context);
         addPersonForm.ShowDialog();
         long personId = addPersonForm.LastInsertId;
         int respond = addPersonForm.Return;
         addPersonForm.Dispose();

         if (respond == 1 || respond == 2) {
            //added
            people.Clear();
            readPeople();
            var LastAddedLink = people.OrderByDescending(item => item.Id).First();
            managerCB.Items.Clear();
            foreach (object obj in people) {
               managerCB.Items.Add(obj);
            }
            managerCB.SelectedItem = LastAddedLink;
         }
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
