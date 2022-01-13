using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HangmanApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            AddChildrenComponents(mainMenuPanel1, new TreeControl[] {
                gamemodeMenuPanel1, 
                wordAssistMenuPanel1, 
                helpPagePanel1, 
                optionsMenuPanel1
            });
        }
        private void AddChildrenComponents(TreeControl treeControl, TreeControl[] children)
        {
            for (int i = 0; i < treeControl.AllChildButtons.Length; i++)
            {
                treeControl.AddChild((ChildButton)treeControl.AllChildButtons[i], (TreeControl)children[i]);
            }

        }
        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
