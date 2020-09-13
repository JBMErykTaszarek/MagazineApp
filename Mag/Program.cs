
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
            listOfAll.Add(new Pillow("Ombracio",1300, "natural"));
            listOfAll.Add(new Pillow("Ombracio", 1300, "KK"));
            listOfAll.Add(new Pillow("Ombracio", 1300, "sYnthEtic"));
            listOfAll.Add(new Mattress("Pasodoble", 1499, 6));
            listOfAll.Add(new Mattress("Hybrid CoolTouch", 15000, 23));
            listOfAll.Add(new Mattress("Dobranocka", 219, 3));

            Console.WriteLine("Choose an option: \n 1.Add Item \n 2.Delete Item by ID \nShow all items \n4.show item by type \n5.show item by cotaining string");
            foreach(var item in listOfAll)
            {
                ShowBasicInfo(item);
            }
            Console.WriteLine(" ------------- ");
            

        }
        public static void DeleteItem(int id, List<Thing> list)
        {
            list.RemoveAll(item => item.id == id);
        }
        public static void ShowBasicInfo(Thing thing)
        {
            
            string currentClass = thing.GetType().ToString().Replace("Mag.","");
            switch (currentClass)
            {
                case "Mattress":
                    Mattress mattress = (Mattress) thing;
                    Console.WriteLine("{0}.{1} - cena:{2}, twardość:{3}",mattress.id,mattress.name,mattress.price,mattress.Hardness);
                    break;
                    
                case "Pillow":
                    Pillow pillow = (Pillow) thing;
                    Console.WriteLine("{0}.{1} - cena:{2}, natural/synthetic:{3}", pillow.id, pillow.name, pillow.price, pillow.NaturalOrSynthetic);
                    break;

                default:
                    Console.WriteLine("Nie ma takiego produktu");
                    break;
                


           }
            
        }
    }
}