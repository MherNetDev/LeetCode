namespace LeetCode3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Program program = new Program();
            // program.RomanToInt("MCMXCIV");//1600 11
            Console.WriteLine(program.RomanToInt("MCMXCIV"));

        }

        public int RomanToInt(string s)
        {
            //Dictionary<char, int> Rome = new Dictionary<char, int>()
            //{
            //    { 'I', 1},
            //    { 'V', 5},
            //    { 'X', 10},
            //    { 'L', 50},
            //    { 'C', 100},
            //    { 'D', 500},
            //    { 'M', 1000}
            //};

            //char[] chars= s.ToCharArray();
            //int sum=0;
            //foreach (var item in chars)
            //    sum = sum + Rome[item];
            //Console.WriteLine(sum);
            //return sum;

            var map = new Dictionary<char, int>();
            map.Add('I', 1);
            map.Add('V', 5);
            map.Add('X', 10);
            map.Add('L', 50);
            map.Add('C', 100);
            map.Add('D', 500);
            map.Add('M', 1000);
            int sum = 0;
            int last = 0;
            for (int i = s.Length - 1; i >= 0; i--)
            {
                int current = map[s[i]];
                if (current < last)
                    sum = sum - current;
                else
                    sum = sum + current;


                last = current;
            }
            return sum;





            //switch (c)
            //{
            //    case 'I': return 1;
            //    case 'V': return 5;
            //    case 'X': return 10;
            //    case 'L': return 50;
            //    case 'C': return 100;
            //    case 'D': return 500;
            //    case 'M': return 1000;
            //};
        }
    }
}