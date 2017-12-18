﻿using MySql.Data.MySqlClient;
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
   public partial class AddClub : Form {

      private MySqlContext context;
      private List<Link> links;
      private List<Rank> ranks;
      private List<Town> towns;
      private List<Person> people;

      public int Return { get; set; }
      public long LastInsertId { get; set; }

      public AddClub(MySqlContext _context) {
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

         ranks = new List<Rank>();
         readRanks();
         foreach (object obj in ranks) {
            rankCB.Items.Add(obj);
         }
         rankCB.SelectedIndex = 0;

         towns = new List<Town>();
         readTowns();
         foreach (object obj in towns) {
            townCB.Items.Add(obj);
         }
         townCB.SelectedIndex = 0;

         people = new List<Person>();
         people.Add(new Person(0, "", "", "", "")); //A NULL person
         readPeople();
         foreach (object obj in people) {
            managerCB.Items.Add(obj);
         }
         if (managerCB.Items.Count != 0) {
            managerCB.SelectedIndex = 0;
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

      private bool addClubToDatabase() {
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

         using (MySqlConnection connection = new MySqlConnection(context.ConnectionString)) {
            MySqlCommand command = new MySqlCommand(Query.insertIntoClubs, connection);

            command.Parameters.AddWithValue("@name", name);
            command.Parameters.AddWithValue("@town", town);
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

      private void label3_Click(object sender, EventArgs e) {

      }

      private void label6_Click(object sender, EventArgs e) {

      }

      private void label5_Click(object sender, EventArgs e) {

      }
   }
}