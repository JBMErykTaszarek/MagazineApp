
using System;
using System.Collections.Generic;

namespace Mag
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Thing> listOfAll = new List<Thing>();
            listOfAll.Add(new Mattress("Salsa", 499, 12));
            listOfAll.Add(new Mattress("Pasodoble", 1499, 6));
            listOfAll.Add(new Mattress("Hybrid CoolTouch", 15000, 23));
            listOfAll.Add(new Mattress("Dobranocka", 219, 3));

            foreach(var item in listOfAll)
            {
                Console.WriteLine(ShowBasicInfo(item));
            };
        }

        public static string ShowBasicInfo(Thing thing)
        {
            
            string currentClass = thing.GetType().ToString().Replace("Mag.","");
            switch (currentClass)
            {
                case "Mattress":
                    Mattress mattress = (Mattress) thing;
                    Console.WriteLine(mattress.id);
                    return "sadasd";
                    
                case "Pillow":
                    return "pillow";
                    
                default:
                    return "This thing was not added as a class to your Magazine system";
                


           }
            
        }
    }
}