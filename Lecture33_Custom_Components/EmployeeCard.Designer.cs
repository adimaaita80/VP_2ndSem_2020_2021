
namespace Lecture33_Custom_Components
{
    partial class EmployeeCard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtEmployeeName = new System.Windows.Forms.TextBox();
            this.txtEmployeeEmail = new System.Windows.Forms.TextBox();
            this.txtEmployeePhone = new System.Windows.Forms.TextBox();
            this.btnDisplayMessage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::Lecture33_Custom_Components.Properties.Resources.UserPhotoGeneric;
            this.pictureBox1.Location = new System.Drawing.Point(20, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 115);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txtEmployeeName
            // 
            this.txtEmployeeName.Enabled = false;
            this.txtEmployeeName.Location = new System.Drawing.Point(139, 18);
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.Size = new System.Drawing.Size(233, 20);
            this.txtEmployeeName.TabIndex = 1;
            // 
            // txtEmployeeEmail
            // 
            this.txtEmployeeEmail.Enabled = false;
            this.txtEmployeeEmail.Location = new System.Drawing.Point(139, 66);
            this.txtEmployeeEmail.Name = "txtEmployeeEmail";
            this.txtEmployeeEmail.Size = new System.Drawing.Size(233, 20);
            this.txtEmployeeEmail.TabIndex = 2;
            // 
            // txtEmployeePhone
            // 
            this.txtEmployeePhone.Enabled = false;
            this.txtEmployeePhone.Location = new System.Drawing.Point(139, 113);
            this.txtEmployeePhone.Name = "txtEmployeePhone";
            this.txtEmployeePhone.Size = new System.Drawing.Size(233, 20);
            this.txtEmployeePhone.TabIndex = 3;
            // 
            // btnDisplayMessage
            // 
            this.btnDisplayMessage.Location = new System.Drawing.Point(139, 158);
            this.btnDisplayMessage.Name = "btnDisplayMessage";
            this.btnDisplayMessage.Size = new System.Drawing.Size(128, 23);
            this.btnDisplayMessage.TabIndex = 4;
            this.btnDisplayMessage.Text = "Employee Details";
            this.btnDisplayMessage.UseVisualStyleBackColor = true;
            this.btnDisplayMessage.Click += new System.EventHandler(this.btnDisplayMessage_Click);
            // 
            // EmployeeCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.Controls.Add(this.btnDisplayMessage);
            this.Controls.Add(this.txtEmployeePhone);
            this.Controls.Add(this.txtEmployeeEmail);
            this.Controls.Add(this.txtEmployeeName);
            this.Controls.Add(this.pictureBox1);
            this.Name = "EmployeeCard";
            this.Size = new System.Drawing.Size(391, 196);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtEmployeeName;
        private System.Windows.Forms.TextBox txtEmployeeEmail;
        private System.Windows.Forms.TextBox txtEmployeePhone;
        private System.Windows.Forms.Button btnDisplayMessage;
    }
}
