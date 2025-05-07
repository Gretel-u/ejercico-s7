using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercico1_s7
{
    class Program
    {
        static void Main()
        {
            NumeroPerfecto();
          
        }
        static void NumeroPerfecto()

        {
            int n, suma = 0;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("ingrese numero:");
            n = int.Parse(Console.ReadLine());
            for (int i = 1; i < n; i++)
            {
                if (n % i == 0)
                {
                    //el i es div del n
                    suma += i;


                }
            }
            if (suma == n)
            {
                Console.WriteLine("numero perfecto");
            }
            else
            {
                Console.WriteLine("numero no es perfecto");

            }
        }
        static void NumeroPerctoWhile()
        {
            int num,div, suma = 0;
            Console.Write("ingrese un numero:");
            num = int.Parse(Console.ReadLine());

            div = num - 1;

            while (num>0)
            {
                if (num%div==0)
                {
                Console.WriteLine("numero perfecto");
            }
            else
            {
                Console.WriteLine("numero no es perfecto");
                    suma += div;

                }
                div--;
            }
                if (suma == num)
                {
                Console.WriteLine("numero perfecto");
                }
                else
                {
                Console.WriteLine("numero no es perfecto");
                }
        }
        static void NumeroPerfectoDoWhile()
        {
            int num, div, suma = 0;
            Console.Write("ingrese un numero:");
            num = int.Parse(Console.ReadLine());

            div = num - 1;


            do
            {
                if (num % div == 0)
                {
                    suma += div;
                }
                div--;
            }
            while (div > 0);
            if (suma == num)
            {
                Console.WriteLine("numero perfecto");
            }
            else
            {
                Console.WriteLine("numero no es perfecto");
            }
        }
    }


}
