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

         int respond = addLinkForm.Return;
         addLinkForm.Dispose();

         if (respond == 0) {
            MessageBox.Show("Canceled");
         }else if (respond == 1) {
            MessageBox.Show("Rows saved");
         }else if (respond == -1) {
            MessageBox.Show("Form closed");
         }else if (respond == -2) {
            MessageBox.Show("Form closed");
         }

      }

      private void addTown_Click(object sender, EventArgs e) {
         AddTown addTownForm = new AddTown(context);
         addTownForm.ShowDialog();

         while (addTownForm.Return == 2) {
            addTownForm.Dispose();
            addTownForm = new AddTown(context);
            addTownForm.ShowDialog();
         }

         int respond = addTownForm.Return;
         addTownForm.Dispose();

         if (respond == 0) {
            MessageBox.Show("Canceled");
         }
         else if (respond == 1) {
            MessageBox.Show("Rows saved");
         }
         else if (respond == -1) {
            MessageBox.Show("Form closed");
         }
         else if (respond == -2) {
            MessageBox.Show("Form closed");
         }
      }

      private void addPerson_Click(object sender, EventArgs e) {
         AddPerson addPersonForm = new AddPerson(context);
         addPersonForm.ShowDialog();

         while (addPersonForm.Return == 2) {
            addPersonForm.Dispose();
            addPersonForm = new AddPerson(context);
            addPersonForm.ShowDialog();
         }

         int respond = addPersonForm.Return;
         addPersonForm.Dispose();

         if (respond == 0) {
            MessageBox.Show("Canceled");
         }
         else if (respond == 1) {
            MessageBox.Show("Rows saved");
         }
         else if (respond == -1) {
            MessageBox.Show("Form closed");
         }
         else if (respond == -2) {
            MessageBox.Show("Form closed");
         }
      }

      private void addClub_Click(object sender, EventArgs e) {
         AddClub addClubForm = new AddClub(context);
         addClubForm.ShowDialog();

         while (addClubForm.Return == 2) {
            addClubForm.Dispose();
            addClubForm = new AddClub(context);
            addClubForm.ShowDialog();
         }

         int respond = addClubForm.Return;
         addClubForm.Dispose();

         if (respond == 0) {
            MessageBox.Show("Canceled");
         }
         else if (respond == 1) {
            MessageBox.Show("Rows saved");
         }
         else if (respond == -1) {
            MessageBox.Show("Form closed");
         }
         else if (respond == -2) {
            MessageBox.Show("Form closed");
         }
      }

      private void addFestival_Click(object sender, EventArgs e) {
         AddFestival addFestivalForm = new AddFestival(context);
         addFestivalForm.ShowDialog();

         while (addFestivalForm.Return == 2) {
            addFestivalForm.Dispose();
            addFestivalForm = new AddFestival(context);
            addFestivalForm.ShowDialog();
         }

         int respond = addFestivalForm.Return;
         addFestivalForm.Dispose();

         if (respond == 0) {
            MessageBox.Show("Canceled");
         }
         else if (respond == 1) {
            MessageBox.Show("Rows saved");
         }
         else if (respond == -1) {
            MessageBox.Show("Form closed");
         }
         else if (respond == -2) {
            MessageBox.Show("Form closed");
         }
      }
   }
}
