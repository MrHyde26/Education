using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Education
{
    public class CountInformationInFile
    {
        private const string Path = "C:\\Temp\\UserText.txt";

        public void Execute()
        {
            string text = File.ReadAllText(CountInformationInFile.Path);
            int symbolsAmount = text.Length;

            string[] strings = text.Split('\n');
            int stringsAmount = strings.Length;

            string[] words = text.Split(' ', '\n');
            int wordsAmount = words.Length;

            Console.WriteLine($"Symbols {symbolsAmount},\nStrings {stringsAmount},\nWords {wordsAmount};");
        }
    }
}
