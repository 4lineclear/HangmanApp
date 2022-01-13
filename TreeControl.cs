using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HangmanApp
{
    public class TreeControl : UserControl
    {
        [Category("Tree Properties")]
        public TreeControl TreeParent { get; set; }
        [Category("Tree Properties")]
        public Dictionary<ChildButton,TreeControl> TreeChildren { get; set; }
        public TreeControl()
        {
            
        }
        public TreeControl(TreeControl parent, Dictionary<ChildButton, TreeControl> children)
        {
            this.TreeParent = parent;
            this.TreeChildren = children;
        }
        public ChildButton[] AllChildButtons
        {
            get
            {
                return GetReversedListOfButtons().Reverse().ToArray();
            }
        }
        public IEnumerable<ChildButton> GetReversedListOfButtons()
        {
            foreach (Control button in this.MainPanel.Controls)
            {
                if (button.GetType() == typeof(ChildButton))
                    yield return (ChildButton)button;
            }
        }

        protected System.Windows.Forms.TableLayoutPanel MainPanel;

    }
}
