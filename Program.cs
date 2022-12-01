namespace StringHalvesAlike_LeetCode_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Program program= new Program();
            var x = program.HalvesAreAlike("faaz");
            Console.WriteLine(x);
        }

        public bool HalvesAreAlike(string s)
        {
            var strLen = s.Length;
            var stringHalf = strLen / 2;
            var str1 = 0;
            var str2=0;

            for (int i = 0; i < stringHalf; i++)
            {
                var charInStr= s[i].ToString().ToLower();
                if (charInStr == "a"|| charInStr == "e" || charInStr == "i" || charInStr == "o" || charInStr == "u")
                {
                    str1++;
                }
            }

            for (int i = stringHalf; i < strLen; i++)
            {
                var charInStr = s[i].ToString().ToLower();
                if (charInStr == "a" || charInStr == "e" || charInStr == "i" || charInStr == "o" || charInStr == "u")
                {
                    str2++;
                }
            }

            if (str1 == str2)
            {
                return true;
            }

            return false;
        }
    }
}