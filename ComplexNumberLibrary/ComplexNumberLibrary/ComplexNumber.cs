using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexNumberLibrary
{
    public struct ComplexNumber
    {
        private const double Precision = 1e-13;

        public double Re { get; set; }
        public double Im { get; set; }

        public double Abs => Math.Sqrt(Re * Re + Im * Im);

        public ComplexNumber(double re, double im)
        {
            Re = re;
            Im = im;
        }

        private static double RoundForHashing(double value)
        {
            return Math.Round(value, 13);
        }

        public override string ToString()
        {
            NumberFormatInfo nfi = new NumberFormatInfo
            {
                NumberDecimalSeparator = ","
            };

            if (Math.Abs(Re) < Precision && Math.Abs(Im) < Precision)
            {
                return "0";
            }
            if (Math.Abs(Im) < Precision)
            {
                return Re.ToString("G", nfi);
            }
            if (Math.Abs(Re) < Precision)
            {
                if (Math.Abs(Im - 1.0) < Precision) return "i";
                if (Math.Abs(Im - (-1.0)) < Precision) return "-i";
                return Im.ToString("G", nfi) + "i";
            }

            string reStr = Re.ToString("G", nfi);
            string imStr;

            if (Math.Abs(Im - 1.0) < Precision)
            {
                imStr = "+i";
            }
            else if (Math.Abs(Im - (-1.0)) < Precision)
            {
                imStr = "-i";
            }
            else
            {
                imStr = (Im < 0 ? Im.ToString("G", nfi) : "+" + Im.ToString("G", nfi)) + "i";
            }
            return reStr + imStr;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is ComplexNumber))
            {
                throw new ArgumentException("не является комплексным числом");
            }

            ComplexNumber other = (ComplexNumber)obj;
            return Math.Abs(Re - other.Re) < Precision &&
                   Math.Abs(Im - other.Im) < Precision;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                const int p = 23;
                hash = hash * p + RoundForHashing(Re).GetHashCode();
                hash = hash * p + RoundForHashing(Im).GetHashCode();
                return hash;
            }
        }

        public static bool operator ==(ComplexNumber c1, ComplexNumber c2)
        {
            return c1.Equals(c2);
        }

        public static bool operator !=(ComplexNumber c1, ComplexNumber c2)
        {
            return !c1.Equals(c2);
        }

        public static ComplexNumber operator +(ComplexNumber c1, ComplexNumber c2)
        {
            return new ComplexNumber(c1.Re + c2.Re, c1.Im + c2.Im);
        }

        public static ComplexNumber operator -(ComplexNumber c1, ComplexNumber c2)
        {
            return new ComplexNumber(c1.Re - c2.Re, c1.Im - c2.Im);
        }
    }
}
