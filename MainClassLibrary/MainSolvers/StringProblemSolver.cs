using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainClassLibrary.MainSolvers
{
    public class StringProblemSolver
    {
        /// <summary>
        /// Reverses a string
        /// </summary>
        public string ReverseString(string input)
        {
            var reversedString = "";

            for (int i = input.Length-1; i >= 0; i--)
            {
                reversedString += input[i];
            }
            return reversedString;
        }

        /// <summary>
        /// Check if all chars in the sentence are unique
        /// </summary>
        public bool CheckIfAllCharsAreUnique(string sentence)
        {
            string existingChars = "";
            foreach (char chr in sentence)
            {
                if (existingChars.Contains(chr) && chr != ' ')
                    return false;
                else
                    existingChars += chr;
            }
            return true;
        }


        /// <summary>
        /// DOES NOT WORK - FIX LATER ON
        /// Remove dublicate characters from a string 
        /// without using additional buffer
        /// 
        /// </summary>
        public string RemoveDublicateCharacters(string input)
        {
            if (input.Length == 0)
                return input;
            int len = input.Length;
            if (len < 2)
                return input;
            int tail = 1;

            var sentence = input.ToCharArray();

            for (int i = 1; i < len; ++i)
            {
                int j;

                for (j = 0; j < tail; ++j)
                {
                    if (sentence[i] == sentence[j])
                        break;
                }

                if (j == tail)
                {
                    sentence[tail] = sentence[i];
                    ++tail;
                }
            }
            return sentence.ToString();
        }
    }
}
