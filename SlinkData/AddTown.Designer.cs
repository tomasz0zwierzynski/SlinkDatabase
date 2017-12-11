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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddTown));
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
         this.buttonCANCEL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
         this.buttonCANCEL.Location = new System.Drawing.Point(329, 120);
         this.buttonCANCEL.Name = "buttonCANCEL";
         this.buttonCANCEL.Size = new System.Drawing.Size(75, 23);
         this.buttonCANCEL.TabIndex = 6;
         this.buttonCANCEL.Text = "Cancel";
         this.buttonCANCEL.UseVisualStyleBackColor = true;
         this.buttonCANCEL.Click += new System.EventHandler(this.buttonCANCEL_Click);
         // 
         // buttonNEXT
         // 
         this.buttonNEXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
         this.buttonNEXT.Location = new System.Drawing.Point(429, 120);
         this.buttonNEXT.Name = "buttonNEXT";
         this.buttonNEXT.Size = new System.Drawing.Size(75, 23);
         this.buttonNEXT.TabIndex = 4;
         this.buttonNEXT.Text = "Add Next";
         this.buttonNEXT.UseVisualStyleBackColor = true;
         this.buttonNEXT.Click += new System.EventHandler(this.buttonNEXT_Click);
         // 
         // buttonOK
         // 
         this.buttonOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
         this.buttonOK.Location = new System.Drawing.Point(510, 120);
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
         this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
         this.label3.Location = new System.Drawing.Point(30, 65);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(37, 16);
         this.label3.TabIndex = 10;
         this.label3.Text = "Size:";
         // 
         // comboBox
         // 
         this.comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
         this.comboBox.FormattingEnabled = true;
         this.comboBox.Location = new System.Drawing.Point(73, 62);
         this.comboBox.Name = "comboBox";
         this.comboBox.Size = new System.Drawing.Size(512, 24);
         this.comboBox.TabIndex = 3;
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
         this.label2.Location = new System.Drawing.Point(3, 36);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(64, 16);
         this.label2.TabIndex = 8;
         this.label2.Text = "Distance:";
         // 
         // nameTB
         // 
         this.nameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
         this.nameTB.Location = new System.Drawing.Point(73, 6);
         this.nameTB.MaxLength = 32;
         this.nameTB.Name = "nameTB";
         this.nameTB.Size = new System.Drawing.Size(512, 22);
         this.nameTB.TabIndex = 0;
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
         this.label1.Location = new System.Drawing.Point(19, 9);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(48, 16);
         this.label1.TabIndex = 7;
         this.label1.Text = "Name:";
         // 
         // commentTB
         // 
         this.commentTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
         this.commentTB.Location = new System.Drawing.Point(73, 92);
         this.commentTB.MaxLength = 128;
         this.commentTB.Name = "commentTB";
         this.commentTB.Size = new System.Drawing.Size(512, 22);
         this.commentTB.TabIndex = 2;
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
         this.label4.Location = new System.Drawing.Point(-1, 95);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(68, 16);
         this.label4.TabIndex = 9;
         this.label4.Text = "Comment:";
         // 
         // distanceTB
         // 
         this.distanceTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
         this.distanceTB.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
         this.distanceTB.Location = new System.Drawing.Point(73, 34);
         this.distanceTB.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
         this.distanceTB.Name = "distanceTB";
         this.distanceTB.Size = new System.Drawing.Size(391, 22);
         this.distanceTB.TabIndex = 1;
         this.distanceTB.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
         // 
         // distMaps
         // 
         this.distMaps.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
         this.distMaps.Location = new System.Drawing.Point(470, 34);
         this.distMaps.Name = "distMaps";
         this.distMaps.Size = new System.Drawing.Size(115, 22);
         this.distMaps.TabIndex = 11;
         this.distMaps.Text = "google maps...";
         this.distMaps.UseVisualStyleBackColor = true;
         this.distMaps.Click += new System.EventHandler(this.distMaps_Click);
         // 
         // AddTown
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(590, 147);
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
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
         this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
         this.MaximizeBox = false;
         this.Name = "AddTown";
         this.Text = "Add Town";
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