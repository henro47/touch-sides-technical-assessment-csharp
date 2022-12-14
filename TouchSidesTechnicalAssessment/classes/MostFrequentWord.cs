using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics.CodeAnalysis;
using System.CodeDom;
using System.Text.RegularExpressions;

namespace TouchSidesTechnicalAssessment.classes
{
    
    internal class MostFrequentWord
    {
        //Instance variables
        private string path;
        private Dictionary<string, int> words_freq = new Dictionary<string, int>();
        private Dictionary<string, int> words_freq_seven_characters = new Dictionary<string, int>();
        private Dictionary<string, int> words_score = new Dictionary<string, int>();

        //Set method(s)
        private void setPath(string path)
        {
            this.path = path;
        }

        //Get method(s)
        private string getPath()
        {
            return this.path;
        }

        //Constructor
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

        private void regex_line_splitter(string line)
        {
            Regex regex = new Regex("\\w+");

            Match match = regex.Match(line);
            while (match != null)
            {
                string word = match.Value.ToLower().Trim();
                calculate_word_frequency(word);
                calulcate_word_score(word);
            }
        }

        private void calculate_word_frequency(string word)
        {
            if(word.Length != 7)
            {
                if (words_freq.ContainsKey(word))
                {
                    words_freq[word]++;
                }
                else
                {
                    words_freq[word] = 1;
                }
            }
            else
            {
                if (words_freq_seven_characters.ContainsKey(word))
                {
                    words_freq_seven_characters[word]++;
                }
                else
                {
                    words_freq_seven_characters[word] = 1;
                }
            }
        }

        private void calulcate_word_score(string word)
        {
            if (!words_score.ContainsKey(word))
            {
                words_score[word] = calculateWordScore(word);
            }
        }
        
        public Dictionary<string, int> word_with_highest_score()
        {
            Dictionary<string, int> highest_scoring_word = new Dictionary<string, int>();
            string highest_word_score = words_score.OrderByDescending(word => word.Value).First().Key;
            highest_scoring_word[highest_word_score] = words_score[highest_word_score];
            return highest_scoring_word;
        }

        public Dictionary<string, int> most_frequent_word_counted()
        {
            Dictionary<string, int> most_freq_word = new Dictionary<string, int>();
            string most_freq_word_key = words_freq.OrderByDescending(word => word.Value).First().Key;
            most_freq_word[most_freq_word_key] = words_freq[most_freq_word_key];
            return most_freq_word;
        }

        public Dictionary<string, int> most_frequent_seven_char_word_counted()
        {
            Dictionary<string, int> most_freq_word = new Dictionary<string, int>();
            string most_freq_word_key = words_freq_seven_characters.OrderByDescending(word => word.Value).First().Key;
            most_freq_word[most_freq_word_key] = words_freq_seven_characters[most_freq_word_key];
            return most_freq_word;
        }
    }
}
