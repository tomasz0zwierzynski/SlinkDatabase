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
         this.label1 = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.about = new System.Windows.Forms.Button();
         this.button10 = new System.Windows.Forms.Button();
         this.button5 = new System.Windows.Forms.Button();
         this.button6 = new System.Windows.Forms.Button();
         this.button7 = new System.Windows.Forms.Button();
         this.button8 = new System.Windows.Forms.Button();
         this.button9 = new System.Windows.Forms.Button();
         this.button4 = new System.Windows.Forms.Button();
         this.button3 = new System.Windows.Forms.Button();
         this.button2 = new System.Windows.Forms.Button();
         this.button1 = new System.Windows.Forms.Button();
         this.pictureBox2 = new System.Windows.Forms.PictureBox();
         this.addLink = new System.Windows.Forms.Button();
         this.pictureBox3 = new System.Windows.Forms.PictureBox();
         this.pictureBox1 = new System.Windows.Forms.PictureBox();
         this.CustomQuery = new System.Windows.Forms.Button();
         this.button11 = new System.Windows.Forms.Button();
         this.button12 = new System.Windows.Forms.Button();
         this.button13 = new System.Windows.Forms.Button();
         this.button14 = new System.Windows.Forms.Button();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
         this.SuspendLayout();
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
         this.label1.Location = new System.Drawing.Point(9, 689);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(74, 16);
         this.label1.TabIndex = 12;
         this.label1.Text = "Version 0.3";
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Font = new System.Drawing.Font("Cambria Math", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
         this.label2.Location = new System.Drawing.Point(2, 135);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(71, 73);
         this.label2.TabIndex = 11;
         this.label2.Text = "             ";
         // 
         // about
         // 
         this.about.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
         this.about.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
         this.about.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
         this.about.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
         this.about.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.about.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
         this.about.ForeColor = System.Drawing.Color.Black;
         this.about.Image = global::SlinkData.Properties.Resources.information;
         this.about.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
         this.about.Location = new System.Drawing.Point(6, 651);
         this.about.Name = "about";
         this.about.Size = new System.Drawing.Size(90, 31);
         this.about.TabIndex = 16;
         this.about.Text = "About";
         this.about.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
         this.about.UseVisualStyleBackColor = false;
         this.about.Click += new System.EventHandler(this.about_Click);
         // 
         // button10
         // 
         this.button10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
         this.button10.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
         this.button10.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
         this.button10.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
         this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.button10.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
         this.button10.ForeColor = System.Drawing.Color.Black;
         this.button10.Image = global::SlinkData.Properties.Resources.wifi;
         this.button10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
         this.button10.Location = new System.Drawing.Point(6, 577);
         this.button10.Name = "button10";
         this.button10.Size = new System.Drawing.Size(158, 31);
         this.button10.TabIndex = 10;
         this.button10.Text = "Connection Test";
         this.button10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
         this.button10.UseVisualStyleBackColor = false;
         this.button10.Click += new System.EventHandler(this.testConnection_Click);
         // 
         // button5
         // 
         this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
         this.button5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
         this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
         this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
         this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.button5.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
         this.button5.ForeColor = System.Drawing.Color.Black;
         this.button5.Image = global::SlinkData.Properties.Resources.calendar;
         this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
         this.button5.Location = new System.Drawing.Point(6, 238);
         this.button5.Name = "button5";
         this.button5.Size = new System.Drawing.Size(146, 31);
         this.button5.TabIndex = 7;
         this.button5.Text = "Show Festivals";
         this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
         this.button5.UseVisualStyleBackColor = false;
         this.button5.Click += new System.EventHandler(this.showFestivals_Click);
         // 
         // button6
         // 
         this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
         this.button6.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
         this.button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
         this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
         this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.button6.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
         this.button6.ForeColor = System.Drawing.Color.Black;
         this.button6.Image = global::SlinkData.Properties.Resources.man_user;
         this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
         this.button6.Location = new System.Drawing.Point(6, 312);
         this.button6.Name = "button6";
         this.button6.Size = new System.Drawing.Size(146, 31);
         this.button6.TabIndex = 9;
         this.button6.Text = "Show People";
         this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
         this.button6.UseVisualStyleBackColor = false;
         this.button6.Click += new System.EventHandler(this.showPeople_Click);
         // 
         // button7
         // 
         this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
         this.button7.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
         this.button7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
         this.button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
         this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.button7.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
         this.button7.ForeColor = System.Drawing.Color.Black;
         this.button7.Image = global::SlinkData.Properties.Resources.place;
         this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
         this.button7.Location = new System.Drawing.Point(6, 275);
         this.button7.Name = "button7";
         this.button7.Size = new System.Drawing.Size(146, 31);
         this.button7.TabIndex = 8;
         this.button7.Text = "Show Pubs";
         this.button7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
         this.button7.UseVisualStyleBackColor = false;
         this.button7.Click += new System.EventHandler(this.showPubs_Click);
         // 
         // button8
         // 
         this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
         this.button8.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
         this.button8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
         this.button8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
         this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.button8.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
         this.button8.ForeColor = System.Drawing.Color.Black;
         this.button8.Image = global::SlinkData.Properties.Resources.home;
         this.button8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
         this.button8.Location = new System.Drawing.Point(6, 201);
         this.button8.Name = "button8";
         this.button8.Size = new System.Drawing.Size(146, 31);
         this.button8.TabIndex = 6;
         this.button8.Text = "Show Towns";
         this.button8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
         this.button8.UseVisualStyleBackColor = false;
         this.button8.Click += new System.EventHandler(this.showTowns_Click);
         // 
         // button9
         // 
         this.button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
         this.button9.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
         this.button9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
         this.button9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
         this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.button9.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
         this.button9.ForeColor = System.Drawing.Color.Black;
         this.button9.Image = global::SlinkData.Properties.Resources.link;
         this.button9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
         this.button9.Location = new System.Drawing.Point(6, 164);
         this.button9.Name = "button9";
         this.button9.Size = new System.Drawing.Size(146, 31);
         this.button9.TabIndex = 5;
         this.button9.Text = "Show Links";
         this.button9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
         this.button9.UseVisualStyleBackColor = false;
         this.button9.Click += new System.EventHandler(this.showLinks_Click);
         // 
         // button4
         // 
         this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
         this.button4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
         this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
         this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
         this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.button4.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
         this.button4.ForeColor = System.Drawing.Color.Black;
         this.button4.Image = global::SlinkData.Properties.Resources.add_event;
         this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
         this.button4.Location = new System.Drawing.Point(277, 238);
         this.button4.Name = "button4";
         this.button4.Size = new System.Drawing.Size(146, 31);
         this.button4.TabIndex = 2;
         this.button4.Text = "Add Festival";
         this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         this.button4.UseVisualStyleBackColor = false;
         this.button4.Click += new System.EventHandler(this.addFestival_Click);
         // 
         // button3
         // 
         this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
         this.button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
         this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
         this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
         this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.button3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
         this.button3.ForeColor = System.Drawing.Color.Black;
         this.button3.Image = global::SlinkData.Properties.Resources.new_user;
         this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
         this.button3.Location = new System.Drawing.Point(277, 312);
         this.button3.Name = "button3";
         this.button3.Size = new System.Drawing.Size(146, 31);
         this.button3.TabIndex = 4;
         this.button3.Text = "Add Person";
         this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         this.button3.UseVisualStyleBackColor = false;
         this.button3.Click += new System.EventHandler(this.addPerson_Click);
         // 
         // button2
         // 
         this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
         this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
         this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
         this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
         this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.button2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
         this.button2.ForeColor = System.Drawing.Color.Black;
         this.button2.Image = global::SlinkData.Properties.Resources.add_pointer;
         this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
         this.button2.Location = new System.Drawing.Point(277, 275);
         this.button2.Name = "button2";
         this.button2.Size = new System.Drawing.Size(146, 31);
         this.button2.TabIndex = 3;
         this.button2.Text = "Add Pub";
         this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         this.button2.UseVisualStyleBackColor = false;
         this.button2.Click += new System.EventHandler(this.addClub_Click);
         // 
         // button1
         // 
         this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
         this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
         this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
         this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
         this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.button1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
         this.button1.ForeColor = System.Drawing.Color.Black;
         this.button1.Image = global::SlinkData.Properties.Resources.house;
         this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
         this.button1.Location = new System.Drawing.Point(277, 201);
         this.button1.Name = "button1";
         this.button1.Size = new System.Drawing.Size(146, 31);
         this.button1.TabIndex = 1;
         this.button1.Text = "Add Town";
         this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         this.button1.UseVisualStyleBackColor = false;
         this.button1.Click += new System.EventHandler(this.addTown_Click);
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
         // addLink
         // 
         this.addLink.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
         this.addLink.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
         this.addLink.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
         this.addLink.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
         this.addLink.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.addLink.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
         this.addLink.ForeColor = System.Drawing.Color.Black;
         this.addLink.Image = global::SlinkData.Properties.Resources.link_building_symbol_of_two_chain_links_union_with_a_plus_sign;
         this.addLink.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
         this.addLink.Location = new System.Drawing.Point(277, 164);
         this.addLink.Name = "addLink";
         this.addLink.Size = new System.Drawing.Size(146, 31);
         this.addLink.TabIndex = 0;
         this.addLink.Text = "Add Link";
         this.addLink.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         this.addLink.UseVisualStyleBackColor = false;
         this.addLink.Click += new System.EventHandler(this.addLink_Click);
         // 
         // pictureBox3
         // 
         this.pictureBox3.Image = global::SlinkData.Properties.Resources.carlos3;
         this.pictureBox3.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.InitialImage")));
         this.pictureBox3.Location = new System.Drawing.Point(-5, 167);
         this.pictureBox3.Name = "pictureBox3";
         this.pictureBox3.Size = new System.Drawing.Size(443, 549);
         this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
         this.pictureBox3.TabIndex = 15;
         this.pictureBox3.TabStop = false;
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
         // CustomQuery
         // 
         this.CustomQuery.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
         this.CustomQuery.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
         this.CustomQuery.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
         this.CustomQuery.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
         this.CustomQuery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.CustomQuery.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
         this.CustomQuery.ForeColor = System.Drawing.Color.Black;
         this.CustomQuery.Image = global::SlinkData.Properties.Resources.custom_query;
         this.CustomQuery.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
         this.CustomQuery.Location = new System.Drawing.Point(6, 614);
         this.CustomQuery.Name = "CustomQuery";
         this.CustomQuery.Size = new System.Drawing.Size(144, 31);
         this.CustomQuery.TabIndex = 17;
         this.CustomQuery.Text = "Custom Query";
         this.CustomQuery.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
         this.CustomQuery.UseVisualStyleBackColor = false;
         this.CustomQuery.Click += new System.EventHandler(this.CustomQuery_Click);
         // 
         // button11
         // 
         this.button11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
         this.button11.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
         this.button11.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
         this.button11.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
         this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.button11.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
         this.button11.ForeColor = System.Drawing.Color.Black;
         this.button11.Image = global::SlinkData.Properties.Resources.add_band;
         this.button11.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
         this.button11.Location = new System.Drawing.Point(277, 349);
         this.button11.Name = "button11";
         this.button11.Size = new System.Drawing.Size(146, 31);
         this.button11.TabIndex = 18;
         this.button11.Text = "Add Band";
         this.button11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         this.button11.UseVisualStyleBackColor = false;
         // 
         // button12
         // 
         this.button12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
         this.button12.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
         this.button12.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
         this.button12.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
         this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.button12.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
         this.button12.ForeColor = System.Drawing.Color.Black;
         this.button12.Image = global::SlinkData.Properties.Resources.band;
         this.button12.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
         this.button12.Location = new System.Drawing.Point(6, 349);
         this.button12.Name = "button12";
         this.button12.Size = new System.Drawing.Size(146, 31);
         this.button12.TabIndex = 19;
         this.button12.Text = "Show Bands";
         this.button12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
         this.button12.UseVisualStyleBackColor = false;
         // 
         // button13
         // 
         this.button13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
         this.button13.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
         this.button13.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
         this.button13.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
         this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.button13.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
         this.button13.ForeColor = System.Drawing.Color.Black;
         this.button13.Image = global::SlinkData.Properties.Resources.add_media;
         this.button13.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
         this.button13.Location = new System.Drawing.Point(277, 386);
         this.button13.Name = "button13";
         this.button13.Size = new System.Drawing.Size(146, 31);
         this.button13.TabIndex = 20;
         this.button13.Text = "Add Media";
         this.button13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         this.button13.UseVisualStyleBackColor = false;
         // 
         // button14
         // 
         this.button14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
         this.button14.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
         this.button14.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
         this.button14.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
         this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.button14.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
         this.button14.ForeColor = System.Drawing.Color.Black;
         this.button14.Image = global::SlinkData.Properties.Resources.media;
         this.button14.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
         this.button14.Location = new System.Drawing.Point(6, 386);
         this.button14.Name = "button14";
         this.button14.Size = new System.Drawing.Size(146, 31);
         this.button14.TabIndex = 21;
         this.button14.Text = "Show Media";
         this.button14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
         this.button14.UseVisualStyleBackColor = false;
         // 
         // MainForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(431, 714);
         this.Controls.Add(this.button14);
         this.Controls.Add(this.button13);
         this.Controls.Add(this.button12);
         this.Controls.Add(this.button11);
         this.Controls.Add(this.CustomQuery);
         this.Controls.Add(this.about);
         this.Controls.Add(this.button10);
         this.Controls.Add(this.button5);
         this.Controls.Add(this.button6);
         this.Controls.Add(this.button7);
         this.Controls.Add(this.button8);
         this.Controls.Add(this.button9);
         this.Controls.Add(this.button4);
         this.Controls.Add(this.button3);
         this.Controls.Add(this.button2);
         this.Controls.Add(this.button1);
         this.Controls.Add(this.pictureBox2);
         this.Controls.Add(this.addLink);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.pictureBox3);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.pictureBox1);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
         this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
         this.MaximizeBox = false;
         this.Name = "MainForm";
         this.Text = "SlinkDB";
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.PictureBox pictureBox1;
      private System.Windows.Forms.Button addLink;
      private System.Windows.Forms.PictureBox pictureBox2;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.PictureBox pictureBox3;
      private System.Windows.Forms.Button button1;
      private System.Windows.Forms.Button button2;
      private System.Windows.Forms.Button button3;
      private System.Windows.Forms.Button button4;
      private System.Windows.Forms.Button button5;
      private System.Windows.Forms.Button button6;
      private System.Windows.Forms.Button button7;
      private System.Windows.Forms.Button button8;
      private System.Windows.Forms.Button button9;
      private System.Windows.Forms.Button button10;
      private System.Windows.Forms.Button about;
      private System.Windows.Forms.Button CustomQuery;
      private System.Windows.Forms.Button button11;
      private System.Windows.Forms.Button button12;
      private System.Windows.Forms.Button button13;
      private System.Windows.Forms.Button button14;
   }
}

