namespace SpyAgency
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.numCharmLevel = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtCodeName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtWeapon = new System.Windows.Forms.TextBox();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpLastSeen = new System.Windows.Forms.DateTimePicker();
            this.cbspylevel = new System.Windows.Forms.ComboBox();
            this.btnLoadFiles = new System.Windows.Forms.Button();
            this.btnSaveSpy = new System.Windows.Forms.Button();
            this.lbxSpy = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.numAgents = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAgencyName = new System.Windows.Forms.TextBox();
            this.txtAgencyCountry = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.lbxFiles = new System.Windows.Forms.ListBox();
            this.btnDeleteFile = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCharmLevel)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAgents)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SpyAgency2019.Properties.Resources.spy;
            this.pictureBox1.Location = new System.Drawing.Point(13, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.numCharmLevel);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.txtCodeName);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtWeapon);
            this.panel2.Controls.Add(this.dtpDOB);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.dtpLastSeen);
            this.panel2.Controls.Add(this.cbspylevel);
            this.panel2.Location = new System.Drawing.Point(25, 17);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(205, 297);
            this.panel2.TabIndex = 30;
            // 
            // numCharmLevel
            // 
            this.numCharmLevel.Location = new System.Drawing.Point(6, 177);
            this.numCharmLevel.Name = "numCharmLevel";
            this.numCharmLevel.Size = new System.Drawing.Size(138, 20);
            this.numCharmLevel.TabIndex = 17;
            this.numCharmLevel.ValueChanged += new System.EventHandler(this.Allnum_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(2, 3);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 17);
            this.label9.TabIndex = 8;
            this.label9.Text = "Spy";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 162);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(66, 13);
            this.label13.TabIndex = 16;
            this.label13.Text = "Charm Level";
            // 
            // txtCodeName
            // 
            this.txtCodeName.Location = new System.Drawing.Point(4, 37);
            this.txtCodeName.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodeName.Name = "txtCodeName";
            this.txtCodeName.Size = new System.Drawing.Size(197, 20);
            this.txtCodeName.TabIndex = 2;
            this.txtCodeName.Leave += new System.EventHandler(this.AlltxtBoxChanges_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 21);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Spy Code Name";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 113);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Weapon";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1, 203);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Birth Date";
            // 
            // txtWeapon
            // 
            this.txtWeapon.Location = new System.Drawing.Point(6, 128);
            this.txtWeapon.Margin = new System.Windows.Forms.Padding(2);
            this.txtWeapon.Name = "txtWeapon";
            this.txtWeapon.Size = new System.Drawing.Size(138, 20);
            this.txtWeapon.TabIndex = 9;
            this.txtWeapon.Leave += new System.EventHandler(this.AlltxtBoxChanges_TextChanged);
            // 
            // dtpDOB
            // 
            this.dtpDOB.Location = new System.Drawing.Point(2, 218);
            this.dtpDOB.Margin = new System.Windows.Forms.Padding(2);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(198, 20);
            this.dtpDOB.TabIndex = 3;
            this.dtpDOB.ValueChanged += new System.EventHandler(this.AllDTP_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 239);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Date Last Seen";
            // 
            // dtpLastSeen
            // 
            this.dtpLastSeen.Location = new System.Drawing.Point(4, 255);
            this.dtpLastSeen.Margin = new System.Windows.Forms.Padding(2);
            this.dtpLastSeen.Name = "dtpLastSeen";
            this.dtpLastSeen.Size = new System.Drawing.Size(196, 20);
            this.dtpLastSeen.TabIndex = 4;
            this.dtpLastSeen.ValueChanged += new System.EventHandler(this.AllDTP_ValueChanged);
            // 
            // cbspylevel
            // 
            this.cbspylevel.FormattingEnabled = true;
            this.cbspylevel.Items.AddRange(new object[] {
            "Choose a Spy level",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.cbspylevel.Location = new System.Drawing.Point(6, 87);
            this.cbspylevel.Margin = new System.Windows.Forms.Padding(2);
            this.cbspylevel.Name = "cbspylevel";
            this.cbspylevel.Size = new System.Drawing.Size(137, 21);
            this.cbspylevel.TabIndex = 27;
            this.cbspylevel.SelectedIndexChanged += new System.EventHandler(this.Cbspylevel_SelectedIndexChanged);
            // 
            // btnLoadFiles
            // 
            this.btnLoadFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadFiles.Location = new System.Drawing.Point(13, 104);
            this.btnLoadFiles.Margin = new System.Windows.Forms.Padding(2);
            this.btnLoadFiles.Name = "btnLoadFiles";
            this.btnLoadFiles.Size = new System.Drawing.Size(87, 75);
            this.btnLoadFiles.TabIndex = 29;
            this.btnLoadFiles.Text = "Load Spy Files";
            this.btnLoadFiles.UseVisualStyleBackColor = true;
            this.btnLoadFiles.Click += new System.EventHandler(this.btnLoadFiles_Click);
            // 
            // btnSaveSpy
            // 
            this.btnSaveSpy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveSpy.Location = new System.Drawing.Point(280, 190);
            this.btnSaveSpy.Margin = new System.Windows.Forms.Padding(2);
            this.btnSaveSpy.Name = "btnSaveSpy";
            this.btnSaveSpy.Size = new System.Drawing.Size(98, 75);
            this.btnSaveSpy.TabIndex = 28;
            this.btnSaveSpy.Text = "Save Spy";
            this.btnSaveSpy.UseVisualStyleBackColor = true;
            this.btnSaveSpy.Click += new System.EventHandler(this.btnSaveSpy_Click);
            // 
            // lbxSpy
            // 
            this.lbxSpy.BackColor = System.Drawing.Color.DimGray;
            this.lbxSpy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbxSpy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxSpy.FormattingEnabled = true;
            this.lbxSpy.ItemHeight = 16;
            this.lbxSpy.Location = new System.Drawing.Point(373, 21);
            this.lbxSpy.Margin = new System.Windows.Forms.Padding(2);
            this.lbxSpy.Name = "lbxSpy";
            this.lbxSpy.Size = new System.Drawing.Size(228, 178);
            this.lbxSpy.TabIndex = 23;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LemonChiffon;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.numAgents);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtAgencyName);
            this.panel1.Controls.Add(this.txtAgencyCountry);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(242, 17);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(182, 138);
            this.panel1.TabIndex = 26;
            // 
            // numAgents
            // 
            this.numAgents.Location = new System.Drawing.Point(8, 113);
            this.numAgents.Name = "numAgents";
            this.numAgents.Size = new System.Drawing.Size(169, 20);
            this.numAgents.TabIndex = 18;
            this.numAgents.ValueChanged += new System.EventHandler(this.Allnum_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 95);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Number Of Agents";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 58);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Agency Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2, 22);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Country";
            // 
            // txtAgencyName
            // 
            this.txtAgencyName.Location = new System.Drawing.Point(5, 74);
            this.txtAgencyName.Margin = new System.Windows.Forms.Padding(2);
            this.txtAgencyName.Name = "txtAgencyName";
            this.txtAgencyName.Size = new System.Drawing.Size(173, 20);
            this.txtAgencyName.TabIndex = 2;
            this.txtAgencyName.Leave += new System.EventHandler(this.AlltxtBoxChanges_TextChanged);
            // 
            // txtAgencyCountry
            // 
            this.txtAgencyCountry.Location = new System.Drawing.Point(5, 37);
            this.txtAgencyCountry.Margin = new System.Windows.Forms.Padding(2);
            this.txtAgencyCountry.Name = "txtAgencyCountry";
            this.txtAgencyCountry.Size = new System.Drawing.Size(173, 20);
            this.txtAgencyCountry.TabIndex = 1;
            this.txtAgencyCountry.Leave += new System.EventHandler(this.AlltxtBoxChanges_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(2, 3);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Agency";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightGray;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.btnSaveSpy);
            this.panel3.Location = new System.Drawing.Point(53, 229);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(461, 330);
            this.panel3.TabIndex = 32;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(34, -1);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(135, 17);
            this.label14.TabIndex = 19;
            this.label14.Text = "Create a new Spy";
            // 
            // lbxFiles
            // 
            this.lbxFiles.BackColor = System.Drawing.Color.DimGray;
            this.lbxFiles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbxFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxFiles.FormattingEnabled = true;
            this.lbxFiles.ItemHeight = 16;
            this.lbxFiles.Location = new System.Drawing.Point(131, 21);
            this.lbxFiles.Margin = new System.Windows.Forms.Padding(2);
            this.lbxFiles.Name = "lbxFiles";
            this.lbxFiles.Size = new System.Drawing.Size(228, 178);
            this.lbxFiles.TabIndex = 33;
            this.lbxFiles.SelectedIndexChanged += new System.EventHandler(this.lbxFiles_SelectedIndexChanged);
            // 
            // btnDeleteFile
            // 
            this.btnDeleteFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteFile.Location = new System.Drawing.Point(11, 183);
            this.btnDeleteFile.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteFile.Name = "btnDeleteFile";
            this.btnDeleteFile.Size = new System.Drawing.Size(87, 39);
            this.btnDeleteFile.TabIndex = 34;
            this.btnDeleteFile.Text = "Delete Spy File";
            this.btnDeleteFile.UseVisualStyleBackColor = true;
            this.btnDeleteFile.Click += new System.EventHandler(this.btnDeleteFile_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "Spy level";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(612, 585);
            this.Controls.Add(this.btnDeleteFile);
            this.Controls.Add(this.lbxFiles);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbxSpy);
            this.Controls.Add(this.btnLoadFiles);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCharmLevel)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAgents)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCodeName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpLastSeen;
        private System.Windows.Forms.Button btnLoadFiles;
        private System.Windows.Forms.Button btnSaveSpy;
        private System.Windows.Forms.ComboBox cbspylevel;
        private System.Windows.Forms.ListBox lbxSpy;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAgencyName;
        private System.Windows.Forms.TextBox txtAgencyCountry;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtWeapon;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown numCharmLevel;
        private System.Windows.Forms.NumericUpDown numAgents;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ListBox lbxFiles;
        private System.Windows.Forms.Button btnDeleteFile;
        private System.Windows.Forms.Label label8;
    }
}

