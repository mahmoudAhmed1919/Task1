using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Mahmoud Ahmed Elsherbiny Ahmed ... Section 21 ... Discrete Mathematics Project 1
            Console.WriteLine("Enter two numbers to get the prime numbers between them : ");
            int n1, n2;
            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());

            for (int i = n1; i <= n2; ++i) {
                if (i == 1) continue;
                bool status = true;
                for (int j = i / 2; j >= 2; j--) {
                    if (i % j == 0)
                    {
                        status = false;
                        break;
                    }
                }
                if (status) Console.WriteLine(i);
            }
        }
    }
}
