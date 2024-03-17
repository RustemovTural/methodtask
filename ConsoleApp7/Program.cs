namespace ConsoleApp7
{
    internal class Program
    {//a
        public static int Cevresahe(int p , int r)
        {
            return p * r * r;
        }
        //b
        public static int Duzbucaqsahe( int a ,int b)
        {
            return a*b;
        }
        //c
        public static int Duzpartamsetsahe(int a ,int b , int c)
        {
        return 2*(a*c+a*b+b*c);
        }
        public static int ucdaxcekcevsahe(int a ,int b,int c, int r)
        {
            int p = (a + b + c) / 2;
            return p * r;
        
        
        
        }
        
        static void Main(string[] args)
        {
            int p = 3;
                int r = 2;
            Console.WriteLine(Cevresahe(p,r));
            int a = 5;
            int b = 4;
            Console.WriteLine(Duzbucaqsahe(a,b));
            int c = 3;
            Console.WriteLine(Duzpartamsetsahe(a,b,c));
            Console.WriteLine(ucdaxcekcevsahe(a ,b,c,r));
        }
    }
}
