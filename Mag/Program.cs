using System;
using System.Collections.Generic;

namespace Mag
{
    class Program
    {
        static void Main(string[] args)
        {
           
            
            foreach (var item in listOfAllBooks)
            {
                Console.WriteLine(item.title);
                Console.WriteLine(item.author);
                Console.WriteLine(item.pages);
                Console.WriteLine("----------------------");
            }
            Console.WriteLine("Hello World!");
        }
    }
}
