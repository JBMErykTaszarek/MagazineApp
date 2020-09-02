using System;
using System.Collections.Generic;
using System.Text;

namespace Mag
{
    class Pillow
    {
        private string naturalOrSynthetic;
        public string NaturalOrSynthetic
        {
            get { return naturalOrSynthetic; }
            set
            {
                if (value == "natural" || value == "synthetic")
                    naturalOrSynthetic = value;
                else
                    naturalOrSynthetic = "undefined";
            }
        }


    }
}
