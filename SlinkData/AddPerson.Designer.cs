namespace SlinkData {
   partial class AddPerson {
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddPerson));
         this.buttonCANCEL = new System.Windows.Forms.Button();
         this.buttonNEXT = new System.Windows.Forms.Button();
         this.buttonOK = new System.Windows.Forms.Button();
         this.label3 = new System.Windows.Forms.Label();
         this.linkCB = new System.Windows.Forms.ComboBox();
         this.commentTB = new System.Windows.Forms.TextBox();
         this.label2 = new System.Windows.Forms.Label();
         this.forenameTB = new System.Windows.Forms.TextBox();
         this.label1 = new System.Windows.Forms.Label();
         this.surnameTB = new System.Windows.Forms.TextBox();
         this.label4 = new System.Windows.Forms.Label();
         this.aliasTB = new System.Windows.Forms.TextBox();
         this.label5 = new System.Windows.Forms.Label();
         this.label6 = new System.Windows.Forms.Label();
         this.occupationCB = new System.Windows.Forms.ComboBox();
         this.label7 = new System.Windows.Forms.Label();
         this.occupation2CB = new System.Windows.Forms.ComboBox();
         this.phoneTB = new System.Windows.Forms.TextBox();
         this.label8 = new System.Windows.Forms.Label();
         this.emailTB = new System.Windows.Forms.TextBox();
         this.label9 = new System.Windows.Forms.Label();
         this.addLink = new System.Windows.Forms.Button();
         this.SuspendLayout();
         // 
         // buttonCANCEL
         // 
         this.buttonCANCEL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
         this.buttonCANCEL.Location = new System.Drawing.Point(327, 176);
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
         this.buttonNEXT.Location = new System.Drawing.Point(429, 176);
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
         this.buttonOK.Location = new System.Drawing.Point(510, 176);
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
         this.label3.Location = new System.Drawing.Point(40, 123);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(35, 16);
         this.label3.TabIndex = 20;
         this.label3.Text = "Link:";
         // 
         // linkCB
         // 
         this.linkCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.linkCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
         this.linkCB.FormattingEnabled = true;
         this.linkCB.Location = new System.Drawing.Point(81, 120);
         this.linkCB.Name = "linkCB";
         this.linkCB.Size = new System.Drawing.Size(383, 24);
         this.linkCB.TabIndex = 7;
         // 
         // commentTB
         // 
         this.commentTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
         this.commentTB.Location = new System.Drawing.Point(81, 148);
         this.commentTB.MaxLength = 256;
         this.commentTB.Name = "commentTB";
         this.commentTB.Size = new System.Drawing.Size(504, 22);
         this.commentTB.TabIndex = 9;
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
         this.label2.Location = new System.Drawing.Point(7, 151);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(68, 16);
         this.label2.TabIndex = 21;
         this.label2.Text = "Comment:";
         // 
         // forenameTB
         // 
         this.forenameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
         this.forenameTB.Location = new System.Drawing.Point(81, 6);
         this.forenameTB.MaxLength = 16;
         this.forenameTB.Name = "forenameTB";
         this.forenameTB.Size = new System.Drawing.Size(132, 22);
         this.forenameTB.TabIndex = 0;
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
         this.label1.Location = new System.Drawing.Point(39, 9);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(36, 16);
         this.label1.TabIndex = 13;
         this.label1.Text = "Imie:";
         // 
         // surnameTB
         // 
         this.surnameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
         this.surnameTB.Location = new System.Drawing.Point(294, 6);
         this.surnameTB.MaxLength = 32;
         this.surnameTB.Name = "surnameTB";
         this.surnameTB.Size = new System.Drawing.Size(291, 22);
         this.surnameTB.TabIndex = 1;
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
         this.label4.Location = new System.Drawing.Point(219, 9);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(69, 16);
         this.label4.TabIndex = 14;
         this.label4.Text = "Nazwisko:";
         // 
         // aliasTB
         // 
         this.aliasTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
         this.aliasTB.Location = new System.Drawing.Point(81, 34);
         this.aliasTB.MaxLength = 64;
         this.aliasTB.Name = "aliasTB";
         this.aliasTB.Size = new System.Drawing.Size(504, 22);
         this.aliasTB.TabIndex = 2;
         // 
         // label5
         // 
         this.label5.AutoSize = true;
         this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
         this.label5.Location = new System.Drawing.Point(34, 37);
         this.label5.Name = "label5";
         this.label5.Size = new System.Drawing.Size(41, 16);
         this.label5.TabIndex = 15;
         this.label5.Text = "Alias:";
         // 
         // label6
         // 
         this.label6.AutoSize = true;
         this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
         this.label6.Location = new System.Drawing.Point(-4, 65);
         this.label6.Name = "label6";
         this.label6.Size = new System.Drawing.Size(79, 16);
         this.label6.TabIndex = 16;
         this.label6.Text = "Occupation:";
         // 
         // occupationCB
         // 
         this.occupationCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.occupationCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
         this.occupationCB.FormattingEnabled = true;
         this.occupationCB.Location = new System.Drawing.Point(81, 62);
         this.occupationCB.Name = "occupationCB";
         this.occupationCB.Size = new System.Drawing.Size(192, 24);
         this.occupationCB.TabIndex = 3;
         // 
         // label7
         // 
         this.label7.AutoSize = true;
         this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
         this.label7.Location = new System.Drawing.Point(279, 68);
         this.label7.Name = "label7";
         this.label7.Size = new System.Drawing.Size(86, 16);
         this.label7.TabIndex = 17;
         this.label7.Text = "Occupation2:";
         // 
         // occupation2CB
         // 
         this.occupation2CB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.occupation2CB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
         this.occupation2CB.FormattingEnabled = true;
         this.occupation2CB.Location = new System.Drawing.Point(371, 62);
         this.occupation2CB.Name = "occupation2CB";
         this.occupation2CB.Size = new System.Drawing.Size(214, 24);
         this.occupation2CB.TabIndex = 4;
         // 
         // phoneTB
         // 
         this.phoneTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
         this.phoneTB.Location = new System.Drawing.Point(81, 92);
         this.phoneTB.MaxLength = 16;
         this.phoneTB.Name = "phoneTB";
         this.phoneTB.Size = new System.Drawing.Size(152, 22);
         this.phoneTB.TabIndex = 5;
         // 
         // label8
         // 
         this.label8.AutoSize = true;
         this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
         this.label8.Location = new System.Drawing.Point(25, 95);
         this.label8.Name = "label8";
         this.label8.Size = new System.Drawing.Size(50, 16);
         this.label8.TabIndex = 18;
         this.label8.Text = "Phone:";
         // 
         // emailTB
         // 
         this.emailTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
         this.emailTB.Location = new System.Drawing.Point(294, 92);
         this.emailTB.MaxLength = 128;
         this.emailTB.Name = "emailTB";
         this.emailTB.Size = new System.Drawing.Size(291, 22);
         this.emailTB.TabIndex = 6;
         // 
         // label9
         // 
         this.label9.AutoSize = true;
         this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
         this.label9.Location = new System.Drawing.Point(239, 95);
         this.label9.Name = "label9";
         this.label9.Size = new System.Drawing.Size(49, 16);
         this.label9.TabIndex = 19;
         this.label9.Text = "E-mail:";
         // 
         // addLink
         // 
         this.addLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
         this.addLink.Location = new System.Drawing.Point(470, 120);
         this.addLink.Name = "addLink";
         this.addLink.Size = new System.Drawing.Size(115, 24);
         this.addLink.TabIndex = 8;
         this.addLink.Text = "Add link...";
         this.addLink.UseVisualStyleBackColor = true;
         this.addLink.Click += new System.EventHandler(this.addLink_Click);
         // 
         // AddPerson
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(593, 204);
         this.Controls.Add(this.addLink);
         this.Controls.Add(this.emailTB);
         this.Controls.Add(this.label9);
         this.Controls.Add(this.phoneTB);
         this.Controls.Add(this.label8);
         this.Controls.Add(this.label7);
         this.Controls.Add(this.occupation2CB);
         this.Controls.Add(this.label6);
         this.Controls.Add(this.occupationCB);
         this.Controls.Add(this.aliasTB);
         this.Controls.Add(this.label5);
         this.Controls.Add(this.surnameTB);
         this.Controls.Add(this.label4);
         this.Controls.Add(this.buttonCANCEL);
         this.Controls.Add(this.buttonNEXT);
         this.Controls.Add(this.buttonOK);
         this.Controls.Add(this.label3);
         this.Controls.Add(this.linkCB);
         this.Controls.Add(this.commentTB);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.forenameTB);
         this.Controls.Add(this.label1);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
         this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
         this.MaximizeBox = false;
         this.Name = "AddPerson";
         this.Text = "Add Important Person";
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Button buttonCANCEL;
      private System.Windows.Forms.Button buttonNEXT;
      private System.Windows.Forms.Button buttonOK;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.ComboBox linkCB;
      private System.Windows.Forms.TextBox commentTB;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.TextBox forenameTB;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.TextBox surnameTB;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.TextBox aliasTB;
      private System.Windows.Forms.Label label5;
      private System.Windows.Forms.Label label6;
      private System.Windows.Forms.ComboBox occupationCB;
      private System.Windows.Forms.Label label7;
      private System.Windows.Forms.ComboBox occupation2CB;
      private System.Windows.Forms.TextBox phoneTB;
      private System.Windows.Forms.Label label8;
      private System.Windows.Forms.TextBox emailTB;
      private System.Windows.Forms.Label label9;
      private System.Windows.Forms.Button addLink;
   }
}