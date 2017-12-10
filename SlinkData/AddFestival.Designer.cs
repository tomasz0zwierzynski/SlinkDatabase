namespace SlinkData {
   partial class AddFestival {
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
         this.addPerson = new System.Windows.Forms.Button();
         this.label4 = new System.Windows.Forms.Label();
         this.managerCB = new System.Windows.Forms.ComboBox();
         this.label1 = new System.Windows.Forms.Label();
         this.rankCB = new System.Windows.Forms.ComboBox();
         this.addTown = new System.Windows.Forms.Button();
         this.addLink = new System.Windows.Forms.Button();
         this.label6 = new System.Windows.Forms.Label();
         this.townCB = new System.Windows.Forms.ComboBox();
         this.nameTB = new System.Windows.Forms.TextBox();
         this.label5 = new System.Windows.Forms.Label();
         this.buttonCANCEL = new System.Windows.Forms.Button();
         this.buttonNEXT = new System.Windows.Forms.Button();
         this.buttonOK = new System.Windows.Forms.Button();
         this.label3 = new System.Windows.Forms.Label();
         this.linkCB = new System.Windows.Forms.ComboBox();
         this.commentTB = new System.Windows.Forms.TextBox();
         this.label2 = new System.Windows.Forms.Label();
         this.emailTB = new System.Windows.Forms.TextBox();
         this.label9 = new System.Windows.Forms.Label();
         this.deadlineDP = new System.Windows.Forms.DateTimePicker();
         this.label7 = new System.Windows.Forms.Label();
         this.label8 = new System.Windows.Forms.Label();
         this.startDP = new System.Windows.Forms.DateTimePicker();
         this.deadlineNull = new System.Windows.Forms.CheckBox();
         this.startNull = new System.Windows.Forms.CheckBox();
         this.SuspendLayout();
         // 
         // addPerson
         // 
         this.addPerson.Location = new System.Drawing.Point(375, 144);
         this.addPerson.Name = "addPerson";
         this.addPerson.Size = new System.Drawing.Size(92, 21);
         this.addPerson.TabIndex = 28;
         this.addPerson.Text = "Add person...";
         this.addPerson.UseVisualStyleBackColor = true;
         this.addPerson.Click += new System.EventHandler(this.addPerson_Click);
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.Location = new System.Drawing.Point(27, 144);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(52, 13);
         this.label4.TabIndex = 38;
         this.label4.Text = "Manager:";
         // 
         // managerCB
         // 
         this.managerCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.managerCB.FormattingEnabled = true;
         this.managerCB.Location = new System.Drawing.Point(109, 144);
         this.managerCB.Name = "managerCB";
         this.managerCB.Size = new System.Drawing.Size(247, 21);
         this.managerCB.TabIndex = 27;
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(26, 108);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(36, 13);
         this.label1.TabIndex = 36;
         this.label1.Text = "Rank:";
         // 
         // rankCB
         // 
         this.rankCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.rankCB.FormattingEnabled = true;
         this.rankCB.Location = new System.Drawing.Point(108, 108);
         this.rankCB.Name = "rankCB";
         this.rankCB.Size = new System.Drawing.Size(125, 21);
         this.rankCB.TabIndex = 25;
         // 
         // addTown
         // 
         this.addTown.Location = new System.Drawing.Point(374, 38);
         this.addTown.Name = "addTown";
         this.addTown.Size = new System.Drawing.Size(92, 21);
         this.addTown.TabIndex = 22;
         this.addTown.Text = "Add town...";
         this.addTown.UseVisualStyleBackColor = true;
         this.addTown.Click += new System.EventHandler(this.addTown_Click);
         // 
         // addLink
         // 
         this.addLink.Location = new System.Drawing.Point(374, 72);
         this.addLink.Name = "addLink";
         this.addLink.Size = new System.Drawing.Size(92, 21);
         this.addLink.TabIndex = 24;
         this.addLink.Text = "Add link...";
         this.addLink.UseVisualStyleBackColor = true;
         this.addLink.Click += new System.EventHandler(this.addLink_Click);
         // 
         // label6
         // 
         this.label6.AutoSize = true;
         this.label6.Location = new System.Drawing.Point(23, 41);
         this.label6.Name = "label6";
         this.label6.Size = new System.Drawing.Size(37, 13);
         this.label6.TabIndex = 34;
         this.label6.Text = "Town:";
         // 
         // townCB
         // 
         this.townCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.townCB.FormattingEnabled = true;
         this.townCB.Location = new System.Drawing.Point(108, 38);
         this.townCB.Name = "townCB";
         this.townCB.Size = new System.Drawing.Size(247, 21);
         this.townCB.TabIndex = 21;
         // 
         // nameTB
         // 
         this.nameTB.Location = new System.Drawing.Point(109, 11);
         this.nameTB.MaxLength = 128;
         this.nameTB.Name = "nameTB";
         this.nameTB.Size = new System.Drawing.Size(358, 20);
         this.nameTB.TabIndex = 20;
         // 
         // label5
         // 
         this.label5.AutoSize = true;
         this.label5.Location = new System.Drawing.Point(23, 11);
         this.label5.Name = "label5";
         this.label5.Size = new System.Drawing.Size(38, 13);
         this.label5.TabIndex = 33;
         this.label5.Text = "Name:";
         // 
         // buttonCANCEL
         // 
         this.buttonCANCEL.Location = new System.Drawing.Point(228, 269);
         this.buttonCANCEL.Name = "buttonCANCEL";
         this.buttonCANCEL.Size = new System.Drawing.Size(75, 23);
         this.buttonCANCEL.TabIndex = 32;
         this.buttonCANCEL.Text = "Cancel";
         this.buttonCANCEL.UseVisualStyleBackColor = true;
         this.buttonCANCEL.Click += new System.EventHandler(this.buttonCANCEL_Click);
         // 
         // buttonNEXT
         // 
         this.buttonNEXT.Location = new System.Drawing.Point(309, 269);
         this.buttonNEXT.Name = "buttonNEXT";
         this.buttonNEXT.Size = new System.Drawing.Size(75, 23);
         this.buttonNEXT.TabIndex = 30;
         this.buttonNEXT.Text = "Add Next";
         this.buttonNEXT.UseVisualStyleBackColor = true;
         this.buttonNEXT.Click += new System.EventHandler(this.buttonNEXT_Click);
         // 
         // buttonOK
         // 
         this.buttonOK.Location = new System.Drawing.Point(390, 269);
         this.buttonOK.Name = "buttonOK";
         this.buttonOK.Size = new System.Drawing.Size(75, 23);
         this.buttonOK.TabIndex = 31;
         this.buttonOK.Text = "Add";
         this.buttonOK.UseVisualStyleBackColor = true;
         this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Location = new System.Drawing.Point(26, 72);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(30, 13);
         this.label3.TabIndex = 35;
         this.label3.Text = "Link:";
         // 
         // linkCB
         // 
         this.linkCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.linkCB.FormattingEnabled = true;
         this.linkCB.Location = new System.Drawing.Point(108, 72);
         this.linkCB.Name = "linkCB";
         this.linkCB.Size = new System.Drawing.Size(247, 21);
         this.linkCB.TabIndex = 23;
         // 
         // commentTB
         // 
         this.commentTB.Location = new System.Drawing.Point(108, 243);
         this.commentTB.MaxLength = 256;
         this.commentTB.Name = "commentTB";
         this.commentTB.Size = new System.Drawing.Size(357, 20);
         this.commentTB.TabIndex = 29;
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(26, 246);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(54, 13);
         this.label2.TabIndex = 39;
         this.label2.Text = "Comment:";
         // 
         // emailTB
         // 
         this.emailTB.Location = new System.Drawing.Point(321, 109);
         this.emailTB.MaxLength = 128;
         this.emailTB.Name = "emailTB";
         this.emailTB.Size = new System.Drawing.Size(145, 20);
         this.emailTB.TabIndex = 26;
         // 
         // label9
         // 
         this.label9.AutoSize = true;
         this.label9.Location = new System.Drawing.Point(266, 108);
         this.label9.Name = "label9";
         this.label9.Size = new System.Drawing.Size(38, 13);
         this.label9.TabIndex = 37;
         this.label9.Text = "E-mail:";
         // 
         // deadlineDP
         // 
         this.deadlineDP.Location = new System.Drawing.Point(108, 177);
         this.deadlineDP.Name = "deadlineDP";
         this.deadlineDP.Size = new System.Drawing.Size(200, 20);
         this.deadlineDP.TabIndex = 40;
         this.deadlineDP.ValueChanged += new System.EventHandler(this.deadlineDP_ValueChanged);
         // 
         // label7
         // 
         this.label7.AutoSize = true;
         this.label7.Location = new System.Drawing.Point(26, 214);
         this.label7.Name = "label7";
         this.label7.Size = new System.Drawing.Size(32, 13);
         this.label7.TabIndex = 41;
         this.label7.Text = "Start:";
         // 
         // label8
         // 
         this.label8.AutoSize = true;
         this.label8.Location = new System.Drawing.Point(23, 183);
         this.label8.Name = "label8";
         this.label8.Size = new System.Drawing.Size(52, 13);
         this.label8.TabIndex = 42;
         this.label8.Text = "Deadline:";
         // 
         // startDP
         // 
         this.startDP.Location = new System.Drawing.Point(108, 208);
         this.startDP.Name = "startDP";
         this.startDP.Size = new System.Drawing.Size(200, 20);
         this.startDP.TabIndex = 43;
         this.startDP.ValueChanged += new System.EventHandler(this.startDP_ValueChanged);
         // 
         // deadlineNull
         // 
         this.deadlineNull.AutoSize = true;
         this.deadlineNull.Checked = true;
         this.deadlineNull.CheckState = System.Windows.Forms.CheckState.Checked;
         this.deadlineNull.Location = new System.Drawing.Point(321, 178);
         this.deadlineNull.Name = "deadlineNull";
         this.deadlineNull.Size = new System.Drawing.Size(54, 17);
         this.deadlineNull.TabIndex = 44;
         this.deadlineNull.Text = "NULL";
         this.deadlineNull.UseVisualStyleBackColor = true;
         // 
         // startNull
         // 
         this.startNull.AutoSize = true;
         this.startNull.Checked = true;
         this.startNull.CheckState = System.Windows.Forms.CheckState.Checked;
         this.startNull.Location = new System.Drawing.Point(321, 208);
         this.startNull.Name = "startNull";
         this.startNull.Size = new System.Drawing.Size(54, 17);
         this.startNull.TabIndex = 45;
         this.startNull.Text = "NULL";
         this.startNull.UseVisualStyleBackColor = true;
         // 
         // AddFestival
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(491, 304);
         this.Controls.Add(this.startNull);
         this.Controls.Add(this.deadlineNull);
         this.Controls.Add(this.startDP);
         this.Controls.Add(this.label8);
         this.Controls.Add(this.label7);
         this.Controls.Add(this.deadlineDP);
         this.Controls.Add(this.addPerson);
         this.Controls.Add(this.label4);
         this.Controls.Add(this.managerCB);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.rankCB);
         this.Controls.Add(this.addTown);
         this.Controls.Add(this.addLink);
         this.Controls.Add(this.emailTB);
         this.Controls.Add(this.label9);
         this.Controls.Add(this.label6);
         this.Controls.Add(this.townCB);
         this.Controls.Add(this.nameTB);
         this.Controls.Add(this.label5);
         this.Controls.Add(this.buttonCANCEL);
         this.Controls.Add(this.buttonNEXT);
         this.Controls.Add(this.buttonOK);
         this.Controls.Add(this.label3);
         this.Controls.Add(this.linkCB);
         this.Controls.Add(this.commentTB);
         this.Controls.Add(this.label2);
         this.Name = "AddFestival";
         this.Text = "AddFestival";
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Button addPerson;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.ComboBox managerCB;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.ComboBox rankCB;
      private System.Windows.Forms.Button addTown;
      private System.Windows.Forms.Button addLink;
      private System.Windows.Forms.Label label6;
      private System.Windows.Forms.ComboBox townCB;
      private System.Windows.Forms.TextBox nameTB;
      private System.Windows.Forms.Label label5;
      private System.Windows.Forms.Button buttonCANCEL;
      private System.Windows.Forms.Button buttonNEXT;
      private System.Windows.Forms.Button buttonOK;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.ComboBox linkCB;
      private System.Windows.Forms.TextBox commentTB;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.TextBox emailTB;
      private System.Windows.Forms.Label label9;
      private System.Windows.Forms.DateTimePicker deadlineDP;
      private System.Windows.Forms.Label label7;
      private System.Windows.Forms.Label label8;
      private System.Windows.Forms.DateTimePicker startDP;
      private System.Windows.Forms.CheckBox deadlineNull;
      private System.Windows.Forms.CheckBox startNull;
   }
}