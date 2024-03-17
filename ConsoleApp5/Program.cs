namespace ConsoleApp5
{
    internal class Program
    {public static int Sum(int num1, int num2)
        {
            return num1 + num2;

        }public static int cixma (int num1, int num2)
        {
            return (num1 - num2);
        }public static int vurma(int num1, int num2)
        {
            return (num1 * num2);
        } public static int bolme(int num1, int num2)
        {
            return (num1 / num2);
        }
        static void Main(string[] args)
        {
            int a = 100;
            int b = 10;
            
            Console.WriteLine(Sum(a,b));
            Console.WriteLine(cixma(a,b));
            Console.WriteLine(bolme(a,b));
            Console.WriteLine(vurma(a,b));
        }
    }
}
