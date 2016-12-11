using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainClassLibrary.StringSolvers
{
    class ReverseStringSolver
    {
        public string ReverseString(string input)
        {
            var reversedString = "";

            for (int i = input.Length; i > 0; i--)
            {
                reversedString += input[i];
            }
            return reversedString;
        }
    }
}
