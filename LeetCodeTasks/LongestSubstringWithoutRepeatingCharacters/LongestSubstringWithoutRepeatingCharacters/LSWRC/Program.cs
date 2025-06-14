namespace LSWRC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "abcabcbb";
            int length = LengthOfLongestSubstring(s);
            Console.WriteLine(length);
        }

        public static int LengthOfLongestSubstring(string s)
        {
            int length = 0;
            List<char> substring = new List<char>();

            for (int i = 0; i < s.Length; i++)
            {
                char currentChar = s[i];
                if (substring.Contains(currentChar))
                {
                    int index = substring.IndexOf(currentChar);
                    substring.RemoveRange(0, index + 1);
                }

                substring.Add(currentChar);
                length = Math.Max(length, substring.Count);
            }

            return length;
        }
    }
}
