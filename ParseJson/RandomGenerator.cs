using System;
using System.Linq;


namespace ParseJson
{
    class RandomGenerator
    {
        private static Random random = new Random();
        String text = "";
        public static string RandomString(int length, int type)
        {
            string text = string.Empty;
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            const string alpha = "abcdefghijklmnopqrstuvwxyz";
            const string onnum = "0123456789";
            switch (type)
            {
                case 1:
                    text = new string(Enumerable.Repeat(chars, length)
                       .Select(s => s[random.Next(s.Length)]).ToArray());
                    break;
                case 2:
                    text = new string(Enumerable.Repeat(alpha, length)
                       .Select(s => s[random.Next(s.Length)]).ToArray());
                    break;
                case 3:
                    text = new string(Enumerable.Repeat(onnum, length)
                       .Select(s => s[random.Next(s.Length)]).ToArray());
                    break;
            }
            return text;
        }
    }
}
