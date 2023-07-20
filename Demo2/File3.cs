using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo2
{
    internal class File3
    {
        static void Main()
        {// Debug > is used to check program flow step by step
            // to use debug, we shud add breakpoint
            int x;
            int y;
            int ch;
            int ans=0;
            Console.WriteLine("Enter value of x");
            x = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Enter value of y");
            y = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Enter choice");
            ch = Convert.ToByte(Console.ReadLine());
            if (ch == 1)
                ans = x + y;

            else if (ch == 2)
                ans = x - y;
            else if (ch == 3)
                ans = x * y;
            else if (ch == 4)
                ans = x % y;
                Console.WriteLine("Invalid");
            Console.WriteLine("Result is " + ans);

        }
    }
}
