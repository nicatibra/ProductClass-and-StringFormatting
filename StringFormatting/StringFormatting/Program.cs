namespace StringFormatting
{
    public class Program
    {
        static void Main(string[] args)
        {
            string sentence = "       EverytHing  i neeD,    is a CuP   of       CoFFee   ";

            Console.WriteLine($"Formatted sentence: {FormatSentence(sentence)}");
        }

        public static string FormatSentence(string sentence)
        {
            string result = "";
            bool isPreviousSpace = false;

            for (int i = 0; i < sentence.Length; i++)
            {
                char c = sentence[i];

                if (c == ' ')
                {
                    if (!isPreviousSpace)
                    {
                        result += ' ';
                        isPreviousSpace = true;
                    }
                }
                else
                {
                    result += c;
                    isPreviousSpace = false;
                }
            }

            string[] words = result.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length > 0)
                {
                    words[i] = char.ToUpper(words[i][0]) + words[i].Substring(1).ToLower();
                }
            }

            return string.Join(" ", words).Trim();
        }
    }
}
