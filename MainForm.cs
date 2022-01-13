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
            Dictionary<ChildButton, TreeControl> MainMenuChildren = new Dictionary<ChildButton, TreeControl>();
            Button[] buttons = mainMenuPanel1.AllChildButtons;
            for (int i = 0; i < buttons.Length; i++)
            {
                MainMenuChildren.Add((ChildButton)buttons[i], (TreeControl)this.Controls[i+1]);
            }
            this.mainMenuPanel1.TreeChildren = MainMenuChildren;
        }
        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
