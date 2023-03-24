namespace LeetCode2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            Console.WriteLine(program.IsPalindrome(121));
        }

        public bool IsPalindrome(int x)
        {
            string xs = x.ToString();

            char[] charArray = xs.ToCharArray();
            Array.Reverse(charArray);
            string xs1 = new string(charArray);
            if (xs == xs1)
                return true;
            else
                return false;


            //string first = x.ToString();             //turn to string (easy to reverse)
            //char[] charArr = first.ToCharArray();   //the original target
            //char[] reverseArr = first.ToCharArray();

            //Array.Reverse(reverseArr);

            //return charArr.SequenceEqual(reverseArr); //compare two array
        }
    }
}