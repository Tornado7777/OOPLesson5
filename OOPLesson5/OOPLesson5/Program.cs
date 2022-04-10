using System;

namespace OOPLesson5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var a = new RationalNumbers(5, 4);
            var b = new RationalNumbers(1, 2);
            ShowRN(a,b);
            
            a.SetRN(3, 4);
            b.SetRN(11, 4);

            a.SetRN(3, 8);
            b.SetRN(3, 4);
            ShowRN(a, b);

        }

        static void ShowRN(RationalNumbers a, RationalNumbers b)
        {
            Console.WriteLine("===========================================================");
            Console.WriteLine("Демонстрация для пары чисел.");
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
            Console.WriteLine("-a: " + (-a));   // output: -5 / 4
            Console.WriteLine("a + b = " + (a + b));  // output: 14 / 8
            Console.WriteLine("a - b = " + (a - b));  // output: 6 / 8
            Console.WriteLine("a * b = " + (a * b));  // output: 5 / 8
            Console.WriteLine("a / b = " + (a / b));  // output: 10 / 4
            Console.WriteLine("a % b = " + (a % b));
            a++; b--;
            Console.WriteLine("a++ = " + a);
            Console.WriteLine("b-- = " + b);
            Console.WriteLine("a > b : " + (a > b));
            Console.WriteLine("a < b : " + (a < b));
            Console.WriteLine("a >= b : " + (a >= b));
            Console.WriteLine("a <= b : " + (a <= b));
            Console.WriteLine("a == b : " + (a == b));
            Console.WriteLine("a != b : " + (a != b));
            Console.ReadLine();
        }
    }
}
