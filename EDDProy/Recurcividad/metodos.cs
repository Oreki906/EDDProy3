using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo.Recurcividad
{
    internal class metodos
    {
        public static long Factorial( int num)
        {
            if (num < 0)
                throw new ArgumentException("debe de ser positivo");
            if (num == 0 || num == 1)
                return 1;
            return num * Factorial(num - 1);

        }

        public static double Exponente(double bas, double exp)
        {
       
            if (exp == 0)
                return 1;
            else if (exp % 2 == 0)
                return Exponente(bas * bas, exp / 2);
            else
                return bas * Exponente(bas, exp - 1);
        }
        public static int SumaArreglo(int[] array, int num)
        {
            // Caso base: cuando llegamos al primer elemento
            if (num == 0)
                return array[0];
            else
                // Llamada recursiva
                return array[num] + SumaArreglo(array, num - 1);
        }

        public static int fibonacci(int num)
        {
            if (num == 0)
                return 0;
            if (num == 1)
                return 1;
            else
            {
                
                return fibonacci(num - 1) + fibonacci(num - 2);
            }


        }


    }
}
