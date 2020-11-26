using System;

namespace domashno_programirane_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 6;
            int c = 4;
                int d = b * b - 4 * a * c;
            int x1 = (-b + d ^ 1 / 2) / 2;
            int x2 = (-b - d ^ 1 / 2) / 2;
            if (d < 0)
            {
                Console.Write("Nqma realni koreni");
                if (d > 0)
                {
                    Console.WriteLine("x1 = x2" + x1);
                   
                }
                else
                {
                    Console.WriteLine("x1 =" + x1);
                    Console.WriteLine("x2 =" + x2);

                }
            }


        }
    }
}
