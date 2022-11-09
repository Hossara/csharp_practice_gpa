using System;

namespace csharp_practice_gpa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("=== Student {0} ===", i + 1);

                int sum = 0;

                for (int j = 0; j < 10; j++)
                {
                    Console.Write(">> Lession {0} : ", j + 1);
                    sum += int.Parse(Console.ReadLine());
                }

                Console.WriteLine("----------");
                Console.WriteLine("GPA : {0}", sum / 10);
            }

            Console.ReadKey();
        }
    }
}
