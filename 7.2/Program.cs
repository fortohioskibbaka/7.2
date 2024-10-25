using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("what would u like em to count to");
            Console.WriteLine(": ");
            String message = Console.ReadLine();
            for (int i = 1; i <= 5; i = i + 1)
            {
                Console.WriteLine(i + ". " + message);
            }
            Console.ReadLine();

        }
    }
}
