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
        public TreeControl TreeParent { get; private set; }
        [Category("Tree Properties")]
        public Dictionary<ChildButton,TreeControl> TreeChildren { get; }
        public TreeControl()
        {
            TreeChildren = new Dictionary<ChildButton, TreeControl>();
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
        public void AddChild(ChildButton button, TreeControl child)
        {
            this.TreeChildren.Add(button, child);
            child.SetParent(this);
        }
        private void SetParent(TreeControl parent)
        {
            this.TreeParent = parent;
        }
        protected System.Windows.Forms.TableLayoutPanel MainPanel;

    }
}
