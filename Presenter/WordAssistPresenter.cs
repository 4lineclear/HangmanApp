using HangmanApp.Model;
using HangmanApp.View;
using System;
using System.Collections.Generic;
using System.Text;

namespace HangmanApp.Presenter
{
    public class WordAssistPresenter
    {
        private WordRepository WordRepo { get; }
        private WordAssistMenuPanel WAMPanel { get; }
        private WordAssistPanel WAPanel { get; }
        public  WordAssistPresenter(WordRepository wordRepository, MainForm form)
        {
            form.wordAssistMenuPanel1.Presenter = this;
            form.wordAssistPanel1.Presenter = this;
            this.WordRepo = wordRepository;
            this.WAMPanel = form.wordAssistMenuPanel1;
            this.WAPanel = form.wordAssistPanel1;
        }
        public void StartAssist(IEnumerable<string> correctLetters, IEnumerable<string> incorrectLetters)
        {
            WAPanel.StartAssist(correctLetters, incorrectLetters);
        }
        public char GetQualifyingWords(out IEnumerable<string> guesses, IEnumerable<string> correctLetters, IEnumerable<string> incorrectLetters)
            => WordRepo.FindQualifyingWords(out guesses, correctLetters, incorrectLetters);
    }
}
