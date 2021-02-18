using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract
{
    class Complex : Pair
    {
        public string Func { get; set; }
        public Complex(double comp_a, double comp_b, double comp_c, double comp_d,string func) : base(comp_a, comp_b, comp_c, comp_d)
        {
            Func = func;
        }
        public Complex(double comp_a, double comp_b,string func) : base(comp_a, comp_b)
        {
            Func = func;
        }
        public override void Display()
        {
            switch (Func)
            {
                case "+":
                    {
                        Console.WriteLine($"({compA},{compB}) {Func} ({compC},{compD}) = ({compA+compB},{compC+compD})");
                    }
                    break;
                case "-":
                    {
                        Console.WriteLine($"({compA},{compB}) {Func} ({compC},{compD}) = ({compA - compB},{compC - compD})");
                    }
                    break;
                case "*":
                    {
                        Console.WriteLine($"({compA},{compB}) {Func} ({compC},{compD}) = ({compA*compC - compB*compD},{compA*compD + compB*compC})");
                    }
                    break;
                case "/":
                    {
                        Console.WriteLine($"({compA},{compB}) {Func} ({compC},{compD}) = ({(compC*compA + compB*compD + compB * compC - compA*compD) / (compC*compC + compD*compD)})");
                    }
                    break;
                case "==":
                    {
                        if (compA == compC && compB == compD) Console.WriteLine($"({compA},{compB}) = ({compC},{compD})");
                        else Console.WriteLine($"({compA},{compB}) != ({compC},{compD})");
                    }
                    break;
                case "^":
                    {
                        Console.WriteLine($"{Func}({compA},{compB}) = ({compA},{-compB})");
                    }
                    break;
            }
        }
    }
}
