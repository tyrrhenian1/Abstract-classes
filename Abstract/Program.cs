using System;

namespace Abstract
{
    class Program
    {
        static void Main(string[] args)
        {
            // ^ - cопряжение для комплексных чисел и обртаное число для неточных.
            FazzyNumber a = new FazzyNumber(1, 2, 3,"^");
            FazzyNumber b = new FazzyNumber(1, 2, 3,1,2,3, "+");
            FazzyNumber c = new FazzyNumber(1, 2, 3, 1, 2, 3, "-");
            FazzyNumber d = new FazzyNumber(1, 2, 3, 1, 2, 3, "/");
            FazzyNumber e = new FazzyNumber(1, 2, 3, 1, 2, 3, "*");
            FazzyNumber f = new FazzyNumber(1, 2, 3, 1, 2, 3, "^");
            Complex g = new Complex(1, 2, "^");
            Complex k = new Complex(1, 2,3,4, "+");
            Complex l = new Complex(1, 2, 3, 4, "-");
            Complex m = new Complex(1, 2, 3, 4, "*");
            Complex n = new Complex(1, 2, 3, 4, "/");
            Complex o = new Complex(1, 2, 3, 4, "==");
            a.Display();
            b.Display();
            c.Display();
            d.Display();
            e.Display();
            f.Display();
            g.Display();
            k.Display();
            l.Display();
            m.Display();
            n.Display();
            o.Display();

        }
    }
}
