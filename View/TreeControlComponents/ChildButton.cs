using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace HangmanApp
{
    public class ChildButton : Button
    {
        public ChildButton()
        {
            this.Click += new System.EventHandler(ChildButton_Click);
        }
        protected void ChildButton_Click(object sender, EventArgs e)
        {
            ((TreeControl)this.Parent.Parent).TreeChildren[this].BringToFront();
        }
    }
}
