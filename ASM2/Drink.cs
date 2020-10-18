using System;
using System.Collections.Generic;
using System.Text;

namespace ASM2
{
    class Drink
    {
        public string Name;
        public Dictionary<string, int> Price = new Dictionary<string, int>(){
            {"M", 15},
            {"XL", 20}
        };

    }
}
