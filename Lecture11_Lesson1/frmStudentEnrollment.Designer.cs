
namespace Lecture11_Lesson1
{
    partial class frmStudentEnrollment
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
            this.btnSubmit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtBuilding = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.cbCity = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbCountry = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.cbNationality = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbCityOfBirth = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbCountryOfBirth = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePickerDOB = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtThirdName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSecondName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtMobile = new System.Windows.Forms.MaskedTextBox();
            this.txtPhone = new System.Windows.Forms.MaskedTextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBoxStudentPicture = new System.Windows.Forms.PictureBox();
            this.btnPictureUpload = new System.Windows.Forms.GroupBox();
            this.txtGPA = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.cbDegree = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.dateTimePickerGraduationDate = new System.Windows.Forms.DateTimePicker();
            this.txtSchool = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.openFileDialogImages = new System.Windows.Forms.OpenFileDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.dataGridViewStudents = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStudentPicture)).BeginInit();
            this.btnPictureUpload.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(12, 687);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(113, 34);
            this.btnSubmit.TabIndex = 14;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtBuilding);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtStreet);
            this.groupBox1.Controls.Add(this.cbCity);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.cbCountry);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(12, 462);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(518, 208);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student Address";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(17, 167);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 18);
            this.label11.TabIndex = 26;
            this.label11.Text = "Building";
            // 
            // txtBuilding
            // 
            this.txtBuilding.Location = new System.Drawing.Point(97, 164);
            this.txtBuilding.Name = "txtBuilding";
            this.txtBuilding.Size = new System.Drawing.Size(100, 26);
            this.txtBuilding.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(29, 124);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 18);
            this.label10.TabIndex = 24;
            this.label10.Text = "Street";
            // 
            // txtStreet
            // 
            this.txtStreet.Location = new System.Drawing.Point(97, 121);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(403, 26);
            this.txtStreet.TabIndex = 23;
            // 
            // cbCity
            // 
            this.cbCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCity.FormattingEnabled = true;
            this.cbCity.Items.AddRange(new object[] {
            "Amman",
            "Damascus",
            "Baghdad"});
            this.cbCity.Location = new System.Drawing.Point(97, 79);
            this.cbCity.Name = "cbCity";
            this.cbCity.Size = new System.Drawing.Size(200, 26);
            this.cbCity.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(44, 82);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 18);
            this.label9.TabIndex = 21;
            this.label9.Text = "City";
            // 
            // cbCountry
            // 
            this.cbCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCountry.FormattingEnabled = true;
            this.cbCountry.Items.AddRange(new object[] {
            "Jordan",
            "Syria",
            "Iraq"});
            this.cbCountry.Location = new System.Drawing.Point(97, 34);
            this.cbCountry.Name = "cbCountry";
            this.cbCountry.Size = new System.Drawing.Size(200, 26);
            this.cbCountry.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 18);
            this.label8.TabIndex = 19;
            this.label8.Text = "Country";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.groupBox7);
            this.groupBox2.Controls.Add(this.cbNationality);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.cbCityOfBirth);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.cbCountryOfBirth);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.dateTimePickerDOB);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtLastName);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtThirdName);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtSecondName);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtFirstName);
            this.groupBox2.Controls.Add(this.lblFirstName);
            this.groupBox2.Location = new System.Drawing.Point(160, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1261, 215);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Personal Information";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(401, 96);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 18);
            this.label12.TabIndex = 20;
            this.label12.Text = "Gender";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.rbFemale);
            this.groupBox7.Controls.Add(this.rbMale);
            this.groupBox7.Location = new System.Drawing.Point(462, 79);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(178, 117);
            this.groupBox7.TabIndex = 8;
            this.groupBox7.TabStop = false;
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(16, 54);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(73, 22);
            this.rbFemale.TabIndex = 8;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Location = new System.Drawing.Point(16, 18);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(56, 22);
            this.rbMale.TabIndex = 8;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // cbNationality
            // 
            this.cbNationality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNationality.FormattingEnabled = true;
            this.cbNationality.Items.AddRange(new object[] {
            "Jordanian",
            "Syrian",
            "Iraqi"});
            this.cbNationality.Location = new System.Drawing.Point(747, 96);
            this.cbNationality.Name = "cbNationality";
            this.cbNationality.Size = new System.Drawing.Size(200, 26);
            this.cbNationality.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(667, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 18);
            this.label7.TabIndex = 17;
            this.label7.Text = "Nationality";
            // 
            // cbCityOfBirth
            // 
            this.cbCityOfBirth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCityOfBirth.FormattingEnabled = true;
            this.cbCityOfBirth.Items.AddRange(new object[] {
            "Amman",
            "Damascus",
            "Baghdad"});
            this.cbCityOfBirth.Location = new System.Drawing.Point(120, 161);
            this.cbCityOfBirth.Name = "cbCityOfBirth";
            this.cbCityOfBirth.Size = new System.Drawing.Size(200, 26);
            this.cbCityOfBirth.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 18);
            this.label6.TabIndex = 15;
            this.label6.Text = "City of Birth";
            // 
            // cbCountryOfBirth
            // 
            this.cbCountryOfBirth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCountryOfBirth.FormattingEnabled = true;
            this.cbCountryOfBirth.Items.AddRange(new object[] {
            "Jordan",
            "Syria",
            "Iraq"});
            this.cbCountryOfBirth.Location = new System.Drawing.Point(120, 129);
            this.cbCountryOfBirth.Name = "cbCountryOfBirth";
            this.cbCountryOfBirth.Size = new System.Drawing.Size(200, 26);
            this.cbCountryOfBirth.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 18);
            this.label5.TabIndex = 13;
            this.label5.Text = "Country of Birth";
            // 
            // dateTimePickerDOB
            // 
            this.dateTimePickerDOB.Location = new System.Drawing.Point(120, 93);
            this.dateTimePickerDOB.Name = "dateTimePickerDOB";
            this.dateTimePickerDOB.Size = new System.Drawing.Size(200, 26);
            this.dateTimePickerDOB.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 18);
            this.label4.TabIndex = 11;
            this.label4.Text = "Date of Birth";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(1048, 28);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(200, 26);
            this.txtLastName.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(963, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "Last Name";
            // 
            // txtThirdName
            // 
            this.txtThirdName.Location = new System.Drawing.Point(747, 28);
            this.txtThirdName.Name = "txtThirdName";
            this.txtThirdName.Size = new System.Drawing.Size(200, 26);
            this.txtThirdName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(656, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Third Name";
            // 
            // txtSecondName
            // 
            this.txtSecondName.Location = new System.Drawing.Point(440, 28);
            this.txtSecondName.Name = "txtSecondName";
            this.txtSecondName.Size = new System.Drawing.Size(200, 26);
            this.txtSecondName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(335, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Second Name";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(120, 28);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(200, 26);
            this.txtFirstName.TabIndex = 1;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(35, 31);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(79, 18);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "First Name";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtMobile);
            this.groupBox3.Controls.Add(this.txtPhone);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.txtEmail);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Location = new System.Drawing.Point(12, 248);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(518, 208);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Contact Information";
            // 
            // txtMobile
            // 
            this.txtMobile.Location = new System.Drawing.Point(91, 152);
            this.txtMobile.Mask = "(7)00000000";
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(200, 26);
            this.txtMobile.TabIndex = 27;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(91, 95);
            this.txtPhone.Mask = "(7)00000000";
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(200, 26);
            this.txtPhone.TabIndex = 26;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(37, 155);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(48, 18);
            this.label15.TabIndex = 25;
            this.label15.Text = "Mobile";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(91, 37);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(409, 26);
            this.txtEmail.TabIndex = 10;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(44, 40);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 18);
            this.label14.TabIndex = 23;
            this.label14.Text = "Email";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(37, 98);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(48, 18);
            this.label13.TabIndex = 21;
            this.label13.Text = "Phone";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Controls.Add(this.pictureBoxStudentPicture);
            this.groupBox4.Location = new System.Drawing.Point(12, 27);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(142, 215);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Photo";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(10, 179);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 30);
            this.button1.TabIndex = 20;
            this.button1.Text = "Upload";
            this.toolTip1.SetToolTip(this.button1, "Please upload the student\'s photo");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBoxStudentPicture
            // 
            this.pictureBoxStudentPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxStudentPicture.Location = new System.Drawing.Point(7, 28);
            this.pictureBoxStudentPicture.Name = "pictureBoxStudentPicture";
            this.pictureBoxStudentPicture.Size = new System.Drawing.Size(129, 145);
            this.pictureBoxStudentPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxStudentPicture.TabIndex = 0;
            this.pictureBoxStudentPicture.TabStop = false;
            // 
            // btnPictureUpload
            // 
            this.btnPictureUpload.Controls.Add(this.txtGPA);
            this.btnPictureUpload.Controls.Add(this.label19);
            this.btnPictureUpload.Controls.Add(this.cbDegree);
            this.btnPictureUpload.Controls.Add(this.label18);
            this.btnPictureUpload.Controls.Add(this.label17);
            this.btnPictureUpload.Controls.Add(this.dateTimePickerGraduationDate);
            this.btnPictureUpload.Controls.Add(this.txtSchool);
            this.btnPictureUpload.Controls.Add(this.label16);
            this.btnPictureUpload.Location = new System.Drawing.Point(545, 248);
            this.btnPictureUpload.Name = "btnPictureUpload";
            this.btnPictureUpload.Size = new System.Drawing.Size(876, 422);
            this.btnPictureUpload.TabIndex = 5;
            this.btnPictureUpload.TabStop = false;
            this.btnPictureUpload.Text = "Education";
            // 
            // txtGPA
            // 
            this.txtGPA.Location = new System.Drawing.Point(142, 214);
            this.txtGPA.Name = "txtGPA";
            this.txtGPA.Size = new System.Drawing.Size(200, 26);
            this.txtGPA.TabIndex = 32;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(87, 217);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(35, 18);
            this.label19.TabIndex = 31;
            this.label19.Text = "GPA";
            // 
            // cbDegree
            // 
            this.cbDegree.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDegree.FormattingEnabled = true;
            this.cbDegree.Items.AddRange(new object[] {
            "Tawjihi",
            "SAT",
            "IB"});
            this.cbDegree.Location = new System.Drawing.Point(142, 32);
            this.cbDegree.Name = "cbDegree";
            this.cbDegree.Size = new System.Drawing.Size(200, 26);
            this.cbDegree.TabIndex = 22;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(81, 35);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(55, 18);
            this.label18.TabIndex = 21;
            this.label18.Text = "Degree";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(22, 161);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(114, 18);
            this.label17.TabIndex = 30;
            this.label17.Text = "Graduation Date";
            // 
            // dateTimePickerGraduationDate
            // 
            this.dateTimePickerGraduationDate.Location = new System.Drawing.Point(142, 155);
            this.dateTimePickerGraduationDate.Name = "dateTimePickerGraduationDate";
            this.dateTimePickerGraduationDate.Size = new System.Drawing.Size(200, 26);
            this.dateTimePickerGraduationDate.TabIndex = 29;
            // 
            // txtSchool
            // 
            this.txtSchool.Location = new System.Drawing.Point(142, 90);
            this.txtSchool.Name = "txtSchool";
            this.txtSchool.Size = new System.Drawing.Size(278, 26);
            this.txtSchool.TabIndex = 28;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(87, 93);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(49, 18);
            this.label16.TabIndex = 27;
            this.label16.Text = "School";
            // 
            // openFileDialogImages
            // 
            this.openFileDialogImages.FileName = "openFileDialog1";
            // 
            // dataGridViewStudents
            // 
            this.dataGridViewStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudents.Location = new System.Drawing.Point(19, 761);
            this.dataGridViewStudents.Name = "dataGridViewStudents";
            this.dataGridViewStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewStudents.Size = new System.Drawing.Size(1402, 150);
            this.dataGridViewStudents.TabIndex = 15;
            this.dataGridViewStudents.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewStudents_CellClick);
            // 
            // frmStudentEnrollment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1433, 968);
            this.Controls.Add(this.dataGridViewStudents);
            this.Controls.Add(this.btnPictureUpload);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSubmit);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmStudentEnrollment";
            this.Text = "Student Enrollment Form";
            this.Load += new System.EventHandler(this.frmStudentEnrollment_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStudentPicture)).EndInit();
            this.btnPictureUpload.ResumeLayout(false);
            this.btnPictureUpload.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtBuilding;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.ComboBox cbCity;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbCountry;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.ComboBox cbNationality;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbCityOfBirth;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbCountryOfBirth;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePickerDOB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtThirdName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSecondName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBoxStudentPicture;
        private System.Windows.Forms.GroupBox btnPictureUpload;
        private System.Windows.Forms.TextBox txtGPA;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox cbDegree;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DateTimePicker dateTimePickerGraduationDate;
        private System.Windows.Forms.TextBox txtSchool;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.OpenFileDialog openFileDialogImages;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.MaskedTextBox txtMobile;
        private System.Windows.Forms.MaskedTextBox txtPhone;
        private System.Windows.Forms.DataGridView dataGridViewStudents;
    }
}

