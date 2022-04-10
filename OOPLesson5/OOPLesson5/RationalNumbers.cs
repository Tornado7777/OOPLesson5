using System;


namespace OOPLesson5
{
    /* Создать класс рациональных чисел. В классе два поля – числитель и знаменатель. 
     * Предусмотреть конструктор. Определить операторы 
     * ==, != (метод Equals()), <, >, <=, >=, +, –, ++, --. Переопределить метод ToString() 
     * для вывода дроби. Определить операторы преобразования типов между типом дробь,float, int. 
     * Определить операторы *, /, %.
     */

    class RationalNumbers
    {
        private int _numerator;
        private int _denominator;

        public RationalNumbers(int numerator, int denominator)
        {
            if (denominator == 0)
            {
                throw new ArgumentException("Denominator cannot be zero.", nameof(denominator));
            }
            _numerator = numerator;
            _denominator = denominator;
        }
        /// <summary>
        /// Устанавливает числитель и знаменатель у рационального числа
        /// </summary>
        /// <param name="c">числитель</param>
        /// <param name="d">знаментаель</param>
        public void SetRN(int c, int d)
        {
            _numerator = c; 
            _denominator = d;
        }

        public static RationalNumbers operator +(RationalNumbers a) => a;
        public static RationalNumbers operator ++(RationalNumbers a) => new RationalNumbers(a._numerator + a._denominator, a._denominator);
        public static RationalNumbers operator -(RationalNumbers a) => new RationalNumbers(-a._numerator, a._denominator);
        public static RationalNumbers operator --(RationalNumbers a) => new RationalNumbers(a._numerator - a._denominator, a._denominator);

        public static RationalNumbers operator +(RationalNumbers a, RationalNumbers b)
            => new RationalNumbers(a._numerator * b._denominator + b._numerator * a._denominator, a._denominator * b._denominator);

        public static RationalNumbers operator -(RationalNumbers a, RationalNumbers b)
            => a + (-b);

        public static RationalNumbers operator *(RationalNumbers a, RationalNumbers b)
            => new RationalNumbers(a._numerator * b._numerator, a._denominator * b._denominator);

        public static RationalNumbers operator /(RationalNumbers a, RationalNumbers b)
        {
            if (b._numerator == 0)
            {
                throw new DivideByZeroException();
            }
            return new RationalNumbers(a._numerator * b._denominator, a._denominator * b._numerator);
        }
        public static int operator %(RationalNumbers a, RationalNumbers b)
        {
            if (b._numerator == 0)
            {
                throw new DivideByZeroException();
            }
            return (a._numerator * b._denominator) % (a._denominator * b._numerator);
        }

        public static bool operator ==(RationalNumbers a, RationalNumbers b)
        {
            bool result = false;
            if (a._numerator == b._numerator && a._denominator == b._denominator) result = true;
            return result;
        }
        public static bool operator !=(RationalNumbers a, RationalNumbers b)
        {
            bool result = true;
            if (a._numerator == b._numerator && a._denominator == b._denominator) result = false;
            return result;
        }
        public static bool operator >(RationalNumbers a, RationalNumbers b)
        {
            bool result = false;
            double c = (double)a._numerator / a._denominator;
            double d = (double)b._numerator / b._denominator;
            if (c > d) result = true;
            return result;
        }
        public static bool operator <(RationalNumbers a, RationalNumbers b)
        {
            bool result = false;
            double c = (double)a._numerator / a._denominator;
            double d = (double)b._numerator / b._denominator;
            if (c < d) result = true;
            return result;
        }
        public static bool operator >=(RationalNumbers a, RationalNumbers b)
        {
            bool result = false;
            double c = (double)a._numerator / a._denominator;
            double d = (double)b._numerator / b._denominator;
            if (c >= d) result = true;
            return result;
        }
        public static bool operator <=(RationalNumbers a, RationalNumbers b)
        {
            bool result = false;
            double c = (double)a._numerator / a._denominator;
            double d = (double)b._numerator / b._denominator;
            if (c <= d) result = true;
            return result;
        }

        public override string ToString() => $"{_numerator} / {_denominator}";

        public override bool Equals(object obj)
        {
            return obj is RationalNumbers numbers &&
                   _denominator == numbers._denominator &&
                   _numerator == numbers._numerator;
        }

        public override int GetHashCode()
        {
            return 816931486 + _denominator.GetHashCode() + _numerator.GetHashCode();
        }

        //явное преобразование типов
        public static explicit operator float(RationalNumbers a)
        {
            if (a._denominator == 0) return 0;
            float b = (a._numerator / a._denominator);
            return (float)b;
        }

        public static explicit operator int(RationalNumbers a)
        {
            if (a._denominator == 0) return 0;
            int b =(int) ((float) a);
            return (int)b;
        }
    }
}
    
