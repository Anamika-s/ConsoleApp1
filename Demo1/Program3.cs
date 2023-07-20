using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1
{
      class Program3
    {
        
        static void Main()
        {
            string name = "Deepak";
            int age = 20;
            Console.WriteLine("Your name is " + name);
            Console.WriteLine("Your age is " + age);
            Console.WriteLine("Your name is {0}\nYour age is {1}", name,age);
            //printf("%s %d", name, age)
            Console.WriteLine($"Your name is {name}\nYour age is {age}");

        }
    }
}
