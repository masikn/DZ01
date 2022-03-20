using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz01
{
    
   

    class Program
    {
        static void Main(string[] args)
        {
            double a, b, d, e, h;
            double f, j;
            char c;


            Console.Write("Числитель: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Знаменатель: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Числитель: ");
            d = Convert.ToDouble(Console.ReadLine());
            Console.Write("Знаменатель: ");
            e = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите действие: ");
            c = Convert.ToChar(Console.ReadLine());

            f = a / b; Console.WriteLine(a + " / " + b + " = " + f);
            j = d / e; Console.WriteLine(d + " / " + e + " = " + j);

            switch (c)
            {
                case '+': h = f + j; Console.WriteLine(f + " + " + j + " = " + h); break;
                case '-': h = f - j; Console.WriteLine(f + " - " + j + " = " + h); break;
                case '*': h = f * j; Console.WriteLine(f + " * " + j + " = " + h); break;
                case '/': h = f / j; Console.WriteLine(f + " / " + j + " = " + h); break;

            }

            Console.ReadLine();

        }
    }

}  

