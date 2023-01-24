using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal struct LinearEquation
    {
        double k;
        double b;

        public double K { get { return k; } set { } }  
        public double B { get { return b; } set { } }

        public LinearEquation(double k, double b)
        {
            this.k = k;
            this.b = b;
        }

        public void Root()
        {
            Console.WriteLine("Решением уравнения {0}x+{1}=0 является число {2}", k, b, -b/k);
        }

    }
}
