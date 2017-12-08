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
   public partial class MainForm : Form {

      private MySqlContext context;

      public MainForm() {
         InitializeComponent();
         context = new MySqlContext();
      }

      private void testConnection_Click(object sender, EventArgs e) {
         if (context.IsConnectionPossible()) {
            MessageBox.Show("Connection is possible.");
         }else {
            label1.Text = context.GetLastError();
         }

      }

      private void addLink_Click(object sender, EventArgs e) {
         AddLink addLinkForm = new AddLink(context);
         addLinkForm.ShowDialog();
         
         while (addLinkForm.Return == 2) {
            addLinkForm.Dispose();
            addLinkForm = new AddLink(context);
            addLinkForm.ShowDialog();
         }

         if (addLinkForm.Return == 0) {
            addLinkForm.Dispose();
            MessageBox.Show("Canceled");
         }else if (addLinkForm.Return == 1) {
            addLinkForm.Dispose();
            MessageBox.Show("Rows saved");
         }else if (addLinkForm.Return == -1) {
            addLinkForm.Dispose();
            MessageBox.Show("Form closed");
         }else if (addLinkForm.Return == -2) {
            addLinkForm.Dispose();
            MessageBox.Show("Form closed");
         }

      }
   }
}
