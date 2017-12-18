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
   public partial class UpdateLink : Form {

      private MySqlContext context;
      private List<LinkType> linkTypes;

      private int selectedLinkId;
      LinkRaw selectedLink;

      public int Return { get; set; }
      public long LastInsertId { get; set; }

      public UpdateLink(MySqlContext _context, int _selectedLinkId) {
         InitializeComponent();
         context = _context;
         Return = -1;

         selectedLinkId = _selectedLinkId;
         selectedLink = readLinkOf(selectedLinkId);

         urlTB.Text = selectedLink.Url;
         commentTB.Text = selectedLink.Comment;

         linkTypes = new List<LinkType>();
         readLinkTypes();
         LinkType currentLinkType = null;
         foreach(LinkType obj in linkTypes) {
            comboBox.Items.Add(obj);
            if (obj.Id == selectedLink.LinkType) {
               currentLinkType = obj;
            }
         }
         comboBox.SelectedIndex = comboBox.Items.IndexOf(currentLinkType);

      }

      private LinkRaw readLinkOf(int id) {
         LinkRaw link = null;
         using (MySqlConnection connection = new MySqlConnection(context.ConnectionString)) {
            MySqlCommand command = new MySqlCommand(Query.selectLink, connection);
            command.Parameters.AddWithValue("@id", id);
            try {
               connection.Open();
               MySqlDataReader reader;
               reader = command.ExecuteReader();

               while (reader.Read()) {
                  int linkType = reader.GetInt32(1);
                  string url = reader.GetString(2);
                  string comment = "";
                  if (!reader.IsDBNull(3)) {
                     comment = reader.GetString(3);
                  }

                  link = new LinkRaw(id, linkType, url, comment);
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

         return link;
      }


      private void readLinkTypes() {
         using (MySqlConnection connection = new MySqlConnection(context.ConnectionString)) {
            MySqlCommand command = new MySqlCommand(Query.selectLinkTypes, connection);

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
         if (updateUrl()) {
            Return = 1;
            this.Close();
         }
      }

      private bool updateUrl() {
         if (urlTB.Text == "") {
            MessageBox.Show("Url cannot be empty");
            return false;
         }

         string url = urlTB.Text;
         int link_type = ((LinkType)comboBox.SelectedItem).Id;
         string comment = commentTB.Text;

         using (MySqlConnection connection = new MySqlConnection(context.ConnectionString)) {
            MySqlCommand command = new MySqlCommand(Query.updateLink, connection);
            command.Parameters.AddWithValue("@id", selectedLinkId);
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
