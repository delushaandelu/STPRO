﻿namespace main
{
    partial class frmAddEditStudent
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtStudentID = new MetroFramework.Controls.MetroTextBox();
            this.txtFirstName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtLastName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtDob = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.txtAddress = new MetroFramework.Controls.MetroTextBox();
            this.sdasd = new MetroFramework.Controls.MetroLabel();
            this.txtTell = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.txtStand = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.txtClass = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.chkGender = new MetroFramework.Controls.MetroCheckBox();
            this.cboCity = new MetroFramework.Controls.MetroComboBox();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.txtDonation = new MetroFramework.Controls.MetroTextBox();
            this.init = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(56, 77);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(69, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Student ID";
            this.metroLabel1.Click += new System.EventHandler(this.metroLabel1_Click);
            // 
            // txtStudentID
            // 
            this.txtStudentID.Location = new System.Drawing.Point(168, 75);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.ReadOnly = true;
            this.txtStudentID.Size = new System.Drawing.Size(191, 23);
            this.txtStudentID.TabIndex = 1;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(168, 117);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(191, 23);
            this.txtFirstName.TabIndex = 3;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(56, 119);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(73, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "First Name";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(168, 159);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(191, 23);
            this.txtLastName.TabIndex = 5;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(56, 161);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(71, 19);
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "Last Name";
            // 
            // txtDob
            // 
            this.txtDob.Location = new System.Drawing.Point(168, 205);
            this.txtDob.Name = "txtDob";
            this.txtDob.Size = new System.Drawing.Size(191, 23);
            this.txtDob.TabIndex = 7;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(56, 207);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(84, 19);
            this.metroLabel4.TabIndex = 6;
            this.metroLabel4.Text = "Date of Birth";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(56, 253);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(52, 19);
            this.metroLabel5.TabIndex = 8;
            this.metroLabel5.Text = "Gender";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(424, 154);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(31, 19);
            this.metroLabel6.TabIndex = 10;
            this.metroLabel6.Text = "City";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(536, 75);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(191, 59);
            this.txtAddress.TabIndex = 13;
            // 
            // sdasd
            // 
            this.sdasd.AutoSize = true;
            this.sdasd.Location = new System.Drawing.Point(424, 92);
            this.sdasd.Name = "sdasd";
            this.sdasd.Size = new System.Drawing.Size(56, 19);
            this.sdasd.TabIndex = 12;
            this.sdasd.Text = "Address";
            // 
            // txtTell
            // 
            this.txtTell.Location = new System.Drawing.Point(536, 191);
            this.txtTell.Name = "txtTell";
            this.txtTell.Size = new System.Drawing.Size(191, 23);
            this.txtTell.TabIndex = 15;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(424, 193);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(77, 19);
            this.metroLabel8.TabIndex = 14;
            this.metroLabel8.Text = "Tel Number";
            // 
            // txtStand
            // 
            this.txtStand.Location = new System.Drawing.Point(536, 237);
            this.txtStand.Name = "txtStand";
            this.txtStand.Size = new System.Drawing.Size(191, 23);
            this.txtStand.TabIndex = 17;
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(424, 239);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(62, 19);
            this.metroLabel9.TabIndex = 16;
            this.metroLabel9.Text = "Standerd";
            // 
            // txtClass
            // 
            this.txtClass.Location = new System.Drawing.Point(536, 283);
            this.txtClass.Name = "txtClass";
            this.txtClass.Size = new System.Drawing.Size(191, 23);
            this.txtClass.TabIndex = 19;
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(424, 285);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(98, 19);
            this.metroLabel10.TabIndex = 18;
            this.metroLabel10.Text = "ClassRoom Sec";
            // 
            // chkGender
            // 
            this.chkGender.AutoSize = true;
            this.chkGender.Location = new System.Drawing.Point(168, 256);
            this.chkGender.Name = "chkGender";
            this.chkGender.Size = new System.Drawing.Size(28, 15);
            this.chkGender.TabIndex = 20;
            this.chkGender.Text = "?";
            this.chkGender.UseVisualStyleBackColor = true;
            // 
            // cboCity
            // 
            this.cboCity.FormattingEnabled = true;
            this.cboCity.ItemHeight = 23;
            this.cboCity.Location = new System.Drawing.Point(536, 151);
            this.cboCity.Name = "cboCity";
            this.cboCity.Size = new System.Drawing.Size(191, 29);
            this.cboCity.TabIndex = 21;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(666, 332);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(83, 32);
            this.btnSave.TabIndex = 22;
            this.btnSave.Text = "&Save";
            // 
            // txtDonation
            // 
            this.txtDonation.Location = new System.Drawing.Point(168, 285);
            this.txtDonation.Name = "txtDonation";
            this.txtDonation.Size = new System.Drawing.Size(191, 23);
            this.txtDonation.TabIndex = 24;
            this.txtDonation.Click += new System.EventHandler(this.metroTextBox5_Click);
            // 
            // init
            // 
            this.init.AutoSize = true;
            this.init.Location = new System.Drawing.Point(56, 287);
            this.init.Name = "init";
            this.init.Size = new System.Drawing.Size(83, 19);
            this.init.TabIndex = 23;
            this.init.Text = "Init Donation";
            this.init.Click += new System.EventHandler(this.metroLabel11_Click);
            // 
            // frmAddEditStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 387);
            this.Controls.Add(this.txtDonation);
            this.Controls.Add(this.init);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cboCity);
            this.Controls.Add(this.chkGender);
            this.Controls.Add(this.txtClass);
            this.Controls.Add(this.metroLabel10);
            this.Controls.Add(this.txtStand);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.txtTell);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.sdasd);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.txtDob);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.txtStudentID);
            this.Controls.Add(this.metroLabel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddEditStudent";
            this.Resizable = false;
            this.Text = "Student Information";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtStudentID;
        private MetroFramework.Controls.MetroTextBox txtFirstName;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtLastName;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtDob;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox txtAddress;
        private MetroFramework.Controls.MetroLabel sdasd;
        private MetroFramework.Controls.MetroTextBox txtTell;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroTextBox txtStand;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroTextBox txtClass;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroCheckBox chkGender;
        private MetroFramework.Controls.MetroComboBox cboCity;
        private MetroFramework.Controls.MetroButton btnSave;
        private MetroFramework.Controls.MetroTextBox txtDonation;
        private MetroFramework.Controls.MetroLabel init;
    }
}