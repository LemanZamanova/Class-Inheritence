namespace StringMethodu
{
    internal class RightSentences
    {
        public static string FormatText(string text)
        {
            string[] words = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            return string.Join(" ", words.Select(CapitalizeWord));
        }

        private static string CapitalizeWord(string word)
        {
            if (string.IsNullOrEmpty(word)) return word;
            return char.ToUpper(word[0]) + word.Substring(1).ToLower();
        }
    }
}
