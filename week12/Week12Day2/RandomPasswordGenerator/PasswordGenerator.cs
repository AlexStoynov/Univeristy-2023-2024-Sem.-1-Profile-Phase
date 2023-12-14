using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomPasswordGenerator
{
    public class PasswordGenerator
    {
        public static List<string> GeneratePasswords(int length, int count, bool includeSymbols)
        {
            List<string> passwords = new List<string>();
            StringBuilder res = new StringBuilder();
            Random rnd = new Random();

            for (int i = 0; i < count; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    if (includeSymbols)
                    {
                        res.Append((char)rnd.Next(33, 127));
                    }
                    else
                    {
                        res.Append((char)rnd.Next(65, 122));
                    }
                    
                }
                passwords.Add(res.ToString());
                res.Clear();
            }

            return passwords;
        }
    }
}
