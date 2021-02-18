using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract
{
    class FazzyNumber : Pair
    {
        public string Func { get; set; }
        public FazzyNumber(double a, double b, double a1, double a2, double b1, double b2,string func) : base(a, b, a1, a2, b1, b2)
        {
            Func = func;
        }
        public FazzyNumber(double a, double a1, double a2,string func):base(a,a1,a2)
        {
            Func = func;
        }
        public override void Display()
        {
            switch(Func)
            {
                case "+":
                    {
                        Console.WriteLine($"A({A - A1},{A},{A + A2}) {Func} B({B - B1},{B},{B - B2}) = ({A+B-A1-B1};{A+B};{A+B+A2+B2})");
                    }
                    break;
                case "-":
                    {
                        Console.WriteLine($"A({A - A1},{A},{A + A2}) {Func} B({B - B1},{B},{B - B2}) = ({A-B-A1-B1};{A-B};{A-B+A2+B2})");
                    }
                    break;
                case "*":
                    {
                        Console.WriteLine($"A({A - A1},{A},{A + A2}) {Func} B({B - B1},{B},{B - B2}) = ({A*B-B*A1-A*B1};{A*B};{A*B+B*A1+A*B1+A1*B1})");
                    }
                    break;
                case "/":
                    {
                        if (B > 0)
                        {
                            Console.WriteLine($"A({A - A1},{A},{A + A2}) {Func} B({B - B1},{B},{B - B2}) = ({(A - A1) / (B + B2)};{A / B};{(A + A2) / (B - B1)})");
                        }
                        else Console.WriteLine("Вычисление невозможно, где-то 0");
                    }
                    break;
                case "^":
                    {
                        if (A > 0)
                        {
                            Console.WriteLine($"{Func}A({A - A1},{A},{A + A2}) = ({1 / (A + A2)};{1 / A};{1 / (A - A1)})");
                        }
                        else Console.WriteLine("Вычисление невозможно, где-то 0");
                    }
                    break;
            }
        }
    }
}
