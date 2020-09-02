using System;
using System.Collections.Generic;
using System.Text;

namespace Mag
{
    class Mattress:ForSleep
    {
        private int hardness;
        public int id { get; set; }
        public Mattress(string name, int price, int hardness) : base( name, price)
        {
            this.id = Thing.id;
            this.name = name;
        }
        public int Hardness
        {
            get { return hardness; }
            set
            {
                if (value > 0 && value < 8)
                    hardness = value;
                else
                    hardness = -1;
            }
        }
    }
    
}
