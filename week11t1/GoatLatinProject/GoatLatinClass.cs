using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoatLatinProject
{
    public class GoatLatinClass
    {
        public string ToGoatLatin(string S)
        {
            if (string.IsNullOrWhiteSpace(S))
                throw new ArgumentException("Value cannot be null or whitespace.", nameof(S));
            var words = S.Split(' ');
            StringBuilder sb = new StringBuilder();
            int count = 0;
            foreach (string w in words)
            {
                count++;
                if (
                    w[0] == 'a' || w[0] == 'e' || w[0] == 'i' || w[0] == 'o' || w[0] == 'u' ||
                    w[0] == 'A' || w[0] == 'E' || w[0] == 'I' || w[0] == 'O' || w[0] == 'U'
                )
                {
                    sb.Append(w);
                }
                else
                {
                    for (int i = 1; i < w.Length; i++)
                        sb.Append(w[i]);
                    sb.Append(w[0]);
                }
                sb.Append("ma");

                for (int i = 0; i < count; i++)
                    sb.Append('a');
                if (count < words.Length)
                    sb.Append(' ');
            }

            Console.WriteLine(sb.ToString());
            return sb.ToString();
        }

    }
}