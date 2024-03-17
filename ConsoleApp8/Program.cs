namespace ConsoleApp8
{
    internal class Program
    {
        public static void Firstletter(string sentence)
        {
            char letter = ' ';
            for (int i = 0; i < sentence.Length; i++)
            {
                if (letter == ' ')
                {
                    Console.WriteLine(sentence[i]);
                }
                letter = sentence[i];
            }

        }
        static void Main(string[] args)
        {
            string sentence = " hello world";
            Firstletter(sentence);
        }
    }
}
    

