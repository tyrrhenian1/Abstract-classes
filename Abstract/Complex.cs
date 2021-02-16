using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract
{
    class Complex : Pair
    {
        public Complex(int comp_a, int comp_b, int comp_c, int comp_d) : base(comp_a, comp_b, comp_c, comp_d)
        {

        }
        public override void Display()
        {
            throw new NotImplementedException();
        }
    }
}
