using System;
using System.Linq;
using System.Text;

namespace Kata_7kyu._02
{
    public class Accumul
    {
        public static void Start()
        {
            Console.WriteLine(Accum("AbC"));
        }
        
        public static string Accum(string s)
        {
            var result = new StringBuilder();
            s = s.ToLower();
            
            int i = 1;
            bool firstStrBlock = true;
            foreach(var c in s)
            {
                var newStr = new StringBuilder();
                bool firstChar = true;

                newStr.Append('-');
                for (int k = 1; k <= i; k++)
                {
                    if (firstChar)
                    {
                        newStr.Append(char.ToUpper(c));
                        firstChar = false;
                        continue;
                    }
                    
                    newStr.Append(c);
                }

                if (firstStrBlock)
                {
                    newStr.Remove(0, 1);
                    firstStrBlock = false;
                }
                
                result.Append(newStr);
                
                i++;
            }

            return result.ToString();
        }
    }
}