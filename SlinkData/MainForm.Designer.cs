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
         this.testConnection = new System.Windows.Forms.Button();
         this.label1 = new System.Windows.Forms.Label();
         this.pictureBox1 = new System.Windows.Forms.PictureBox();
         this.addLink = new System.Windows.Forms.Button();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
         this.SuspendLayout();
         // 
         // testConnection
         // 
         this.testConnection.Location = new System.Drawing.Point(12, 97);
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
         this.label1.Location = new System.Drawing.Point(87, 97);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(35, 13);
         this.label1.TabIndex = 1;
         this.label1.Text = "label1";
         // 
         // pictureBox1
         // 
         this.pictureBox1.Image = global::SlinkData.Properties.Resources.slinkwood_ribbon;
         this.pictureBox1.InitialImage = global::SlinkData.Properties.Resources.slinkwood_ribbon;
         this.pictureBox1.Location = new System.Drawing.Point(12, 12);
         this.pictureBox1.Name = "pictureBox1";
         this.pictureBox1.Size = new System.Drawing.Size(408, 79);
         this.pictureBox1.TabIndex = 2;
         this.pictureBox1.TabStop = false;
         // 
         // addLink
         // 
         this.addLink.Location = new System.Drawing.Point(12, 143);
         this.addLink.Name = "addLink";
         this.addLink.Size = new System.Drawing.Size(67, 40);
         this.addLink.TabIndex = 3;
         this.addLink.Text = "Add link";
         this.addLink.UseVisualStyleBackColor = true;
         this.addLink.Click += new System.EventHandler(this.addLink_Click);
         // 
         // MainForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(432, 520);
         this.Controls.Add(this.addLink);
         this.Controls.Add(this.pictureBox1);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.testConnection);
         this.Name = "MainForm";
         this.Text = "SlinkDB";
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Button testConnection;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.PictureBox pictureBox1;
      private System.Windows.Forms.Button addLink;
   }
}

