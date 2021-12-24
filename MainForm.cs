using System;
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
        Panel[] panels = new Panel[2];
        public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            this.panels[0] = this.MainMenuPanel;
            this.panels[1] = this.GamemodePanel;
        }
        
        #region MainMenu Panel EventHandlers
        private void MMP_PlayButton_Click(object sender, EventArgs e)
        {
            this.panels[1].BringToFront();
        }

        private void MMP_WordGuesserButton_Click(object sender, EventArgs e)
        {

        }

        private void MMP_HelpButton_Click(object sender, EventArgs e)
        {

        }

        private void MMP_OptionsButton_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region Gamemode Panel EventHandlers
        private void GP_BackButton_Click(object sender, EventArgs e)
        {
            this.panels[0].BringToFront();
        }

        private void GP_SingeplayerButton_Click(object sender, EventArgs e)
        {

        }

        private void GP_MultiplayerButton_Click(object sender, EventArgs e)
        {

        }

        private void GP_LocalNetworkButton_Click(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
