namespace Demo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            int y = 20;
            //Console.WriteLine("Addition of {0} and {1} is {2}",
            //    x, y, x + y) ;
            //Console.WriteLine("Difference of {0} and {1} is {2}",
            //    x, y, x - y);
            //Console.WriteLine("Product of {0} and {1} is {2}",
            //    x, y, x * y);
            //Console.WriteLine("Remainder of {0} and {1} is {2}",
            //    x, y, x % y);
            Console.WriteLine($"Addition of {x} and {y} is {x + y}");
            Console.WriteLine($"Difference of {x} and {y} is {x - y}");
            Console.WriteLine($"Product of {x} and {y} is {x * y}");
            Console.WriteLine($"Remainder of {x} and {y} is {x % y}");
        }
    }
}