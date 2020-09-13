using System;
using System.Collections.Generic;
using System.Text;

namespace Mag
{
    class Thing
    {
        public static int cid = 0;
        public int id { get; set; }
        public string name { get; set; }

        public Thing(string name)
        {
            cid++;
            id = cid;
            this.name = name;
            

        }
    }
}
