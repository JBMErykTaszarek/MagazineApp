using System;
using System.Collections.Generic;
using System.Text;

namespace Mag
{
    class Thing
    {
        public static int id = 0;
        public string name { get; set; }

        public Thing(string name)
        {
            id++;
            this.name = name;
            

        }
    }
}
