namespace SlinkData {
   partial class AddLink {
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
         this.label1 = new System.Windows.Forms.Label();
         this.urlTB = new System.Windows.Forms.TextBox();
         this.label2 = new System.Windows.Forms.Label();
         this.commentTB = new System.Windows.Forms.TextBox();
         this.comboBox = new System.Windows.Forms.ComboBox();
         this.label3 = new System.Windows.Forms.Label();
         this.buttonOK = new System.Windows.Forms.Button();
         this.buttonNEXT = new System.Windows.Forms.Button();
         this.buttonCANCEL = new System.Windows.Forms.Button();
         this.SuspendLayout();
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(12, 9);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(23, 13);
         this.label1.TabIndex = 6;
         this.label1.Text = "Url:";
         // 
         // urlTB
         // 
         this.urlTB.Location = new System.Drawing.Point(97, 9);
         this.urlTB.MaxLength = 256;
         this.urlTB.Name = "urlTB";
         this.urlTB.Size = new System.Drawing.Size(359, 20);
         this.urlTB.TabIndex = 0;
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(12, 47);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(54, 13);
         this.label2.TabIndex = 7;
         this.label2.Text = "Comment:";
         // 
         // commentTB
         // 
         this.commentTB.Location = new System.Drawing.Point(97, 47);
         this.commentTB.MaxLength = 256;
         this.commentTB.Name = "commentTB";
         this.commentTB.Size = new System.Drawing.Size(359, 20);
         this.commentTB.TabIndex = 1;
         // 
         // comboBox
         // 
         this.comboBox.FormattingEnabled = true;
         this.comboBox.Location = new System.Drawing.Point(97, 87);
         this.comboBox.Name = "comboBox";
         this.comboBox.Size = new System.Drawing.Size(359, 21);
         this.comboBox.TabIndex = 2;
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Location = new System.Drawing.Point(12, 87);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(34, 13);
         this.label3.TabIndex = 8;
         this.label3.Text = "Type:";
         // 
         // buttonOK
         // 
         this.buttonOK.Location = new System.Drawing.Point(380, 226);
         this.buttonOK.Name = "buttonOK";
         this.buttonOK.Size = new System.Drawing.Size(75, 23);
         this.buttonOK.TabIndex = 4;
         this.buttonOK.Text = "Add";
         this.buttonOK.UseVisualStyleBackColor = true;
         this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
         // 
         // buttonNEXT
         // 
         this.buttonNEXT.Location = new System.Drawing.Point(299, 226);
         this.buttonNEXT.Name = "buttonNEXT";
         this.buttonNEXT.Size = new System.Drawing.Size(75, 23);
         this.buttonNEXT.TabIndex = 3;
         this.buttonNEXT.Text = "Add Next";
         this.buttonNEXT.UseVisualStyleBackColor = true;
         this.buttonNEXT.Click += new System.EventHandler(this.buttonNEXT_Click);
         // 
         // buttonCANCEL
         // 
         this.buttonCANCEL.Location = new System.Drawing.Point(218, 226);
         this.buttonCANCEL.Name = "buttonCANCEL";
         this.buttonCANCEL.Size = new System.Drawing.Size(75, 23);
         this.buttonCANCEL.TabIndex = 5;
         this.buttonCANCEL.Text = "Cancel";
         this.buttonCANCEL.UseVisualStyleBackColor = true;
         this.buttonCANCEL.Click += new System.EventHandler(this.buttonCANCEL_Click);
         // 
         // AddLink
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(468, 261);
         this.Controls.Add(this.buttonCANCEL);
         this.Controls.Add(this.buttonNEXT);
         this.Controls.Add(this.buttonOK);
         this.Controls.Add(this.label3);
         this.Controls.Add(this.comboBox);
         this.Controls.Add(this.commentTB);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.urlTB);
         this.Controls.Add(this.label1);
         this.Name = "AddLink";
         this.Text = "addLink";
         this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.addLink_FormClosed);
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.TextBox urlTB;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.TextBox commentTB;
      private System.Windows.Forms.ComboBox comboBox;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.Button buttonOK;
      private System.Windows.Forms.Button buttonNEXT;
      private System.Windows.Forms.Button buttonCANCEL;
   }
}