using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SlinkData {
   public partial class AddLink : Form {

      private MySqlContext context;
      private List<LinkType> linkTypes;

      public int Return { get; set; }
      public long LastInsertId { get; set; }

      public AddLink(MySqlContext _context) {
         InitializeComponent();
         context = _context;
         Return = -1;

         linkTypes = new List<LinkType>();
         readLinkTypes();

         foreach(object obj in linkTypes) {
            comboBox.Items.Add(obj);
         }

         comboBox.SelectedIndex = 0;
      }

      private void readLinkTypes() {
         string commandText = "SELECT `id`, `type_name`, `description` FROM `link_types`; ";
         using (MySqlConnection connection = new MySqlConnection(context.ConnectionString)) {
            MySqlCommand command = new MySqlCommand(commandText, connection);

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
                  linkTypes.Add(new LinkType(id, name, description));
               }

               reader.Close();
               connection.Close();
            } catch (Exception ex) {
               MessageBox.Show("Something went wrong, when opening from database!\n" + ex.Message);
               Return = -2;
               this.Close();
            }

         }
      }

      private void addLink_FormClosed(object sender, FormClosedEventArgs e) {
         
      }

      private void buttonOK_Click(object sender, EventArgs e) {
         if (addUrlToDatabase()) {
            Return = 1;
            this.Close();
         }
      }

      private bool addUrlToDatabase() {
         if (urlTB.Text == "") {
            MessageBox.Show("Url cannot be empty");
            return false;
         }

         string url = urlTB.Text;
         int link_type = ((LinkType)comboBox.SelectedItem).Id;
         string comment = commentTB.Text;

         string commandText = "INSERT INTO `links` (`id`, `link_type`, `url`, `comment`) VALUES(NULL, @link_type, @url, @comment) ";
         using (MySqlConnection connection = new MySqlConnection(context.ConnectionString)) {
            MySqlCommand command = new MySqlCommand(commandText, connection);
            command.Parameters.AddWithValue("@link_type", link_type);
            command.Parameters.AddWithValue("@url", url);
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
            }catch (Exception ex) {
               MessageBox.Show("Something went wrong, when saving to database!\n"+ex.Message);
            }

         }

         return true;
      }

      private void buttonNEXT_Click(object sender, EventArgs e) {
         if (addUrlToDatabase()) {
            Return = 2;
            this.Close();
         }
      }

      private void buttonCANCEL_Click(object sender, EventArgs e) {
         Return = 0;
         this.Close();
      }

      private void showUrl_Click(object sender, EventArgs e) {
         if (Uri.IsWellFormedUriString(urlTB.Text, UriKind.Absolute)) {

            ProcessStartInfo sInfo = new ProcessStartInfo(new Uri(urlTB.Text).AbsoluteUri);
            Process.Start(sInfo);
         }else {
            string url = urlTB.Text;
            urlTB.Text = "http://" + url;
         }

      }
   }
}
