using System;
using System.Collections.Generic;
using System.Text;

namespace Mag
{
    abstract class ForSleep : Thing
    {
        public int price { get; set; }

        public ForSleep(string name, int price) : base(name)
        {
            
            this.name = name;
            this.price = price;

        }
    }
}
