using HangmanApp.Presenter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace HangmanApp.View
{
    public partial class WordAssistPanel : WordAssistBase
    { 
        public WordAssistPanel()
        {
            InitializeComponent();
            base.CorrectLettersPanel = this.CorrectLettersPanel;
            base.IncorrectLettersListBox = this.IncorrectLettersListBox;
        }
        public void StartAssist(IEnumerable<string> correctLetters, IEnumerable<string> incorrectLetters)
        {
            CreateTextBoxs(correctLetters);
            SetIncorrectLetters(incorrectLetters);
            AddPotentialWords();
        }
        private void AddPotentialWords()
        {
            //int letterSize = word.Length * 35;
            this.WordGuessesListView.Items.Clear();
            IEnumerable<string> guesses;
            char BestGuess = Presenter.GetQualifyingWords( out guesses, CorrectLetters, IncorrectLetters);
            NextGuessLabel.Text = $"Recommended Next Guess: {char.ToUpper(BestGuess)}";
            int count = 0;
            foreach (string word in guesses)
            {
                count++;
                this.WordGuessesListView.Items.Add(
                    new ListViewItem
                    {
                        Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point),
                        Text = word
                    });
            }
            WordGuessesLabel.Text = $"Guesses: {count}";
        }
        private void CreateTextBoxs(IEnumerable<string> correctLetters)
        {
            this.CorrectLettersPanel.Controls.Clear();
            foreach (string letter in correctLetters)
            {
                this.CorrectLettersPanel.Controls.Add(CreateNextCorrectTextBox(letter, this.CorrectTextBox_TextChanged));
            }
        }

        private void GuessesListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (WordGuessesListView.SelectedItems.Count != 0)
            {
                string searchValue = WordGuessesListView.Items[WordGuessesListView.SelectedIndices[0]].Text;
                OpenUrl("http://www.google.com/search?q=define+"+searchValue);
            }
        }
        //from SO: https://stackoverflow.com/a/43232486/15847822
        private void OpenUrl(string url)
        {
            try
            {
                Process.Start(url);
            }
            catch
            {
                // hack because of this: https://github.com/dotnet/corefx/issues/10361
                if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                {
                    url = url.Replace("&", "^&");
                    Process.Start(new ProcessStartInfo("cmd", $"/c start {url}") { CreateNoWindow = true });
                }
                else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
                {
                    Process.Start("xdg-open", url);
                }
                else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
                {
                    Process.Start("open", url);
                }
                else
                {
                    throw;
                }
            }
        }

        private void SetIncorrectLetters(IEnumerable<string> incorrectLetters)
        {
            for(int i = 0;i < 25; i++)
            {
                IncorrectLettersListBox.SetItemChecked(i, false);
            }
            foreach (string letter in incorrectLetters)
            {
                IncorrectLettersListBox.SetItemChecked(char.ToUpper(letter[0]) - 65, true);
            }
        }

        public new void CorrectTextBox_TextChanged(object sender, EventArgs e)
        {
            var textBox = sender as TextBox;
            if (!textBox.Text.All(chr => char.IsLetter(chr)))
            {
                ((TextBox)sender).Text = "";
                System.Media.SystemSounds.Beep.Play();
            }
            AddPotentialWords();
        }

        private void IncorrectLettersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            AddPotentialWords();
            IncorrectLettersListBox.ClearSelected();
        }
    }
}
