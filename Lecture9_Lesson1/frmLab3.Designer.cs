
namespace Lecture9_Lesson1
{
    partial class frmLab3
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblX = new System.Windows.Forms.Label();
            this.lblY = new System.Windows.Forms.Label();
            this.txtX = new System.Windows.Forms.TextBox();
            this.txtY = new System.Windows.Forms.TextBox();
            this.btnMoveForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(307, 143);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(168, 18);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Move Form to Location";
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(186, 222);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(19, 18);
            this.lblX.TabIndex = 1;
            this.lblX.Text = "X";
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Location = new System.Drawing.Point(189, 292);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(17, 18);
            this.lblY.TabIndex = 2;
            this.lblY.Text = "Y";
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(228, 218);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(340, 26);
            this.txtX.TabIndex = 3;
            // 
            // txtY
            // 
            this.txtY.Location = new System.Drawing.Point(228, 288);
            this.txtY.Name = "txtY";
            this.txtY.Size = new System.Drawing.Size(340, 26);
            this.txtY.TabIndex = 4;
            // 
            // btnMoveForm
            // 
            this.btnMoveForm.ForeColor = System.Drawing.Color.Black;
            this.btnMoveForm.Location = new System.Drawing.Point(317, 377);
            this.btnMoveForm.Name = "btnMoveForm";
            this.btnMoveForm.Size = new System.Drawing.Size(158, 38);
            this.btnMoveForm.TabIndex = 5;
            this.btnMoveForm.Text = "Move Form";
            this.btnMoveForm.UseVisualStyleBackColor = true;
            this.btnMoveForm.Click += new System.EventHandler(this.btnMoveForm_Click);
            // 
            // frmLab3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(831, 529);
            this.Controls.Add(this.btnMoveForm);
            this.Controls.Add(this.txtY);
            this.Controls.Add(this.txtX);
            this.Controls.Add(this.lblY);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Name = "frmLab3";
            this.Text = "Moving App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.TextBox txtY;
        private System.Windows.Forms.Button btnMoveForm;
    }
}