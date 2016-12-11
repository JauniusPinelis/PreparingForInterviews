using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainClassLibrary
{
    /// <summary>
    /// A class for solving "Implement an algorithm to determine if a string has all unique characters" 
    /// </summary>
    public class AllUniqueCharSolver
    {

        /// <summary>
        /// Returns true if all characters are unique, false otherwise
        /// </summary>
        public bool Solve(string sentence)
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
