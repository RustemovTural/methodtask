namespace ConsoleApp4
{
    internal class Program
    {
        public static string sumstringarray(string arr) 
        {
            string bitisiksoz = "";
           
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != ' ') 
                {
                    bitisiksoz += arr[i];
                }
            }
            return (bitisiksoz);
        
        
        }
        static void Main(string[] args)
        {
            
            Console.WriteLine(sumstringarray("tural rustemov cebrayil "));


        }
    }
}
