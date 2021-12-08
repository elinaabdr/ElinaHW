using System;

namespace ConsoleApplication8.HomeWork.HomeWork_08_12_2021
{
    public static class StringExtension
    {
        public static string Addition(this string first, string second)
        {
            if (first == null && second != null)
                return second;
            else if (first != null && second == null)
                return first;

            string[] str = first.Split(' ');
            string[] str2 = second.Split(' ');

            string result = "";

            if (str.Length >= str2.Length)
            {
                for (int i = 0; i < str.Length; i++)
                {
                    result += str[i];
                    if (i+1 < str2.Length)
                        result += str2[i+1];
                }
            }
            else
            {
                for (int i = 1; i < str2.Length; i++)
                {
                    if (i - 1 < str.Length)
                        result += str[i - 1];
                    result += str2[i];
                }
            }
            return result;
        }
    }
}