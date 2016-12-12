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
    }
}
