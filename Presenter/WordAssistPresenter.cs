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
            this.WordRepo = wordRepository;
            this.WAMPanel = form.wordAssistMenuPanel1;
            this.WAPanel = form.wordAssistPanel1;
        }

    }
}
