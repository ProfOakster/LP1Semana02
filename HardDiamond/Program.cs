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
                //Cycles through i from (-size/2) to (size/2) 
                for (int i = -1*size/2; i <= size/2; i++)
                {
                    //The # of spaces to write before and after 
                    //the dots is |i|
                    string space = new string(' ', Math.Abs(i));
                    //The # of dots to write is size-|i|
                    string dot = new string('.', size-(Math.Abs(i)*2));
                    //Writes line to console
                    Console.WriteLine(space+dot+space);
                }
            }
        }
    }
}
