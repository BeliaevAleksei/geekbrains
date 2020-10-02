using System;

namespace Task3
{
    class Fraction
    {
        private int _numerator;
        private int _denominator;

        public int Numerator
        {
            get => _numerator;
            set => _numerator = value;
        }
        public int Denominator
        {
            get => _denominator;
            set
            {
                if (value != 0)
                {
                    _denominator = value;
                } 
                else
                {
                    throw new ArgumentException("Знаменатель не может быть равен 0");
                }
            }
        }

        public void sum(Fraction fraction)
        {
            _numerator = _numerator + fraction.Numerator;
            _denominator = _denominator + fraction.Denominator;
        }

        public void subtraction(Fraction fraction)
        {
            _numerator = _numerator - fraction.Numerator;
            _denominator = _denominator - fraction.Denominator;
        }

        public void multiplication(Fraction fraction)
        {
            _numerator = _numerator * fraction.Numerator;
            _denominator = _denominator * fraction.Denominator;
        }
        public void division(Fraction fraction)
        {
            _numerator = _numerator * fraction.Denominator;
            _denominator = _denominator * fraction.Numerator;
        }

        public double getDecimal()
        {
            return Convert.ToDouble(_numerator) / Convert.ToDouble(_denominator);
        }

        public override string ToString()
        {
            return _numerator + " / " + _denominator;
        }
    }
}
