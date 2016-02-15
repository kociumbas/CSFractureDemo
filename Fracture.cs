using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FractureDemo
{
    public struct Fracture
    {
        private int numerator, denominator;

        public Fracture(int numerator, int denominator = 1)
        {
            if (denominator == 0)
                throw new ArgumentException("Denominator cannot be '0'");
            this.numerator = numerator;
            this.denominator = denominator;
        }

        public static string Info()
        {
            return "Structure Fracture, (c) Michal Kociumbas 2015";
        }

        public override string ToString()
        {
            return numerator.ToString() + "/" + denominator.ToString();
        }

        public double ToDouble()
        {
            return numerator / (double)denominator;
        }

        public void Simplify()
        {
            //NWD
            int smaller = Math.Min(Math.Abs(numerator), Math.Abs(denominator));
            for (int i = smaller; i > 1; i--)
                if ((numerator%1==0) && (denominator%i==0))
                {
                    numerator /= i;
                    denominator /= i;
                    break;
                }

            //symbols
            if (numerator*denominator<0)
            {
                numerator = -Math.Abs(numerator);
                denominator = Math.Abs(denominator);
            }
            else
            {
                numerator = Math.Abs(numerator);
                denominator = Math.Abs(denominator);
            }
            
        }

        #region Properties
        public int Numerator
        {
            get //odczyt
            {
                return numerator;
            }
            set //zapis
            {
                numerator = value;
            }
        }

        public int Denominator
        {
            get //odczyt
            {
                return denominator;
            }
            set //zapis
            {
                if (value == 0)
                    throw new ArgumentException("Denominator must be different from 0");
                denominator = value;
            }
        }
        #endregion


        public static readonly Fracture Zero = new Fracture(0);
        public static readonly Fracture One = new Fracture(1);
        public static readonly Fracture Half = new Fracture(1, 2);
        public static readonly Fracture Quarter = new Fracture(1, 4);
    }
}