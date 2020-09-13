using System;
using System.Collections.Generic;
using System.Text;

namespace Mag
{
    class Pillow:ForSleep
    {
        private string naturalOrSynthetic;
        public int id { get; set; }

        public Pillow(string name, int price, string narutalOrSynthetic) : base(name, price)
        {
            this.id = Thing.cid;
            this.name = name;
            this.price = price;
            NaturalOrSynthetic = narutalOrSynthetic;
        }
        public string NaturalOrSynthetic
        {
            get { return naturalOrSynthetic; }
            set
            {
                if (value.ToLower() == "natural" || value.ToLower() == "synthetic")
                    naturalOrSynthetic = value.ToLower();
                else
                    naturalOrSynthetic = "undefined";
            }
        }


    }
}
