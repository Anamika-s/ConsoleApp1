using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo2
{
    internal class File2
    {
        static void Main()
        {
            // Take input from user
            // Console.ReadLine()
            // ReadLine() takes input in string form
            // so we need to do conversion
            int x;
            int y;
            Console.WriteLine("Enter value of x");
            x = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Enter value of y");
            y = Convert.ToByte(Console.ReadLine());
            Console.WriteLine($"Sum is {x+y}");
        }
    }
}
