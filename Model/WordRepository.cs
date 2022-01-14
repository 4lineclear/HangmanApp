using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace HangmanApp.Model
{

    public class WordRepository
    {
        private string WordFilePath { get; set; }
        public WordRepository()
        {
            this.WordFilePath = 
                $@"{
                    Directory
                    .GetParent(Environment
                        .CurrentDirectory)
                    .Parent
                        .Parent
                            .FullName
                }\Model\WordRepository";
        }
        public IEnumerable<string> FindWords(int fileNum, char[] find)
        {
            return this.FindWords(fileNum, new string(find));
        }
        public IEnumerable<string> FindWords(int fileNum, string find)
        {
            using (StreamReader reader = new StreamReader($@"{WordFilePath}{fileNum}.txt"))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (AuthenticateWord(line, find))
                        yield return line;
                }
            }
        }
        bool AuthenticateWord(string word, string find)
        {
            for (int i = 0; i < find.Length; i++)
            {
                if (word[i] != find[i] && find[i] != ' ')
                {
                    return false;
                }
            }
            return true;
        }
    }
}
