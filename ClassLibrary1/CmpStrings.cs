using System;

namespace ClassLibrary1
{
    public class CmpStrings
    {
        static int _max = 256;

        static bool ComparingStr(string str1, string str2)
        {
            int[] count = new int[_max];
            for (int i = 0; i < str1.Length; i++)
                count[str1[i]]++;

            for (int i = 0; i < str2.Length; i++)
            {
                if (count[str2[i]] == 0)
                    return false;
                count[str2[i]]--;
            }

            return true;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Enter 1st string: ");
            string str1 = Console.ReadLine();
            Console.WriteLine("Enter 2nd string: ");
            string str2 = Console.ReadLine();
            if (ComparingStr(str1, str2))
                Console.WriteLine("True");
            else
                Console.WriteLine("False");
        }
    }
}