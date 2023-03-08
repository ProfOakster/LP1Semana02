using System;

namespace ManipulaVar
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(args[0]);
            int x1 = x;
            int x2 = x;
            
            x1++;
            --x2;

            Console.WriteLine(x1);
            Console.WriteLine(x2);
            
        }
    }
}
