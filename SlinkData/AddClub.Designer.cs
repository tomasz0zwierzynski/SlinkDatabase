namespace SlinkData {
   partial class AddClub {
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
         this.addLink = new System.Windows.Forms.Button();
         this.emailTB = new System.Windows.Forms.TextBox();
         this.label9 = new System.Windows.Forms.Label();
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
         this.addTown = new System.Windows.Forms.Button();
         this.label1 = new System.Windows.Forms.Label();
         this.rankCB = new System.Windows.Forms.ComboBox();
         this.addPerson = new System.Windows.Forms.Button();
         this.label4 = new System.Windows.Forms.Label();
         this.managerCB = new System.Windows.Forms.ComboBox();
         this.SuspendLayout();
         // 
         // addLink
         // 
         this.addLink.Location = new System.Drawing.Point(363, 73);
         this.addLink.Name = "addLink";
         this.addLink.Size = new System.Drawing.Size(92, 21);
         this.addLink.TabIndex = 4;
         this.addLink.Text = "Add link...";
         this.addLink.UseVisualStyleBackColor = true;
         this.addLink.Click += new System.EventHandler(this.addLink_Click);
         // 
         // emailTB
         // 
         this.emailTB.Location = new System.Drawing.Point(310, 110);
         this.emailTB.MaxLength = 128;
         this.emailTB.Name = "emailTB";
         this.emailTB.Size = new System.Drawing.Size(145, 20);
         this.emailTB.TabIndex = 6;
         // 
         // label9
         // 
         this.label9.AutoSize = true;
         this.label9.Location = new System.Drawing.Point(255, 109);
         this.label9.Name = "label9";
         this.label9.Size = new System.Drawing.Size(38, 13);
         this.label9.TabIndex = 17;
         this.label9.Text = "E-mail:";
         // 
         // label6
         // 
         this.label6.AutoSize = true;
         this.label6.Location = new System.Drawing.Point(12, 42);
         this.label6.Name = "label6";
         this.label6.Size = new System.Drawing.Size(37, 13);
         this.label6.TabIndex = 14;
         this.label6.Text = "Town:";
         // 
         // townCB
         // 
         this.townCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.townCB.FormattingEnabled = true;
         this.townCB.Location = new System.Drawing.Point(97, 39);
         this.townCB.Name = "townCB";
         this.townCB.Size = new System.Drawing.Size(247, 21);
         this.townCB.TabIndex = 1;
         // 
         // nameTB
         // 
         this.nameTB.Location = new System.Drawing.Point(98, 12);
         this.nameTB.MaxLength = 128;
         this.nameTB.Name = "nameTB";
         this.nameTB.Size = new System.Drawing.Size(358, 20);
         this.nameTB.TabIndex = 0;
         // 
         // label5
         // 
         this.label5.AutoSize = true;
         this.label5.Location = new System.Drawing.Point(12, 12);
         this.label5.Name = "label5";
         this.label5.Size = new System.Drawing.Size(38, 13);
         this.label5.TabIndex = 13;
         this.label5.Text = "Name:";
         // 
         // buttonCANCEL
         // 
         this.buttonCANCEL.Location = new System.Drawing.Point(217, 228);
         this.buttonCANCEL.Name = "buttonCANCEL";
         this.buttonCANCEL.Size = new System.Drawing.Size(75, 23);
         this.buttonCANCEL.TabIndex = 12;
         this.buttonCANCEL.Text = "Cancel";
         this.buttonCANCEL.UseVisualStyleBackColor = true;
         this.buttonCANCEL.Click += new System.EventHandler(this.buttonCANCEL_Click);
         // 
         // buttonNEXT
         // 
         this.buttonNEXT.Location = new System.Drawing.Point(298, 228);
         this.buttonNEXT.Name = "buttonNEXT";
         this.buttonNEXT.Size = new System.Drawing.Size(75, 23);
         this.buttonNEXT.TabIndex = 10;
         this.buttonNEXT.Text = "Add Next";
         this.buttonNEXT.UseVisualStyleBackColor = true;
         this.buttonNEXT.Click += new System.EventHandler(this.buttonNEXT_Click);
         // 
         // buttonOK
         // 
         this.buttonOK.Location = new System.Drawing.Point(379, 228);
         this.buttonOK.Name = "buttonOK";
         this.buttonOK.Size = new System.Drawing.Size(75, 23);
         this.buttonOK.TabIndex = 11;
         this.buttonOK.Text = "Add";
         this.buttonOK.UseVisualStyleBackColor = true;
         this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Location = new System.Drawing.Point(15, 73);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(30, 13);
         this.label3.TabIndex = 15;
         this.label3.Text = "Link:";
         // 
         // linkCB
         // 
         this.linkCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.linkCB.FormattingEnabled = true;
         this.linkCB.Location = new System.Drawing.Point(97, 73);
         this.linkCB.Name = "linkCB";
         this.linkCB.Size = new System.Drawing.Size(247, 21);
         this.linkCB.TabIndex = 3;
         // 
         // commentTB
         // 
         this.commentTB.Location = new System.Drawing.Point(97, 180);
         this.commentTB.MaxLength = 256;
         this.commentTB.Name = "commentTB";
         this.commentTB.Size = new System.Drawing.Size(357, 20);
         this.commentTB.TabIndex = 9;
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(15, 183);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(54, 13);
         this.label2.TabIndex = 19;
         this.label2.Text = "Comment:";
         // 
         // addTown
         // 
         this.addTown.Location = new System.Drawing.Point(363, 39);
         this.addTown.Name = "addTown";
         this.addTown.Size = new System.Drawing.Size(92, 21);
         this.addTown.TabIndex = 2;
         this.addTown.Text = "Add town...";
         this.addTown.UseVisualStyleBackColor = true;
         this.addTown.Click += new System.EventHandler(this.addTown_Click);
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(15, 109);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(36, 13);
         this.label1.TabIndex = 16;
         this.label1.Text = "Rank:";
         // 
         // rankCB
         // 
         this.rankCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.rankCB.FormattingEnabled = true;
         this.rankCB.Location = new System.Drawing.Point(97, 109);
         this.rankCB.Name = "rankCB";
         this.rankCB.Size = new System.Drawing.Size(125, 21);
         this.rankCB.TabIndex = 5;
         // 
         // addPerson
         // 
         this.addPerson.Location = new System.Drawing.Point(364, 145);
         this.addPerson.Name = "addPerson";
         this.addPerson.Size = new System.Drawing.Size(92, 21);
         this.addPerson.TabIndex = 8;
         this.addPerson.Text = "Add person...";
         this.addPerson.UseVisualStyleBackColor = true;
         this.addPerson.Click += new System.EventHandler(this.addPerson_Click);
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.Location = new System.Drawing.Point(16, 145);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(52, 13);
         this.label4.TabIndex = 18;
         this.label4.Text = "Manager:";
         // 
         // managerCB
         // 
         this.managerCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.managerCB.FormattingEnabled = true;
         this.managerCB.Location = new System.Drawing.Point(98, 145);
         this.managerCB.Name = "managerCB";
         this.managerCB.Size = new System.Drawing.Size(247, 21);
         this.managerCB.TabIndex = 7;
         // 
         // AddClub
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(473, 266);
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
         this.Name = "AddClub";
         this.Text = "AddClub";
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Button addLink;
      private System.Windows.Forms.TextBox emailTB;
      private System.Windows.Forms.Label label9;
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
      private System.Windows.Forms.Button addTown;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.ComboBox rankCB;
      private System.Windows.Forms.Button addPerson;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.ComboBox managerCB;
   }
}