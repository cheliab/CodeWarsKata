using System;
using System.Linq;

namespace Kata_7kyu._01
{
    public class VowelCount
    {
        public static void Start()
        {
            Console.WriteLine(GetVowelCount("abracadabra"));
        }
        
        private static char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u' };

        public static int GetVowelCount(string str)
        {
            return str.ToCharArray().Count(c => vowels.Contains(c));
        }

        public static int GetVowelCount_v2(string str)
        {
            return str.Count(c => "aeiou".Contains(c));
        } 
    }
}