using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringProblem
{
    public class StringReverse
    {
        public string ReverseOnlyLetters(string S)
        {
            if (string.IsNullOrEmpty(S)) throw new ArgumentNullException(nameof(S));
            S = S.Trim();
            int start = 0;
            int end = S.Length - 1;
            char[] sCharArray = S.ToCharArray();

            while (start < end)
            {
                if (Char.IsLetter(sCharArray[start]) && Char.IsLetter(sCharArray[end]))
                {
                    char temp = sCharArray[start];
                    sCharArray[start] = sCharArray[end];
                    sCharArray[end] = temp;
                    start++;
                    end--;
                }
                if (!Char.IsLetter(sCharArray[start]))
                {
                    start++;
                }

                if (!Char.IsLetter(sCharArray[end]))
                {
                    end--;
                }
            }

            return new string(sCharArray);
        }
    }
}
