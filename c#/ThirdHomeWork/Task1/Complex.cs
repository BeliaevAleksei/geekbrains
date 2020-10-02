using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    public class Complex
    {
        double im;
        double re;

        public Complex()
        {
            im = 0;
            re = 0;
        }

        public Complex(double _im, double _re)
        {
            this.im = _im;
            this.re = _re;
        }

        public void Plus(Complex x)
        {
            this.im = x.im + this.im;
            this.re = x.re + this.re;
        }

        public void Subtract(Complex x)
        {
            this.im = im - x.im;
            this.re = re - x.re;
        }

        public void Multi(Complex x)
        {
            this.im = re * x.im + im * x.re;
            this.re = re * x.re - im * x.im;
        }

        override public string ToString()
        {
            return re + "+" + im + "i";
        }
    }

}
