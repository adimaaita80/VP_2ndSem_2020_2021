
namespace Lecture19_Lesson1
{
    partial class frmAdmin
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("My Profile");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Employee Records");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("System Navigation", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            this.panelNavigation = new System.Windows.Forms.Panel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.lblLogo = new System.Windows.Forms.Label();
            this.treeViewNavigation = new System.Windows.Forms.TreeView();
            this.tabControlPages = new System.Windows.Forms.TabControl();
            this.tabPageProfile = new System.Windows.Forms.TabPage();
            this.tabPageEmployeeRecords = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelNavigation.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.tabControlPages.SuspendLayout();
            this.tabPageProfile.SuspendLayout();
            this.tabPageEmployeeRecords.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelNavigation
            // 
            this.panelNavigation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(61)))), ((int)(((byte)(99)))));
            this.panelNavigation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelNavigation.Controls.Add(this.treeViewNavigation);
            this.panelNavigation.Controls.Add(this.panelLogo);
            this.panelNavigation.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelNavigation.Location = new System.Drawing.Point(0, 0);
            this.panelNavigation.Name = "panelNavigation";
            this.panelNavigation.Size = new System.Drawing.Size(257, 808);
            this.panelNavigation.TabIndex = 0;
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(36)))), ((int)(((byte)(59)))));
            this.panelLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelLogo.Controls.Add(this.lblLogo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(255, 102);
            this.panelLogo.TabIndex = 0;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(61)))), ((int)(((byte)(99)))));
            this.panelHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(257, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(990, 103);
            this.panelHeader.TabIndex = 1;
            // 
            // panelFooter
            // 
            this.panelFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(61)))), ((int)(((byte)(99)))));
            this.panelFooter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(257, 763);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(990, 45);
            this.panelFooter.TabIndex = 2;
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogo.ForeColor = System.Drawing.Color.White;
            this.lblLogo.Location = new System.Drawing.Point(69, 34);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(100, 25);
            this.lblLogo.TabIndex = 0;
            this.lblLogo.Text = "My Logo";
            // 
            // treeViewNavigation
            // 
            this.treeViewNavigation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(61)))), ((int)(((byte)(99)))));
            this.treeViewNavigation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewNavigation.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeViewNavigation.ForeColor = System.Drawing.Color.White;
            this.treeViewNavigation.Location = new System.Drawing.Point(0, 102);
            this.treeViewNavigation.Name = "treeViewNavigation";
            treeNode1.Name = "Node1";
            treeNode1.Text = "My Profile";
            treeNode2.Name = "Node2";
            treeNode2.Text = "Employee Records";
            treeNode3.Name = "Node0";
            treeNode3.Text = "System Navigation";
            this.treeViewNavigation.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3});
            this.treeViewNavigation.Size = new System.Drawing.Size(255, 704);
            this.treeViewNavigation.TabIndex = 1;
            this.treeViewNavigation.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewNavigation_AfterSelect);
            // 
            // tabControlPages
            // 
            this.tabControlPages.Controls.Add(this.tabPageProfile);
            this.tabControlPages.Controls.Add(this.tabPageEmployeeRecords);
            this.tabControlPages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPages.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlPages.Location = new System.Drawing.Point(257, 103);
            this.tabControlPages.Name = "tabControlPages";
            this.tabControlPages.SelectedIndex = 0;
            this.tabControlPages.Size = new System.Drawing.Size(990, 660);
            this.tabControlPages.TabIndex = 3;
            // 
            // tabPageProfile
            // 
            this.tabPageProfile.Controls.Add(this.label1);
            this.tabPageProfile.Location = new System.Drawing.Point(4, 28);
            this.tabPageProfile.Name = "tabPageProfile";
            this.tabPageProfile.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageProfile.Size = new System.Drawing.Size(982, 628);
            this.tabPageProfile.TabIndex = 0;
            this.tabPageProfile.Text = "My Profile";
            this.tabPageProfile.UseVisualStyleBackColor = true;
            // 
            // tabPageEmployeeRecords
            // 
            this.tabPageEmployeeRecords.Controls.Add(this.label2);
            this.tabPageEmployeeRecords.Location = new System.Drawing.Point(4, 28);
            this.tabPageEmployeeRecords.Name = "tabPageEmployeeRecords";
            this.tabPageEmployeeRecords.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEmployeeRecords.Size = new System.Drawing.Size(982, 628);
            this.tabPageEmployeeRecords.TabIndex = 1;
            this.tabPageEmployeeRecords.Text = "Employee Records";
            this.tabPageEmployeeRecords.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "This is the user profile";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(251, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "This is the employee records page";
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1247, 808);
            this.Controls.Add(this.tabControlPages);
            this.Controls.Add(this.panelFooter);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelNavigation);
            this.Name = "frmAdmin";
            this.Text = "System Administration";
            this.panelNavigation.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.tabControlPages.ResumeLayout(false);
            this.tabPageProfile.ResumeLayout(false);
            this.tabPageProfile.PerformLayout();
            this.tabPageEmployeeRecords.ResumeLayout(false);
            this.tabPageEmployeeRecords.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelNavigation;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.TreeView treeViewNavigation;
        private System.Windows.Forms.TabControl tabControlPages;
        private System.Windows.Forms.TabPage tabPageProfile;
        private System.Windows.Forms.TabPage tabPageEmployeeRecords;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

