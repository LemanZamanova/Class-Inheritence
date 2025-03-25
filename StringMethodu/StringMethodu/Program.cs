namespace StringMethodu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "        Menə lazIm olan hər şeY bir   fiNcan qəhvədir     ";
            string formattedText = RightSentences.FormatText(input);
            Console.WriteLine(formattedText);


        }
    }
}
