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
            MessageBox.Show("Connection is possible.","Success!",MessageBoxButtons.OK,MessageBoxIcon.Information);     
         }else {
            MessageBox.Show("Connection failed!\n"+context.GetLastError(), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
         }

      }

      private void addLink_Click(object sender, EventArgs e) {
         AddLink addLinkForm = new AddLink(context);
         addLinkForm.ShowDialog();

         int row_counter = 0;
         while (addLinkForm.Return == 2) {
            row_counter++;
            addLinkForm.Dispose();
            addLinkForm = new AddLink(context);
            addLinkForm.ShowDialog();
         }

         int respond = addLinkForm.Return;
         addLinkForm.Dispose();

         if (respond == 0) {
            label1.Text = row_counter.ToString() + " links added.";
         }else if (respond == 1) {
            row_counter++;
            label1.Text = row_counter.ToString() + " links added.";
         }
         else if (respond == -1) {
            label1.Text = row_counter.ToString() + " links added.";
         }
         else if (respond == -2) {
            label1.Text = row_counter.ToString() + " links added.";
         }

      }

      private void addTown_Click(object sender, EventArgs e) {
         AddTown addTownForm = new AddTown(context);
         addTownForm.ShowDialog();

         int row_counter = 0;
         while (addTownForm.Return == 2) {
            row_counter++;
            addTownForm.Dispose();
            addTownForm = new AddTown(context);
            addTownForm.ShowDialog();
         }

         int respond = addTownForm.Return;
         addTownForm.Dispose();

         if (respond == 0) {
            label1.Text = row_counter.ToString() + " towns added.";
         }
         else if (respond == 1) {
            row_counter++;
            label1.Text = row_counter.ToString() + " towns added.";
         }
         else if (respond == -1) {
            label1.Text = row_counter.ToString() + " towns added.";
         }
         else if (respond == -2) {
            label1.Text = row_counter.ToString() + " towns added.";
         }
      }

      private void addPerson_Click(object sender, EventArgs e) {
         AddPerson addPersonForm = new AddPerson(context);
         addPersonForm.ShowDialog();

         int row_counter = 0;
         while (addPersonForm.Return == 2) {
            row_counter++;
            addPersonForm.Dispose();
            addPersonForm = new AddPerson(context);
            addPersonForm.ShowDialog();
         }

         int respond = addPersonForm.Return;
         addPersonForm.Dispose();

         if (respond == 0) {
            label1.Text = row_counter.ToString() + " people added.";
         }
         else if (respond == 1) {
            row_counter++;
            label1.Text = row_counter.ToString() + " people added.";
         }
         else if (respond == -1) {
            label1.Text = row_counter.ToString() + " people added.";
         }
         else if (respond == -2) {
            label1.Text = row_counter.ToString() + " people added.";
         }
      }

      private void addClub_Click(object sender, EventArgs e) {
         AddClub addClubForm = new AddClub(context);
         addClubForm.ShowDialog();

         int row_counter = 0;
         while (addClubForm.Return == 2) {
            row_counter++;
            addClubForm.Dispose();
            addClubForm = new AddClub(context);
            addClubForm.ShowDialog();
         }

         int respond = addClubForm.Return;
         addClubForm.Dispose();

         if (respond == 0) {
            label1.Text = row_counter.ToString() + " clubs added.";
         }
         else if (respond == 1) {
            row_counter++;
            label1.Text = row_counter.ToString() + " clubs added.";
         }
         else if (respond == -1) {
            label1.Text = row_counter.ToString() + " clubs added.";
         }
         else if (respond == -2) {
            label1.Text = row_counter.ToString() + " clubs added.";
         }
      }

      private void addFestival_Click(object sender, EventArgs e) {
         AddFestival addFestivalForm = new AddFestival(context);
         addFestivalForm.ShowDialog();

         int row_counter = 0;
         while (addFestivalForm.Return == 2) {
            row_counter++;
            addFestivalForm.Dispose();
            addFestivalForm = new AddFestival(context);
            addFestivalForm.ShowDialog();
         }

         int respond = addFestivalForm.Return;
         addFestivalForm.Dispose();

         if (respond == 0) {
            label1.Text = row_counter.ToString() + " festivals added.";
         }
         else if (respond == 1) {
            row_counter++;
            label1.Text = row_counter.ToString() + " festivals added.";
         }
         else if (respond == -1) {
            label1.Text = row_counter.ToString() + " festivals added.";
         }
         else if (respond == -2) {
            label1.Text = row_counter.ToString() + " festivals added.";
         }
      }

      private void showLinks_Click(object sender, EventArgs e) {
         ShowLinks showLinksForm = new ShowLinks(context);
         showLinksForm.Show();
      }

      private void showTowns_Click(object sender, EventArgs e) {
         ShowTowns showTownsForm = new ShowTowns(context);
         showTownsForm.Show();
      }

      private void showPubs_Click(object sender, EventArgs e) {
         ShowPubs showPubsForm = new ShowPubs(context);
         showPubsForm.Show();
      }

      private void showPeople_Click(object sender, EventArgs e) {
         ShowPeople showPeopleForm = new ShowPeople(context);
         showPeopleForm.Show();
      }

      private void showFestivals_Click(object sender, EventArgs e) {
         ShowFestivals showFestivalsForm = new ShowFestivals(context);
         showFestivalsForm.Show();
      }

   }
}
