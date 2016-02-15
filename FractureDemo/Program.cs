using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FractureDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Fracture u2 = new Fracture(2, 1);
            //Fracture u0 = Fracture.Zero;
            //Fracture uH = Fracture.Half;
            //Console.WriteLine(uH.ToString());

            //Console.WriteLine(Fracture.Info());

            //Fracture u = new Fracture(4, -2);
            //u.Simplify();
            Fracture u = new Fracture { Numerator = 1, Denominator = 2 };
            Console.WriteLine(u.ToString());
        }
    }
}
