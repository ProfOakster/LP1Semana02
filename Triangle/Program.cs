using System;

namespace Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(args[0]);
            char block = char.Parse(args[1]);
            string line;

            for (int i = 1; i <= lines; i++)
            {
                line = string.Empty;

                for (int k = 1; k <= i; k++)
                {
                    line += block;
                }

                Console.WriteLine(line);
            }

            
        }
    }
}
