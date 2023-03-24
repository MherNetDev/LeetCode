using System;

namespace LeetCode4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.LongestCommonPrefix(new string[] { "flaas", "flbb", "fldb" });
        }

        public string LongestCommonPrefix(string[] strs)
        {
            string nuyn = "";
            int longest = strs.Max(s => s.Length);

            for (int i = 0; i < strs.Length; i++)
            {
                nuyn += strs[i].ToString()[0];
                if (nuyn == strs[i].ToString()[0].ToString())
                    Console.WriteLine(nuyn);
                else
                    break;
            }


            return null;
        }
    }
}