namespace SlinkData {
   partial class UpdateLink {
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateLink));
         this.label1 = new System.Windows.Forms.Label();
         this.urlTB = new System.Windows.Forms.TextBox();
         this.label2 = new System.Windows.Forms.Label();
         this.commentTB = new System.Windows.Forms.TextBox();
         this.comboBox = new System.Windows.Forms.ComboBox();
         this.label3 = new System.Windows.Forms.Label();
         this.buttonOK = new System.Windows.Forms.Button();
         this.buttonCANCEL = new System.Windows.Forms.Button();
         this.showUrl = new System.Windows.Forms.Button();
         this.SuspendLayout();
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
         this.label1.Location = new System.Drawing.Point(41, 9);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(28, 16);
         this.label1.TabIndex = 7;
         this.label1.Text = "Url:";
         // 
         // urlTB
         // 
         this.urlTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
         this.urlTB.Location = new System.Drawing.Point(75, 6);
         this.urlTB.MaxLength = 256;
         this.urlTB.Name = "urlTB";
         this.urlTB.Size = new System.Drawing.Size(391, 22);
         this.urlTB.TabIndex = 0;
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
         this.label2.Location = new System.Drawing.Point(1, 67);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(68, 16);
         this.label2.TabIndex = 9;
         this.label2.Text = "Comment:";
         // 
         // commentTB
         // 
         this.commentTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
         this.commentTB.Location = new System.Drawing.Point(75, 64);
         this.commentTB.MaxLength = 256;
         this.commentTB.Name = "commentTB";
         this.commentTB.Size = new System.Drawing.Size(512, 22);
         this.commentTB.TabIndex = 3;
         // 
         // comboBox
         // 
         this.comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
         this.comboBox.FormattingEnabled = true;
         this.comboBox.Location = new System.Drawing.Point(75, 34);
         this.comboBox.Name = "comboBox";
         this.comboBox.Size = new System.Drawing.Size(512, 24);
         this.comboBox.TabIndex = 2;
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
         this.label3.Location = new System.Drawing.Point(26, 37);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(43, 16);
         this.label3.TabIndex = 8;
         this.label3.Text = "Type:";
         // 
         // buttonOK
         // 
         this.buttonOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
         this.buttonOK.Location = new System.Drawing.Point(426, 92);
         this.buttonOK.Name = "buttonOK";
         this.buttonOK.Size = new System.Drawing.Size(161, 23);
         this.buttonOK.TabIndex = 5;
         this.buttonOK.Text = "Accept Changes";
         this.buttonOK.UseVisualStyleBackColor = true;
         this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
         // 
         // buttonCANCEL
         // 
         this.buttonCANCEL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
         this.buttonCANCEL.Location = new System.Drawing.Point(330, 92);
         this.buttonCANCEL.Name = "buttonCANCEL";
         this.buttonCANCEL.Size = new System.Drawing.Size(75, 23);
         this.buttonCANCEL.TabIndex = 6;
         this.buttonCANCEL.Text = "Cancel";
         this.buttonCANCEL.UseVisualStyleBackColor = true;
         this.buttonCANCEL.Click += new System.EventHandler(this.buttonCANCEL_Click);
         // 
         // showUrl
         // 
         this.showUrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
         this.showUrl.Location = new System.Drawing.Point(472, 6);
         this.showUrl.Name = "showUrl";
         this.showUrl.Size = new System.Drawing.Size(115, 22);
         this.showUrl.TabIndex = 1;
         this.showUrl.Text = "Preview...";
         this.showUrl.UseVisualStyleBackColor = true;
         this.showUrl.Click += new System.EventHandler(this.showUrl_Click);
         // 
         // UpdateLink
         // 
         this.AcceptButton = this.buttonOK;
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(597, 124);
         this.Controls.Add(this.showUrl);
         this.Controls.Add(this.buttonCANCEL);
         this.Controls.Add(this.buttonOK);
         this.Controls.Add(this.label3);
         this.Controls.Add(this.comboBox);
         this.Controls.Add(this.commentTB);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.urlTB);
         this.Controls.Add(this.label1);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
         this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
         this.MaximizeBox = false;
         this.Name = "UpdateLink";
         this.Text = "Edit Link";
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
      private System.Windows.Forms.Button buttonCANCEL;
      private System.Windows.Forms.Button showUrl;
   }
}