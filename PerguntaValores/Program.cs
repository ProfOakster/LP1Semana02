﻿using System;

namespace PerguntaValores
{
    class Program
    {
        static void Main(string[] args)
        {
            float a, r;
            
            Console.WriteLine("Input cylinder height:");
            string inp = Console.ReadLine();
            a = float.Parse(inp);

            Console.WriteLine("Input cylinder radius:");
            inp = Console.ReadLine();
            r = float.Parse(inp);

            float v = 3.1415926f * r * r * a;
            float sa = 2 * 3.1415926f * r * (r + a);

            Console.WriteLine(
                $"Cylinder volume is {v}.\nCylinder surface area is {sa}."
                );
        }
    }
}
