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
   public partial class UpdateLink : ContextedForm {

      private List<LinkTypeString> linkTypes;

      private int selectedLinkId;
      LinkRaw selectedLink;
      

      public UpdateLink(MySqlContext _context, int _selectedLinkId) : base(_context) {
         InitializeComponent();


         selectedLinkId = _selectedLinkId;
         selectedLink = readLinkOf(selectedLinkId);

         urlTB.Text = selectedLink.Url;
         commentTB.Text = selectedLink.Comment;

         try {
            linkTypes = LinkTypeGet.Read(context, false);
         }
         catch (Exception ex) {
            MessageBox.Show("Something went wrong, when opening from database!\n" + ex.Message);
            Return = -2;
            this.Close();
         }

         GenericForm.FillComboBox(comboBox, linkTypes, selectedLink.LinkType);

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
                  string url = (!reader.IsDBNull(2)) ? reader.GetString(2) : "";
                  string comment = (!reader.IsDBNull(3)) ? reader.GetString(3) : "";
                  int linkType = (!reader.IsDBNull(1)) ? reader.GetInt32(1) : 0;

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
         int link_type = ((LinkTypeString)comboBox.SelectedItem).Id;
         string comment = commentTB.Text;

         using (MySqlConnection connection = new MySqlConnection(context.ConnectionString)) {
            MySqlCommand command = new MySqlCommand(Query.updateLink, connection);
            Parser.AddWithValue(command, "@id", selectedLinkId);
            Parser.AddWithValue(command, "@link_type", link_type);
            Parser.AddWithValue(command, "@url", url);
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
