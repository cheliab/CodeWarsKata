using System;
using System.Linq;

namespace ArrayKata
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FindNeedle(new object[] { 1, null, "asdasd", "needle" }));
            Console.WriteLine(FindNeedleV2(new object[] { 1, null, "asdasd", "needle" }));
            Console.WriteLine(FindNeedleV3(new object[] { 1, null, "asdasd", "needle" }));
            
            Console.ReadLine();
        }

        #region FindNeedle

        public static string FindNeedle(object[] haystack)
        {
            int indexNeedle = Array.IndexOf(haystack, "needle");
            return $"found the needle at position {indexNeedle}";
        }

        public static string FindNeedleV2(object[] haystack)
        {
            int i = 0;
            while (!ReferenceEquals(haystack[i], "needle"))
            {
                i++;
            }

            return $"found the needle at position {i}";
        }

        public static string FindNeedleV3(object[] haystack)
        {
            return $"found the needle at postion {haystack.ToList().IndexOf("needle")}";
        }

        #endregion
    }
}