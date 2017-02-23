using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbbreviationPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            string longString = "hello world my user-name is bonifs1";
            int longStringLength = longString.Length;
            char whiteSpace = ' ';
            char hyphen = '-';
            int index = 0;

            // list to store all indexes of white space
            List<int> specialIndexes = new List<int>();

            for (int i = 0; i < longStringLength; i++)
            {
                if (longString[i].Equals(whiteSpace) || longString[i].Equals(hyphen))
                {
                    specialIndexes.Add(i);
                }
            }

            List<string> abbrevWords = new List<string>();

            int counter = 0;
            int lastWordCount = longStringLength - specialIndexes[specialIndexes.Count - 1];

            foreach (int specialIndex in specialIndexes)
            {
                if (specialIndex == specialIndexes[0])
                {
                    abbrevWords.Add(longString.Substring(0, specialIndex));
                }
                else if (specialIndex != specialIndexes[0] && specialIndex != specialIndexes[specialIndexes.Count - 1])
                {
                    int charLengthCalc = specialIndexes[counter+1] - specialIndex;
                    abbrevWords.Add(longString.Substring(specialIndex, charLengthCalc));
                }
                else if (specialIndex == specialIndexes[specialIndexes.Count - 1])
                {
                    abbrevWords.Add(longString.Substring(specialIndex, lastWordCount));
                }
                counter++;
            }

            foreach(string word in abbrevWords)
            {
                Console.WriteLine(word);
            }
        }
    }
}
