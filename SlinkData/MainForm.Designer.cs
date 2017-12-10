namespace SlinkData {
   partial class MainForm {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing) {
         if (disposing && (components != null)) {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent() {
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
         this.testConnection = new System.Windows.Forms.Button();
         this.label1 = new System.Windows.Forms.Label();
         this.addLink = new System.Windows.Forms.Button();
         this.addTown = new System.Windows.Forms.Button();
         this.addClub = new System.Windows.Forms.Button();
         this.addPerson = new System.Windows.Forms.Button();
         this.addFestival = new System.Windows.Forms.Button();
         this.showLinks = new System.Windows.Forms.Button();
         this.showTowns = new System.Windows.Forms.Button();
         this.showPubs = new System.Windows.Forms.Button();
         this.showPeople = new System.Windows.Forms.Button();
         this.showFestivals = new System.Windows.Forms.Button();
         this.pictureBox1 = new System.Windows.Forms.PictureBox();
         this.pictureBox2 = new System.Windows.Forms.PictureBox();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
         this.SuspendLayout();
         // 
         // testConnection
         // 
         this.testConnection.Location = new System.Drawing.Point(15, 184);
         this.testConnection.Name = "testConnection";
         this.testConnection.Size = new System.Drawing.Size(69, 40);
         this.testConnection.TabIndex = 0;
         this.testConnection.Text = "Connection Test";
         this.testConnection.UseVisualStyleBackColor = true;
         this.testConnection.Click += new System.EventHandler(this.testConnection_Click);
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(12, 498);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(35, 13);
         this.label1.TabIndex = 1;
         this.label1.Text = "label1";
         // 
         // addLink
         // 
         this.addLink.Location = new System.Drawing.Point(12, 253);
         this.addLink.Name = "addLink";
         this.addLink.Size = new System.Drawing.Size(85, 40);
         this.addLink.TabIndex = 3;
         this.addLink.Text = "Add Link";
         this.addLink.UseVisualStyleBackColor = true;
         this.addLink.Click += new System.EventHandler(this.addLink_Click);
         // 
         // addTown
         // 
         this.addTown.Location = new System.Drawing.Point(12, 299);
         this.addTown.Name = "addTown";
         this.addTown.Size = new System.Drawing.Size(102, 38);
         this.addTown.TabIndex = 4;
         this.addTown.Text = "Add Town";
         this.addTown.UseVisualStyleBackColor = true;
         this.addTown.Click += new System.EventHandler(this.addTown_Click);
         // 
         // addClub
         // 
         this.addClub.Location = new System.Drawing.Point(12, 343);
         this.addClub.Name = "addClub";
         this.addClub.Size = new System.Drawing.Size(121, 38);
         this.addClub.TabIndex = 5;
         this.addClub.Text = "Add Club/Pub";
         this.addClub.UseVisualStyleBackColor = true;
         this.addClub.Click += new System.EventHandler(this.addClub_Click);
         // 
         // addPerson
         // 
         this.addPerson.Location = new System.Drawing.Point(12, 387);
         this.addPerson.Name = "addPerson";
         this.addPerson.Size = new System.Drawing.Size(141, 38);
         this.addPerson.TabIndex = 6;
         this.addPerson.Text = "Add Person";
         this.addPerson.UseVisualStyleBackColor = true;
         this.addPerson.Click += new System.EventHandler(this.addPerson_Click);
         // 
         // addFestival
         // 
         this.addFestival.Location = new System.Drawing.Point(12, 431);
         this.addFestival.Name = "addFestival";
         this.addFestival.Size = new System.Drawing.Size(159, 38);
         this.addFestival.TabIndex = 7;
         this.addFestival.Text = "Add Festival";
         this.addFestival.UseVisualStyleBackColor = true;
         this.addFestival.Click += new System.EventHandler(this.addFestival_Click);
         // 
         // showLinks
         // 
         this.showLinks.Location = new System.Drawing.Point(274, 184);
         this.showLinks.Name = "showLinks";
         this.showLinks.Size = new System.Drawing.Size(159, 38);
         this.showLinks.TabIndex = 8;
         this.showLinks.Text = "Show Links";
         this.showLinks.UseVisualStyleBackColor = true;
         // 
         // showTowns
         // 
         this.showTowns.Location = new System.Drawing.Point(292, 228);
         this.showTowns.Name = "showTowns";
         this.showTowns.Size = new System.Drawing.Size(141, 38);
         this.showTowns.TabIndex = 9;
         this.showTowns.Text = "Show Towns";
         this.showTowns.UseVisualStyleBackColor = true;
         // 
         // showPubs
         // 
         this.showPubs.Location = new System.Drawing.Point(312, 274);
         this.showPubs.Name = "showPubs";
         this.showPubs.Size = new System.Drawing.Size(121, 36);
         this.showPubs.TabIndex = 10;
         this.showPubs.Text = "Show Clubs/Pubs";
         this.showPubs.UseVisualStyleBackColor = true;
         // 
         // showPeople
         // 
         this.showPeople.Location = new System.Drawing.Point(331, 316);
         this.showPeople.Name = "showPeople";
         this.showPeople.Size = new System.Drawing.Size(102, 38);
         this.showPeople.TabIndex = 11;
         this.showPeople.Text = "Show People";
         this.showPeople.UseVisualStyleBackColor = true;
         // 
         // showFestivals
         // 
         this.showFestivals.Location = new System.Drawing.Point(348, 360);
         this.showFestivals.Name = "showFestivals";
         this.showFestivals.Size = new System.Drawing.Size(85, 38);
         this.showFestivals.TabIndex = 12;
         this.showFestivals.Text = "Show Festivals";
         this.showFestivals.UseVisualStyleBackColor = true;
         // 
         // pictureBox1
         // 
         this.pictureBox1.BackgroundImage = global::SlinkData.Properties.Resources.slinkwood_ribbon;
         this.pictureBox1.Image = global::SlinkData.Properties.Resources.slinkwood_ribbon;
         this.pictureBox1.InitialImage = global::SlinkData.Properties.Resources.slinkwood_ribbon;
         this.pictureBox1.Location = new System.Drawing.Point(-5, -39);
         this.pictureBox1.Name = "pictureBox1";
         this.pictureBox1.Size = new System.Drawing.Size(438, 217);
         this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
         this.pictureBox1.TabIndex = 2;
         this.pictureBox1.TabStop = false;
         // 
         // pictureBox2
         // 
         this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
         this.pictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.InitialImage")));
         this.pictureBox2.Location = new System.Drawing.Point(109, 98);
         this.pictureBox2.Name = "pictureBox2";
         this.pictureBox2.Size = new System.Drawing.Size(117, 63);
         this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
         this.pictureBox2.TabIndex = 13;
         this.pictureBox2.TabStop = false;
         // 
         // MainForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(434, 521);
         this.Controls.Add(this.pictureBox2);
         this.Controls.Add(this.showFestivals);
         this.Controls.Add(this.showPeople);
         this.Controls.Add(this.showPubs);
         this.Controls.Add(this.showTowns);
         this.Controls.Add(this.showLinks);
         this.Controls.Add(this.addFestival);
         this.Controls.Add(this.addPerson);
         this.Controls.Add(this.addClub);
         this.Controls.Add(this.addTown);
         this.Controls.Add(this.addLink);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.testConnection);
         this.Controls.Add(this.pictureBox1);
         this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
         this.MaximizeBox = false;
         this.Name = "MainForm";
         this.Text = "SlinkDB";
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Button testConnection;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.PictureBox pictureBox1;
      private System.Windows.Forms.Button addLink;
      private System.Windows.Forms.Button addTown;
      private System.Windows.Forms.Button addClub;
      private System.Windows.Forms.Button addPerson;
      private System.Windows.Forms.Button addFestival;
      private System.Windows.Forms.Button showLinks;
      private System.Windows.Forms.Button showTowns;
      private System.Windows.Forms.Button showPubs;
      private System.Windows.Forms.Button showPeople;
      private System.Windows.Forms.Button showFestivals;
      private System.Windows.Forms.PictureBox pictureBox2;
   }
}

