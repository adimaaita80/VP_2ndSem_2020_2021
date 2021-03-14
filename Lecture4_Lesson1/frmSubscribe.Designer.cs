
namespace Lecture4_Lesson1
{
    partial class frmSubscribe
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtMyName = new System.Windows.Forms.TextBox();
            this.lblMyName = new System.Windows.Forms.Label();
            this.chkSubscribe = new System.Windows.Forms.CheckBox();
            this.lblMyEmail = new System.Windows.Forms.Label();
            this.txtMyEmail = new System.Windows.Forms.TextBox();
            this.cbCountries = new System.Windows.Forms.ComboBox();
            this.lblCountry = new System.Windows.Forms.Label();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(173, 324);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 54);
            this.button1.TabIndex = 0;
            this.button1.Text = "Submit Request";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtMyName
            // 
            this.txtMyName.Location = new System.Drawing.Point(173, 54);
            this.txtMyName.Name = "txtMyName";
            this.txtMyName.Size = new System.Drawing.Size(356, 23);
            this.txtMyName.TabIndex = 1;
            // 
            // lblMyName
            // 
            this.lblMyName.AutoSize = true;
            this.lblMyName.Location = new System.Drawing.Point(46, 57);
            this.lblMyName.Name = "lblMyName";
            this.lblMyName.Size = new System.Drawing.Size(121, 17);
            this.lblMyName.TabIndex = 2;
            this.lblMyName.Text = "Enter your name: ";
            // 
            // chkSubscribe
            // 
            this.chkSubscribe.AutoSize = true;
            this.chkSubscribe.Location = new System.Drawing.Point(173, 263);
            this.chkSubscribe.Name = "chkSubscribe";
            this.chkSubscribe.Size = new System.Drawing.Size(281, 21);
            this.chkSubscribe.TabIndex = 3;
            this.chkSubscribe.Text = "Do you want to subscribe in our journal?";
            this.chkSubscribe.UseVisualStyleBackColor = true;
            // 
            // lblMyEmail
            // 
            this.lblMyEmail.AutoSize = true;
            this.lblMyEmail.Location = new System.Drawing.Point(48, 118);
            this.lblMyEmail.Name = "lblMyEmail";
            this.lblMyEmail.Size = new System.Drawing.Size(119, 17);
            this.lblMyEmail.TabIndex = 4;
            this.lblMyEmail.Text = "Enter your email: ";
            // 
            // txtMyEmail
            // 
            this.txtMyEmail.Location = new System.Drawing.Point(173, 115);
            this.txtMyEmail.Name = "txtMyEmail";
            this.txtMyEmail.Size = new System.Drawing.Size(479, 23);
            this.txtMyEmail.TabIndex = 5;
            // 
            // cbCountries
            // 
            this.cbCountries.FormattingEnabled = true;
            this.cbCountries.Items.AddRange(new object[] {
            "Jordan",
            "Syria",
            "Iraq",
            "Egypt",
            "United Kingdom",
            "United States"});
            this.cbCountries.Location = new System.Drawing.Point(173, 168);
            this.cbCountries.Name = "cbCountries";
            this.cbCountries.Size = new System.Drawing.Size(228, 24);
            this.cbCountries.TabIndex = 6;
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(61, 171);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(106, 17);
            this.lblCountry.TabIndex = 7;
            this.lblCountry.Text = "Select country: ";
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(172, 215);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(72, 21);
            this.rbFemale.TabIndex = 8;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Location = new System.Drawing.Point(247, 215);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(56, 21);
            this.rbMale.TabIndex = 9;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // frmSubscribe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(699, 420);
            this.Controls.Add(this.rbMale);
            this.Controls.Add(this.rbFemale);
            this.Controls.Add(this.lblCountry);
            this.Controls.Add(this.cbCountries);
            this.Controls.Add(this.txtMyEmail);
            this.Controls.Add(this.lblMyEmail);
            this.Controls.Add(this.chkSubscribe);
            this.Controls.Add(this.lblMyName);
            this.Controls.Add(this.txtMyName);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmSubscribe";
            this.Text = "Isra University News Letter Subscription Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtMyName;
        private System.Windows.Forms.Label lblMyName;
        private System.Windows.Forms.CheckBox chkSubscribe;
        private System.Windows.Forms.Label lblMyEmail;
        private System.Windows.Forms.TextBox txtMyEmail;
        private System.Windows.Forms.ComboBox cbCountries;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.RadioButton rbMale;
    }
}

