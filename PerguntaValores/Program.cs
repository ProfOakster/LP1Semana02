using System;

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

<<<<<<< HEAD
            float v = Math.PI * Math.Pow(r,2) * a;
            float sa = 2 * Math.PI * r * (r + a);
=======
            float v = 3.1415926f * r * r * a;
            float sa = 2 * 3.1415926f * r * (r + a);
>>>>>>> fd0c272946e10dc0d6eff4767bc0616f374aee05

            Console.WriteLine(
                $"Cylinder volume is {v}.\nCylinder surface area is {sa}."
                );
        }
    }
}
