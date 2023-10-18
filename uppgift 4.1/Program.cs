using System;
using System.Diagnostics;

namespace uppggift_4_1
{
    class program
    {
        static void Main(string[] args)
        {
            int tal = 10;
            while (tal <= 30)
            {
                Console.WriteLine(tal);
                tal++;
            }
            int tal2 = 200;
            while (tal2 >= 180)
            {
                Console.WriteLine(tal2);
                tal2--;
            }
            int tal3 = 1000;
            while (tal3 <= 1400)
            {
                Console.WriteLine(tal3);
                tal3+=50;
            }
            Console.ReadKey();
        }
    }
}