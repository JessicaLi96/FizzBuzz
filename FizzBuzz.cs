using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 101; i++)
            {
                //Console.WriteLine("initial number =  " + i);
                if (i % 3 == 0 && i % 5 != 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0 && i % 3 != 0)
                {
                    Console.WriteLine("Buzz");

                }
                else if (i % 5 == 0 && i % 3 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else { Console.WriteLine(i); }

                //hello 
            }
            Console.ReadLine();
        }
    }
}
