using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab301
{
    class Fraction
    {
        //properties
        public int _Numer;
        public int _Denom;
        public static int _Count=0;

        public int Numer
        {
            get {
               return _Numer;
            }
            set {
               _Numer = value;
            }
        }
        public int Denom
        {
            get
            {
                return _Denom;
            }
            set
            {
                if (_Denom != 0)
                {
                    _Denom = value;
                }
                else
                {
                    _Denom = 1;
                }
            }
        }
        public static int Count
        {
            get
            {
                return _Count;
            }
            set
            {
                if(_Count != 0)
                {
                    _Count = value;
                }
            }
        }

        //Constructors
        public Fraction()
        {
            _Numer = 0;
            _Denom = 1;
            _Count++;
            
        }



        public Fraction(Fraction a)
        {
            
            _Numer = a._Numer;
            _Denom = a._Denom;
            _Count++;

        }

        public Fraction(int n, int d=1)
        {
            _Numer = n;
            _Denom = d;
            _Count++;
            
        }


        //Method
        public void setValue(int n,int d){
            Numer = n;
            if (d != 0)
            {
                Denom = d;
            }
            else
            {
                Denom = 1;
            }
            
        }

        public static int GCD(int n,int d){
            int x=0;
            if (n != 0) { 
            for(int i= n; i > 0; i--)
            {
                if(n%i == 0 && d % i == 0)
                {
                    x = i;
                    break;

                }

            }
                return x;
            }
            else
            {
                return x=1;
            }
           
        }

        public void Reduce(Fraction a)
        {
            

            int igcd = GCD(a._Numer, a._Denom);

            this._Numer =a.Numer/ igcd;
            this._Denom =a.Denom/ igcd;

           
        }

        //Operator Overloading
        public static   Fraction operator +(Fraction a, Fraction b)
        {
            Fraction result;
            result = new Fraction();
           
            result.Denom = a._Denom * b.Denom;
            result.Numer = (a.Numer*b.Denom) + (b.Numer*a.Denom);
            return result;
        }

        public static  Fraction operator -(Fraction a, Fraction b)
        {
            Fraction result;
            result = new Fraction();
            
            result.Denom = a._Denom * b.Denom;
            result.Numer = (a._Numer * b.Denom) - (b._Numer * a.Denom);
            return result;
        }
        public static  Fraction operator ++(Fraction a)
        {
            Fraction result;
            result = new Fraction();
            
            result.Denom = a._Denom;
            result.Numer = a._Numer + a.Denom;
            return result;
        }

        public static  Fraction operator +(Fraction a,int b)
        {
            Fraction result;
            result = new Fraction();
            
            result.Denom = a.Denom;
            result.Numer = a.Numer + (b * a.Denom);
            return result;
           
        }

        public static  Fraction operator -(int b,Fraction a)
        {
            Fraction result;
            result = new Fraction();
            
            result.Denom = a.Denom;
            result.Numer = (b*a.Denom)-a.Numer;
            return result;

        }
        public static explicit operator float (Fraction a)
        {
            return (float)a;
        }

    public static  bool operator ==(Fraction a, Fraction b)
        {
            if ((a.Numer == b.Numer) && (a.Denom == b.Denom))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static  bool operator !=(Fraction a,Fraction b)
        {
            if ((a.Numer != b.Numer) || (a.Denom != b.Denom))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Equals(Fraction a)
        {
           return (a.Numer == Numer && a.Denom == Denom);                 
       }

    
        public override string ToString()
        {
            string output;
            float c;
            Reduce(this);
            c = (float)Numer / (float)Denom;
            output = ("[Rational: "+Numer+"/"+Denom+", value = "+c+"]");
            return output;
        }





    }
}

/*## Constructors:
- Fraction(): default constructor
- Fraction(Fraction a): copy constructor
- Fraction(numerator, denominator)
note: increment the Count property when an object is created

## Methods
- setValue: set fraction value
- GCD: calculate Greatest Common Divisor of two integers(static)

[Rational: 0/1], value=0]
[Rational: 2/1], value=2]
[Rational: 1/3], value=0.333333333333333]
[Rational: 2/1], value=2]
[Rational: 5/3], value=1.66666666666667]
[Rational: 4/1], value=4]
[Rational: 4/3], value=1.33333333333333]
[Rational: 8/1], value=8]
[Rational: 6/5], value=1.2]
*/
