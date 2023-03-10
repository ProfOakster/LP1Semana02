using System;

namespace HardDiamond
{
    class Program
    {
        static void Main(string[] args)
        {
            //Stores argument in int variable
            int size = int.Parse(args[0]);

            //Displays message if size not an odd number
            if (size % 2 == 0)
            {
                Console.WriteLine("I only want odd numbers!");
            }
            else
            {
                for (int i = -1*size/2; i <= size/2; i++)
                {
                    string space = new string(' ', Math.Abs(i));
                    string dot = new string('.', Math.Abs(size)-(Math.Abs(i)*2));
                    Console.WriteLine(space+dot+space);
                }





            }




            
        }
    }
}
