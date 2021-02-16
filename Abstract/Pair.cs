using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract
{
    abstract class Pair
    {
        public int A { get; set; } 
        public int B { get; set; }
        public int A1 { get; set; }
        public int A2 { get; set; }
        public int B1 { get; set; }
        public int B2 { get; set; }
        public int compA { get; set; }
        public int compB { get; set; }
        public int compC { get; set; }
        public int compD { get; set; }
        protected Pair(int a, int b, int a1, int a2, int b1, int b2)
        {
            A = a;
            B = b;
            A1 = a1;
            A2 = a2;
            B1 = b1;
            B2 = b2;
        }
        protected Pair (int a,int a1,int a2)
        {
            A = a;
            A1 = a1;
            A2 = a2;
        }
        protected Pair(int comp_a,int comp_b,int comp_c,int comp_d)
        {
            compA = comp_a;
            compB = comp_b;
            compC = comp_c;
            compD = comp_d;
        }
        public abstract void Display();
    }
}
