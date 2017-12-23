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
   public partial class AddLink : ContextedForm {

      private List<LinkTypeString> linkTypes;


      public AddLink(MySqlContext _context) : base(_context){
         InitializeComponent();

         try {
            linkTypes = LinkTypeGet.Read(context, false);
         }catch (Exception ex){
            MessageBox.Show("Something went wrong, when opening from database!\n" + ex.Message);
            Return = -2;
            this.Close();
         }

         GenericForm.FillComboBox(comboBox, linkTypes, true);
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
         int link_type = ((LinkTypeString)comboBox.SelectedItem).Id;
         string comment = commentTB.Text;

         using (MySqlConnection connection = new MySqlConnection(context.ConnectionString)) {
            MySqlCommand command = new MySqlCommand(Query.insertIntoLinks, connection);

            Parser.AddWithValue(command, "@link_type", link_type);
            Parser.AddWithValue(command, "@url", url);
            Parser.AddWithValue(command, "@comment", comment);

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
