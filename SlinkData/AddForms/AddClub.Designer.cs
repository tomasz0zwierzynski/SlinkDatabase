﻿namespace SlinkData {
   public partial class AddClub : ContextedForm {
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddClub));
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
         this.facebookTB = new System.Windows.Forms.TextBox();
         this.label7 = new System.Windows.Forms.Label();
         this.SuspendLayout();
         // 
         // addLink
         // 
         this.addLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
         this.addLink.Location = new System.Drawing.Point(463, 64);
         this.addLink.Name = "addLink";
         this.addLink.Size = new System.Drawing.Size(115, 24);
         this.addLink.TabIndex = 4;
         this.addLink.Text = "Add link...";
         this.addLink.UseVisualStyleBackColor = true;
         this.addLink.Click += new System.EventHandler(this.addLink_Click);
         // 
         // emailTB
         // 
         this.emailTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
         this.emailTB.Location = new System.Drawing.Point(403, 122);
         this.emailTB.MaxLength = 128;
         this.emailTB.Name = "emailTB";
         this.emailTB.Size = new System.Drawing.Size(175, 22);
         this.emailTB.TabIndex = 6;
         // 
         // label9
         // 
         this.label9.AutoSize = true;
         this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
         this.label9.Location = new System.Drawing.Point(348, 125);
         this.label9.Name = "label9";
         this.label9.Size = new System.Drawing.Size(49, 16);
         this.label9.TabIndex = 17;
         this.label9.Text = "E-mail:";
         // 
         // label6
         // 
         this.label6.AutoSize = true;
         this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
         this.label6.Location = new System.Drawing.Point(25, 37);
         this.label6.Name = "label6";
         this.label6.Size = new System.Drawing.Size(44, 16);
         this.label6.TabIndex = 14;
         this.label6.Text = "Town:";
         // 
         // townCB
         // 
         this.townCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.townCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
         this.townCB.FormattingEnabled = true;
         this.townCB.Location = new System.Drawing.Point(75, 34);
         this.townCB.Name = "townCB";
         this.townCB.Size = new System.Drawing.Size(382, 24);
         this.townCB.TabIndex = 1;
         // 
         // nameTB
         // 
         this.nameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
         this.nameTB.Location = new System.Drawing.Point(75, 6);
         this.nameTB.MaxLength = 128;
         this.nameTB.Name = "nameTB";
         this.nameTB.Size = new System.Drawing.Size(503, 22);
         this.nameTB.TabIndex = 0;
         // 
         // label5
         // 
         this.label5.AutoSize = true;
         this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
         this.label5.Location = new System.Drawing.Point(21, 9);
         this.label5.Name = "label5";
         this.label5.Size = new System.Drawing.Size(48, 16);
         this.label5.TabIndex = 13;
         this.label5.Text = "Name:";
         // 
         // buttonCANCEL
         // 
         this.buttonCANCEL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
         this.buttonCANCEL.Location = new System.Drawing.Point(322, 216);
         this.buttonCANCEL.Name = "buttonCANCEL";
         this.buttonCANCEL.Size = new System.Drawing.Size(75, 23);
         this.buttonCANCEL.TabIndex = 12;
         this.buttonCANCEL.Text = "Cancel";
         this.buttonCANCEL.UseVisualStyleBackColor = true;
         this.buttonCANCEL.Click += new System.EventHandler(this.buttonCANCEL_Click);
         // 
         // buttonNEXT
         // 
         this.buttonNEXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
         this.buttonNEXT.Location = new System.Drawing.Point(422, 216);
         this.buttonNEXT.Name = "buttonNEXT";
         this.buttonNEXT.Size = new System.Drawing.Size(75, 23);
         this.buttonNEXT.TabIndex = 10;
         this.buttonNEXT.Text = "Add Next";
         this.buttonNEXT.UseVisualStyleBackColor = true;
         this.buttonNEXT.Click += new System.EventHandler(this.buttonNEXT_Click);
         // 
         // buttonOK
         // 
         this.buttonOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
         this.buttonOK.Location = new System.Drawing.Point(503, 216);
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
         this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
         this.label3.Location = new System.Drawing.Point(34, 68);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(35, 16);
         this.label3.TabIndex = 15;
         this.label3.Text = "Link:";
         // 
         // linkCB
         // 
         this.linkCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.linkCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
         this.linkCB.FormattingEnabled = true;
         this.linkCB.Location = new System.Drawing.Point(75, 64);
         this.linkCB.Name = "linkCB";
         this.linkCB.Size = new System.Drawing.Size(382, 24);
         this.linkCB.TabIndex = 3;
         // 
         // commentTB
         // 
         this.commentTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
         this.commentTB.Location = new System.Drawing.Point(75, 182);
         this.commentTB.MaxLength = 256;
         this.commentTB.Name = "commentTB";
         this.commentTB.Size = new System.Drawing.Size(503, 22);
         this.commentTB.TabIndex = 9;
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
         this.label2.Location = new System.Drawing.Point(1, 185);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(68, 16);
         this.label2.TabIndex = 19;
         this.label2.Text = "Comment:";
         // 
         // addTown
         // 
         this.addTown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
         this.addTown.Location = new System.Drawing.Point(463, 34);
         this.addTown.Name = "addTown";
         this.addTown.Size = new System.Drawing.Size(115, 25);
         this.addTown.TabIndex = 2;
         this.addTown.Text = "Add town...";
         this.addTown.UseVisualStyleBackColor = true;
         this.addTown.Click += new System.EventHandler(this.addTown_Click);
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
         this.label1.Location = new System.Drawing.Point(26, 125);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(43, 16);
         this.label1.TabIndex = 16;
         this.label1.Text = "Rank:";
         // 
         // rankCB
         // 
         this.rankCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.rankCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
         this.rankCB.FormattingEnabled = true;
         this.rankCB.Location = new System.Drawing.Point(75, 122);
         this.rankCB.Name = "rankCB";
         this.rankCB.Size = new System.Drawing.Size(267, 24);
         this.rankCB.TabIndex = 5;
         // 
         // addPerson
         // 
         this.addPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
         this.addPerson.Location = new System.Drawing.Point(463, 151);
         this.addPerson.Name = "addPerson";
         this.addPerson.Size = new System.Drawing.Size(115, 24);
         this.addPerson.TabIndex = 8;
         this.addPerson.Text = "Add person...";
         this.addPerson.UseVisualStyleBackColor = true;
         this.addPerson.Click += new System.EventHandler(this.addPerson_Click);
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
         this.label4.Location = new System.Drawing.Point(4, 155);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(65, 16);
         this.label4.TabIndex = 18;
         this.label4.Text = "Manager:";
         // 
         // managerCB
         // 
         this.managerCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.managerCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
         this.managerCB.FormattingEnabled = true;
         this.managerCB.Location = new System.Drawing.Point(75, 152);
         this.managerCB.Name = "managerCB";
         this.managerCB.Size = new System.Drawing.Size(382, 24);
         this.managerCB.TabIndex = 7;
         // 
         // facebookTB
         // 
         this.facebookTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
         this.facebookTB.Location = new System.Drawing.Point(75, 94);
         this.facebookTB.MaxLength = 128;
         this.facebookTB.Name = "facebookTB";
         this.facebookTB.Size = new System.Drawing.Size(503, 22);
         this.facebookTB.TabIndex = 20;
         // 
         // label7
         // 
         this.label7.AutoSize = true;
         this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
         this.label7.Location = new System.Drawing.Point(1, 97);
         this.label7.Name = "label7";
         this.label7.Size = new System.Drawing.Size(73, 16);
         this.label7.TabIndex = 21;
         this.label7.Text = "Facebook:";
         // 
         // AddClub
         // 
         this.AcceptButton = this.buttonNEXT;
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(590, 242);
         this.Controls.Add(this.facebookTB);
         this.Controls.Add(this.label7);
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
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
         this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
         this.MaximizeBox = false;
         this.Name = "AddClub";
         this.Text = "Add Club / Pub";
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
      private System.Windows.Forms.TextBox facebookTB;
      private System.Windows.Forms.Label label7;
   }
}