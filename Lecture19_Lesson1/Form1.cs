using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lecture19_Lesson1
{
    public partial class frmAdmin : Form
    {
        public frmAdmin()
        {
            InitializeComponent();
        }

        private void treeViewNavigation_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if(treeViewNavigation.SelectedNode.Name == "Node1")
            {
                tabControlPages.SelectedIndex = 0;
            }
            else if(treeViewNavigation.SelectedNode.Name == "Node2")
            {
                tabControlPages.SelectedIndex = 1;
            }
            else if(treeViewNavigation.SelectedNode.Name == "Node3")
            {
                tabControlPages.SelectedIndex = 2;
            }
        }
    }
}
