using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract
{
    abstract class Pair
    {
        public double A { get; set; } 
        public double B { get; set; }
        public double A1 { get; set; }
        public double A2 { get; set; }
        public double B1 { get; set; }
        public double B2 { get; set; }
        public double compA { get; set; }
        public double compB { get; set; }
        public double compC { get; set; }
        public double compD { get; set; }
        protected Pair(double a, double b, double a1, double a2, double b1, double b2)
        {
            A = a;
            B = b;
            A1 = a1;
            A2 = a2;
            B1 = b1;
            B2 = b2;
        }
        protected Pair (double a, double a1, double a2)
        {
            A = a;
            A1 = a1;
            A2 = a2;
        }
        protected Pair(double comp_a, double comp_b, double comp_c, double comp_d)
        {
            compA = comp_a;
            compB = comp_b;
            compC = comp_c;
            compD = comp_d;
        }
        protected Pair(double comp_a, double comp_b)
        {
            compA = comp_a;
            compB = comp_b;
        }
        public abstract void Display();
    }
}
