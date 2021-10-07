
namespace eBank.WinUI.Users
{
    partial class frmUserDetails
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
            this.components = new System.ComponentModel.Container();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblLastName2 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblDOB = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.clbRole = new System.Windows.Forms.CheckedListBox();
            this.lblRoles = new System.Windows.Forms.Label();
            this.lblJMBG = new System.Windows.Forms.Label();
            this.btnSuggestPassword = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblImage = new System.Windows.Forms.Label();
            this.btnAddPicture = new System.Windows.Forms.Button();
            this.txtPictureInput = new System.Windows.Forms.TextBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.cbCity = new System.Windows.Forms.ComboBox();
            this.dtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSuggestUsername = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtJMBG = new System.Windows.Forms.TextBox();
            this.errorProviderUserDetails = new System.Windows.Forms.ErrorProvider(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderUserDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(22, 241);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(149, 20);
            this.txtFirstName.TabIndex = 0;
            this.txtFirstName.Validating += new System.ComponentModel.CancelEventHandler(this.txtFirstName_Validating);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(22, 226);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(55, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "First name";
            // 
            // lblLastName2
            // 
            this.lblLastName2.AutoSize = true;
            this.lblLastName2.Location = new System.Drawing.Point(22, 280);
            this.lblLastName2.Name = "lblLastName2";
            this.lblLastName2.Size = new System.Drawing.Size(56, 13);
            this.lblLastName2.TabIndex = 3;
            this.lblLastName2.Text = "Last name";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(22, 295);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(149, 20);
            this.txtLastName.TabIndex = 2;
            this.txtLastName.Validating += new System.ComponentModel.CancelEventHandler(this.txtLastName_Validating);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(270, 177);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 5;
            this.lblEmail.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(270, 192);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(149, 20);
            this.txtEmail.TabIndex = 4;
            this.txtEmail.Validating += new System.ComponentModel.CancelEventHandler(this.txtEmail_Validating);
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Location = new System.Drawing.Point(22, 382);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(65, 13);
            this.lblDOB.TabIndex = 7;
            this.lblDOB.Text = "Date of birth";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(267, 20);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(24, 13);
            this.lblCity.TabIndex = 9;
            this.lblCity.Text = "City";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(267, 73);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(45, 13);
            this.lblAddress.TabIndex = 11;
            this.lblAddress.Text = "Address";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(267, 89);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(149, 20);
            this.txtAddress.TabIndex = 10;
            this.txtAddress.Validating += new System.ComponentModel.CancelEventHandler(this.txtAddress_Validating);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(39, 17);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(55, 13);
            this.lblUsername.TabIndex = 13;
            this.lblUsername.Text = "Username";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(39, 33);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(149, 20);
            this.txtUsername.TabIndex = 12;
            this.txtUsername.Validating += new System.ComponentModel.CancelEventHandler(this.txtUsername_Validating);
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(270, 123);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(42, 13);
            this.lblGender.TabIndex = 14;
            this.lblGender.Text = "Gender";
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Location = new System.Drawing.Point(270, 142);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(48, 17);
            this.rbMale.TabIndex = 15;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(355, 142);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(59, 17);
            this.rbFemale.TabIndex = 16;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(39, 94);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 13);
            this.lblPassword.TabIndex = 18;
            this.lblPassword.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(39, 110);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(149, 20);
            this.txtPassword.TabIndex = 17;
            this.txtPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtPassword_Validating);
            // 
            // clbRole
            // 
            this.clbRole.FormattingEnabled = true;
            this.clbRole.Location = new System.Drawing.Point(39, 172);
            this.clbRole.Name = "clbRole";
            this.clbRole.Size = new System.Drawing.Size(103, 49);
            this.clbRole.TabIndex = 19;
            this.clbRole.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.clbRole_ItemCheck);
            this.clbRole.Validating += new System.ComponentModel.CancelEventHandler(this.clbRoles_Validating);
            // 
            // lblRoles
            // 
            this.lblRoles.AutoSize = true;
            this.lblRoles.Location = new System.Drawing.Point(39, 152);
            this.lblRoles.Name = "lblRoles";
            this.lblRoles.Size = new System.Drawing.Size(34, 13);
            this.lblRoles.TabIndex = 20;
            this.lblRoles.Text = "Roles";
            // 
            // lblJMBG
            // 
            this.lblJMBG.AutoSize = true;
            this.lblJMBG.Location = new System.Drawing.Point(22, 331);
            this.lblJMBG.Name = "lblJMBG";
            this.lblJMBG.Size = new System.Drawing.Size(36, 13);
            this.lblJMBG.TabIndex = 22;
            this.lblJMBG.Text = "JMBG";
            // 
            // btnSuggestPassword
            // 
            this.btnSuggestPassword.Location = new System.Drawing.Point(123, 140);
            this.btnSuggestPassword.Name = "btnSuggestPassword";
            this.btnSuggestPassword.Size = new System.Drawing.Size(64, 25);
            this.btnSuggestPassword.TabIndex = 23;
            this.btnSuggestPassword.Text = "Suggest";
            this.btnSuggestPassword.UseVisualStyleBackColor = true;
            this.btnSuggestPassword.Click += new System.EventHandler(this.btnSuggest_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblImage);
            this.groupBox1.Controls.Add(this.btnAddPicture);
            this.groupBox1.Controls.Add(this.txtPictureInput);
            this.groupBox1.Controls.Add(this.pictureBox);
            this.groupBox1.Controls.Add(this.cbCity);
            this.groupBox1.Controls.Add(this.dtpDateOfBirth);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.lblJMBG);
            this.groupBox1.Controls.Add(this.txtJMBG);
            this.groupBox1.Controls.Add(this.rbFemale);
            this.groupBox1.Controls.Add(this.rbMale);
            this.groupBox1.Controls.Add(this.lblGender);
            this.groupBox1.Controls.Add(this.lblAddress);
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Controls.Add(this.lblCity);
            this.groupBox1.Controls.Add(this.lblDOB);
            this.groupBox1.Controls.Add(this.lblEmail);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.lblLastName2);
            this.groupBox1.Controls.Add(this.txtLastName);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Controls.Add(this.txtFirstName);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(483, 473);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User details";
            // 
            // lblImage
            // 
            this.lblImage.AutoSize = true;
            this.lblImage.Location = new System.Drawing.Point(22, 156);
            this.lblImage.Name = "lblImage";
            this.lblImage.Size = new System.Drawing.Size(71, 13);
            this.lblImage.TabIndex = 61;
            this.lblImage.Text = "User\'s picture";
            // 
            // btnAddPicture
            // 
            this.btnAddPicture.Location = new System.Drawing.Point(148, 170);
            this.btnAddPicture.Name = "btnAddPicture";
            this.btnAddPicture.Size = new System.Drawing.Size(51, 23);
            this.btnAddPicture.TabIndex = 59;
            this.btnAddPicture.Text = "Add";
            this.btnAddPicture.UseVisualStyleBackColor = true;
            this.btnAddPicture.Click += new System.EventHandler(this.btnAddPicture_Click);
            // 
            // txtPictureInput
            // 
            this.txtPictureInput.Location = new System.Drawing.Point(21, 172);
            this.txtPictureInput.Name = "txtPictureInput";
            this.txtPictureInput.Size = new System.Drawing.Size(121, 20);
            this.txtPictureInput.TabIndex = 60;
            this.txtPictureInput.TabStop = false;
            // 
            // pictureBox
            // 
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox.Location = new System.Drawing.Point(22, 26);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(120, 120);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox.TabIndex = 58;
            this.pictureBox.TabStop = false;
            // 
            // cbCity
            // 
            this.cbCity.FormattingEnabled = true;
            this.cbCity.Location = new System.Drawing.Point(267, 39);
            this.cbCity.Name = "cbCity";
            this.cbCity.Size = new System.Drawing.Size(149, 21);
            this.cbCity.TabIndex = 27;
            this.cbCity.Validating += new System.ComponentModel.CancelEventHandler(this.cbCity_Validating);
            // 
            // dtpDateOfBirth
            // 
            this.dtpDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateOfBirth.Location = new System.Drawing.Point(22, 402);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.Size = new System.Drawing.Size(149, 20);
            this.dtpDateOfBirth.TabIndex = 26;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSuggestUsername);
            this.groupBox2.Controls.Add(this.btnSuggestPassword);
            this.groupBox2.Controls.Add(this.lblPassword);
            this.groupBox2.Controls.Add(this.txtPassword);
            this.groupBox2.Controls.Add(this.lblUsername);
            this.groupBox2.Controls.Add(this.lblRoles);
            this.groupBox2.Controls.Add(this.txtUsername);
            this.groupBox2.Controls.Add(this.clbRole);
            this.groupBox2.Location = new System.Drawing.Point(231, 224);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(227, 234);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Login details";
            // 
            // btnSuggestUsername
            // 
            this.btnSuggestUsername.Location = new System.Drawing.Point(123, 64);
            this.btnSuggestUsername.Name = "btnSuggestUsername";
            this.btnSuggestUsername.Size = new System.Drawing.Size(64, 27);
            this.btnSuggestUsername.TabIndex = 24;
            this.btnSuggestUsername.Text = "Suggest";
            this.btnSuggestUsername.UseVisualStyleBackColor = true;
            this.btnSuggestUsername.Click += new System.EventHandler(this.btnSuggestUsername_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(25, 438);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(174, 20);
            this.btnSave.TabIndex = 24;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtJMBG
            // 
            this.txtJMBG.Location = new System.Drawing.Point(22, 346);
            this.txtJMBG.Name = "txtJMBG";
            this.txtJMBG.Size = new System.Drawing.Size(149, 20);
            this.txtJMBG.TabIndex = 21;
            this.txtJMBG.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtJMBG_KeyPress);
            this.txtJMBG.Validating += new System.ComponentModel.CancelEventHandler(this.txtJMBG_Validating);
            // 
            // errorProviderUserDetails
            // 
            this.errorProviderUserDetails.ContainerControl = this;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmUserDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 497);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmUserDetails";
            this.Text = "User details";
            this.Load += new System.EventHandler(this.frmUserDetails_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderUserDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblLastName2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblRoles;
        private System.Windows.Forms.CheckedListBox clbRole;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label lblJMBG;
        private System.Windows.Forms.Button btnSuggestPassword;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtJMBG;
        private System.Windows.Forms.DateTimePicker dtpDateOfBirth;
        private System.Windows.Forms.ComboBox cbCity;
        private System.Windows.Forms.ErrorProvider errorProviderUserDetails;
        private System.Windows.Forms.Label lblImage;
        private System.Windows.Forms.Button btnAddPicture;
        private System.Windows.Forms.TextBox txtPictureInput;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnSuggestUsername;
    }
}