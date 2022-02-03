using HangmanApp.Presenter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HangmanApp.View
{
    public class WordAssistBase : TreeControl
    {
        public WordAssistPresenter Presenter { get; set; }
        public FlowLayoutPanel CorrectLettersPanel;
        public CheckedListBox IncorrectLettersListBox;
        public TextBox CreateNextCorrectTextBox(string letter, EventHandler handler)
        { if (letter == " ")
                letter = "";
            var temp = new TextBox
            {
                Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point),
                Location = new System.Drawing.Point(3, 3),
                MaxLength = 1,
                Name = $"CorrectTextBox{LetterCount + 1}",
                PlaceholderText = $"{ LetterCount + 1 }",
                Size = new System.Drawing.Size(28, 36),
                TabIndex = LetterCount,
                Text = letter
            };
            temp.TextChanged += handler;
            return temp;
        }
        public TextBox CreateNextCorrectTextBox(string letter)
            => this.CreateNextCorrectTextBox(letter, new EventHandler(CorrectTextBox_TextChanged));
        public TextBox CreateNextCorrectTextBox()
            => this.CreateNextCorrectTextBox("");
        public void CorrectTextBox_TextChanged(object sender, EventArgs e)
        {
            var textBox = sender as TextBox;
            if (!textBox.Text.All(chr => char.IsLetter(chr)))
            {
                ((TextBox)sender).Text = "";
                System.Media.SystemSounds.Beep.Play();
            }
        }
        public IEnumerable<string> CorrectLetters
        {
            get
            {
                foreach (TextBox textBox in this.CorrectLettersPanel.Controls)
                {
                    if (textBox.Text == "")
                        yield return " ";
                    else
                        yield return textBox.Text.ToLower();
                }
            }
        }
        public IEnumerable<string> IncorrectLetters
        {
            get
            {
                foreach (string item in this.IncorrectLettersListBox.CheckedItems)
                {
                    yield return item.ToLower();
                }
            }
        }
        public int LetterCount 
        { 
            get 
            { 
                return this.CorrectLetters.Count(); 
            } 
        }
    }
}
