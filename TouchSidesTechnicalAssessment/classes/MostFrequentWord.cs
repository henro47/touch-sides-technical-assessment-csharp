using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics.CodeAnalysis;
using System.CodeDom;

namespace TouchSidesTechnicalAssessment.classes
{
    
    internal class MostFrequentWord
    {
        private string path;
        private void setPath(string path)
        {
            this.path = path;
        }

        private string getPath()
        {
            return this.path;
        }
        public MostFrequentWord(string file_path)
        {
            setPath(file_path);
        }
        
        private int calculateWordScore(string word)
        {
            int score = 0;
            for(int i=0; i<word.Length; i++)
            {
                score += getLetterScore(word[i]);
            }

            return score;
        }

        private int getLetterScore(char letter)
        {
            int letter_score = 0;
            switch (letter)
            {
                case 'a':
                    letter_score = 1;
                    break;
                case 'b': 
                    letter_score = 3;
                    break;
                case 'c':
                    letter_score = 3;
                    break;
                case 'd':
                    letter_score = 2;
                    break;
                case 'e':
                    letter_score = 1;
                    break;
                case 'f':
                    letter_score = 4;
                    break;
                case 'g':
                    letter_score = 2;
                    break;
                case 'h':
                    letter_score = 4;
                    break;
                case 'i':
                    letter_score = 1;
                    break;
                case 'j':
                    letter_score = 8;
                    break;
                case 'k':
                    letter_score = 5;
                    break;
                case 'l':
                    letter_score = 1;
                    break;
                case 'm':
                    letter_score = 3;
                    break;
                case 'n':
                    letter_score = 1;
                    break;
                case 'o':
                    letter_score = 1;
                    break;
                case 'p':
                    letter_score = 3;
                    break;
                case 'q':
                    letter_score = 10;
                    break;
                case 'r':
                    letter_score = 1;
                    break;
                case 'u':
                    letter_score = 1;
                    break;
                case 'v':
                    letter_score = 4;
                    break;
                case 'w':
                    letter_score = 4;
                    break;
                case 'x':
                    letter_score = 8;
                    break;
                case 'y':
                    letter_score = 4;
                    break;
                case 'z':
                    letter_score = 10;
                    break;
                default:
                    letter_score = 0;
                    break;
            }

            return letter_score;
        }



    }
}
