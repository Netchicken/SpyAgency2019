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
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCodeName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpLastSeen = new System.Windows.Forms.DateTimePicker();
            this.cbspylevel = new System.Windows.Forms.ComboBox();
            this.numCharmLevel = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.txtGadgets = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtKillability = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtWeapon = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lbxFiles = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCharmLevel)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAgents)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Green;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(8, 69);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Choose Spy Level";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.txtCodeName);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.dtpDOB);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.dtpLastSeen);
            this.panel2.Controls.Add(this.cbspylevel);
            this.panel2.Location = new System.Drawing.Point(25, 17);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(205, 214);
            this.panel2.TabIndex = 30;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 126);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Birth Date";
            // 
            // dtpDOB
            // 
            this.dtpDOB.Location = new System.Drawing.Point(4, 141);
            this.dtpDOB.Margin = new System.Windows.Forms.Padding(2);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(198, 20);
            this.dtpDOB.TabIndex = 3;
            this.dtpDOB.ValueChanged += new System.EventHandler(this.DtpDOB_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 162);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Date Last Seen";
            // 
            // dtpLastSeen
            // 
            this.dtpLastSeen.Location = new System.Drawing.Point(6, 178);
            this.dtpLastSeen.Margin = new System.Windows.Forms.Padding(2);
            this.dtpLastSeen.Name = "dtpLastSeen";
            this.dtpLastSeen.Size = new System.Drawing.Size(196, 20);
            this.dtpLastSeen.TabIndex = 4;
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
            // numCharmLevel
            // 
            this.numCharmLevel.Location = new System.Drawing.Point(5, 84);
            this.numCharmLevel.Name = "numCharmLevel";
            this.numCharmLevel.Size = new System.Drawing.Size(138, 20);
            this.numCharmLevel.TabIndex = 17;
            this.numCharmLevel.ValueChanged += new System.EventHandler(this.Allnum_ValueChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(2, 69);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(66, 13);
            this.label13.TabIndex = 16;
            this.label13.Text = "Charm Level";
            // 
            // txtGadgets
            // 
            this.txtGadgets.Location = new System.Drawing.Point(235, 61);
            this.txtGadgets.Margin = new System.Windows.Forms.Padding(2);
            this.txtGadgets.Name = "txtGadgets";
            this.txtGadgets.Size = new System.Drawing.Size(139, 20);
            this.txtGadgets.TabIndex = 13;
            this.txtGadgets.Leave += new System.EventHandler(this.AlltxtBoxChanges_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(233, 45);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "Gadgets";
            // 
            // txtKillability
            // 
            this.txtKillability.Location = new System.Drawing.Point(235, 24);
            this.txtKillability.Margin = new System.Windows.Forms.Padding(2);
            this.txtKillability.Name = "txtKillability";
            this.txtKillability.Size = new System.Drawing.Size(139, 20);
            this.txtKillability.TabIndex = 11;
            this.txtKillability.Leave += new System.EventHandler(this.AlltxtBoxChanges_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(232, 9);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 13);
            this.label12.TabIndex = 12;
            this.label12.Text = "Killability";
            // 
            // txtWeapon
            // 
            this.txtWeapon.Location = new System.Drawing.Point(3, 47);
            this.txtWeapon.Margin = new System.Windows.Forms.Padding(2);
            this.txtWeapon.Name = "txtWeapon";
            this.txtWeapon.Size = new System.Drawing.Size(159, 20);
            this.txtWeapon.TabIndex = 9;
            this.txtWeapon.Leave += new System.EventHandler(this.AlltxtBoxChanges_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(0, 32);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Weapon";
            // 
            // btnLoadFiles
            // 
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
            this.btnSaveSpy.Location = new System.Drawing.Point(244, 195);
            this.btnSaveSpy.Margin = new System.Windows.Forms.Padding(2);
            this.btnSaveSpy.Name = "btnSaveSpy";
            this.btnSaveSpy.Size = new System.Drawing.Size(180, 26);
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
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.btnSaveSpy);
            this.panel3.Location = new System.Drawing.Point(53, 229);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(461, 395);
            this.panel3.TabIndex = 32;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel4.Controls.Add(this.numCharmLevel);
            this.panel4.Controls.Add(this.label15);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.label13);
            this.panel4.Controls.Add(this.txtKillability);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.txtGadgets);
            this.panel4.Controls.Add(this.txtWeapon);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Location = new System.Drawing.Point(25, 236);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(389, 111);
            this.panel4.TabIndex = 31;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(2, 9);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(189, 17);
            this.label15.TabIndex = 20;
            this.label15.Text = "Change Default Features";
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(612, 782);
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
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label8;
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
        private System.Windows.Forms.TextBox txtGadgets;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtKillability;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown numCharmLevel;
        private System.Windows.Forms.NumericUpDown numAgents;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ListBox lbxFiles;
    }
}

