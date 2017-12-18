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
   
   public partial class ShowPeople : Form {
      
      private MySqlContext context;
      private SortableBindingList<PersonExt> people;

      public int Return { get; set; }
      public long LastInsertId { get; set; }

      public ShowPeople(MySqlContext _context) {
         InitializeComponent();
         context = _context;
         Return = -1;

         people = new SortableBindingList<PersonExt>();
         readPeople();

         var source = new BindingSource(people, null);
         dataGridView1.DataSource = source;
         foreach (DataGridViewColumn column in dataGridView1.Columns) {
            dataGridView1.Columns[column.Name].SortMode = DataGridViewColumnSortMode.Automatic;
            dataGridView1.Columns[column.Name].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
         }
      }

      private void readPeople() { //Proper select must be queued -> instead of linkType ID -> linkType name
         //string commandText = "SELECT 	`people`.`id`, CONCAT( COALESCE(`people`.`forename`, ''),' \"',COALESCE(`people`.`alias`, ''),'\" ',COALESCE(`people`.`surname`, '')) AS `name`,`people`.`phonenumber`, `people`.`e-mail`, `people`.`comment`, `links`.`url` AS `link_name`,`occ1`.`name` AS `occupation 1`,`occ2`.`name` AS `occupation 2`FROM `people`LEFT JOIN `links` ON( `people`.`link` IS NOT NULL AND `people`.`link` = `links`.`id`)LEFT JOIN `occupations` `occ1` ON(`people`.`occupation` IS NOT NULL AND `people`.`occupation` = `occ1`.`id`)LEFT JOIN `occupations` `occ2` ON(`people`.`occupation2` IS NOT NULL AND `people`.`occupation2` = `occ2`.`id`)ORDER BY `name`; ";
         using (MySqlConnection connection = new MySqlConnection(context.ConnectionString)) {
            MySqlCommand command = new MySqlCommand(Query.showPeople, connection);

            try {
               connection.Open();
               MySqlDataReader reader;
               reader = command.ExecuteReader();

               while (reader.Read()) {
                  int id = reader.GetInt32(0);
                  string name = reader.GetString(1);
                  string phonenumber = "";
                  if (!reader.IsDBNull(2)) {
                     phonenumber = reader.GetString(2);
                  }
                  string mail = "";
                  if (!reader.IsDBNull(3)) {
                     mail = reader.GetString(3);
                  }
                  string comment = "";
                  if (!reader.IsDBNull(4)) {
                     comment = reader.GetString(4);
                  }
                  string link = "";
                  if (!reader.IsDBNull(5)) {
                     link = reader.GetString(5);
                  }
                  string occupy1 = "";
                  if (!reader.IsDBNull(6)) {
                     occupy1 = reader.GetString(6);
                  }
                  string occupy2 = "";
                  if (!reader.IsDBNull(7)) {
                     occupy2 = reader.GetString(7);
                  }

                  people.Add(new PersonExt(id, name, phonenumber, mail, comment, link, occupy1,occupy2));
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

      private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
         int correpsondingId = ((PersonExt)dataGridView1.CurrentCell.OwningRow.DataBoundItem).Id;
         UpdatePerson updatePersonForm = new UpdatePerson(context, correpsondingId);
         updatePersonForm.ShowDialog();

         if (updatePersonForm.Return == 1) {
            ShowPeople showPeopleForm = new ShowPeople(context);
            showPeopleForm.Show();
            Dispose();
            Close();
         }
      }
   }
   
}
