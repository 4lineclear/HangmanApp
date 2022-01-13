using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace HangmanApp
{
    public class ParentButton : Button
    {
        public ParentButton()
        {
            this.Click += new System.EventHandler(ParentButton_Click);
        }
        protected void ParentButton_Click(object sender, EventArgs e)
        {
            ((TreeControl)this.Parent.Parent).TreeParent.BringToFront();
        }
    }
}
