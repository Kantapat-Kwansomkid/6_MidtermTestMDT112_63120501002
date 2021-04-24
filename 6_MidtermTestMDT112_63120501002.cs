using System;

namespace _6_MidtermTestMDT112_63120501002
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Drawstaircase(n);
        }

        static void Drawstaircase(int n)
        {
            for (int row = 0; row <= n; row++)
            {
                for (int column = 0; column <= n - (row - 0); column++)
                {
                    Console.Write("0");
                }
                Console.WriteLine();
            }
            for (int row = 1; row <= n; row++)
            {
                for (int column = 1; column <= n - (row - 1); column++)
                {
                    Console.Write("X");
                }
                Console.WriteLine();
            }
            for (int row = 2; row <= n; row++)
            {
                for (int column = 2; column <= n - (row - 2); column++)
                {
                    Console.Write("X");
                }
                Console.WriteLine();
            }
            for (int row = 3; row <= n; row++)
            {
                for (int column = 3; column <= n - (row - 3); column++)
                {
                    Console.Write("X");
                }
                Console.WriteLine();
            }
            for (int row = 4; row <= n; row++)
            {
                for (int column = 4; column <= n - (row - 4); column++)
                {
                    Console.Write("X");
                }
                Console.WriteLine();
            }
            for (int row = 5; row <= n; row++)
            {
                for (int column = 5; column <= n - (row - 5); column++)
                {
                    Console.Write("X");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
