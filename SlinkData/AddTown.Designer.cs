namespace SlinkData {
   partial class AddTown {
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
         this.buttonCANCEL = new System.Windows.Forms.Button();
         this.buttonNEXT = new System.Windows.Forms.Button();
         this.buttonOK = new System.Windows.Forms.Button();
         this.label3 = new System.Windows.Forms.Label();
         this.comboBox = new System.Windows.Forms.ComboBox();
         this.label2 = new System.Windows.Forms.Label();
         this.nameTB = new System.Windows.Forms.TextBox();
         this.label1 = new System.Windows.Forms.Label();
         this.commentTB = new System.Windows.Forms.TextBox();
         this.label4 = new System.Windows.Forms.Label();
         this.distanceTB = new System.Windows.Forms.NumericUpDown();
         this.distMaps = new System.Windows.Forms.Button();
         ((System.ComponentModel.ISupportInitialize)(this.distanceTB)).BeginInit();
         this.SuspendLayout();
         // 
         // buttonCANCEL
         // 
         this.buttonCANCEL.Location = new System.Drawing.Point(216, 227);
         this.buttonCANCEL.Name = "buttonCANCEL";
         this.buttonCANCEL.Size = new System.Drawing.Size(75, 23);
         this.buttonCANCEL.TabIndex = 6;
         this.buttonCANCEL.Text = "Cancel";
         this.buttonCANCEL.UseVisualStyleBackColor = true;
         this.buttonCANCEL.Click += new System.EventHandler(this.buttonCANCEL_Click);
         // 
         // buttonNEXT
         // 
         this.buttonNEXT.Location = new System.Drawing.Point(297, 227);
         this.buttonNEXT.Name = "buttonNEXT";
         this.buttonNEXT.Size = new System.Drawing.Size(75, 23);
         this.buttonNEXT.TabIndex = 4;
         this.buttonNEXT.Text = "Add Next";
         this.buttonNEXT.UseVisualStyleBackColor = true;
         this.buttonNEXT.Click += new System.EventHandler(this.buttonNEXT_Click);
         // 
         // buttonOK
         // 
         this.buttonOK.Location = new System.Drawing.Point(378, 227);
         this.buttonOK.Name = "buttonOK";
         this.buttonOK.Size = new System.Drawing.Size(75, 23);
         this.buttonOK.TabIndex = 5;
         this.buttonOK.Text = "Add";
         this.buttonOK.UseVisualStyleBackColor = true;
         this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Location = new System.Drawing.Point(10, 117);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(30, 13);
         this.label3.TabIndex = 10;
         this.label3.Text = "Size:";
         // 
         // comboBox
         // 
         this.comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.comboBox.FormattingEnabled = true;
         this.comboBox.Location = new System.Drawing.Point(95, 117);
         this.comboBox.Name = "comboBox";
         this.comboBox.Size = new System.Drawing.Size(359, 21);
         this.comboBox.TabIndex = 3;
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(10, 48);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(52, 13);
         this.label2.TabIndex = 8;
         this.label2.Text = "Distance:";
         // 
         // nameTB
         // 
         this.nameTB.Location = new System.Drawing.Point(95, 10);
         this.nameTB.MaxLength = 32;
         this.nameTB.Name = "nameTB";
         this.nameTB.Size = new System.Drawing.Size(359, 20);
         this.nameTB.TabIndex = 0;
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(10, 10);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(38, 13);
         this.label1.TabIndex = 7;
         this.label1.Text = "Name:";
         // 
         // commentTB
         // 
         this.commentTB.Location = new System.Drawing.Point(95, 84);
         this.commentTB.MaxLength = 128;
         this.commentTB.Name = "commentTB";
         this.commentTB.Size = new System.Drawing.Size(359, 20);
         this.commentTB.TabIndex = 2;
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.Location = new System.Drawing.Point(10, 84);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(54, 13);
         this.label4.TabIndex = 9;
         this.label4.Text = "Comment:";
         // 
         // distanceTB
         // 
         this.distanceTB.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
         this.distanceTB.Location = new System.Drawing.Point(95, 48);
         this.distanceTB.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
         this.distanceTB.Name = "distanceTB";
         this.distanceTB.Size = new System.Drawing.Size(223, 20);
         this.distanceTB.TabIndex = 1;
         this.distanceTB.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
         // 
         // distMaps
         // 
         this.distMaps.Location = new System.Drawing.Point(324, 48);
         this.distMaps.Name = "distMaps";
         this.distMaps.Size = new System.Drawing.Size(128, 20);
         this.distMaps.TabIndex = 11;
         this.distMaps.Text = "google maps...";
         this.distMaps.UseVisualStyleBackColor = true;
         this.distMaps.Click += new System.EventHandler(this.distMaps_Click);
         // 
         // AddTown
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(464, 261);
         this.Controls.Add(this.distMaps);
         this.Controls.Add(this.distanceTB);
         this.Controls.Add(this.commentTB);
         this.Controls.Add(this.label4);
         this.Controls.Add(this.buttonCANCEL);
         this.Controls.Add(this.buttonNEXT);
         this.Controls.Add(this.buttonOK);
         this.Controls.Add(this.label3);
         this.Controls.Add(this.comboBox);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.nameTB);
         this.Controls.Add(this.label1);
         this.Name = "AddTown";
         this.Text = "AddTown";
         ((System.ComponentModel.ISupportInitialize)(this.distanceTB)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Button buttonCANCEL;
      private System.Windows.Forms.Button buttonNEXT;
      private System.Windows.Forms.Button buttonOK;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.ComboBox comboBox;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.TextBox nameTB;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.TextBox commentTB;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.NumericUpDown distanceTB;
      private System.Windows.Forms.Button distMaps;
   }
}