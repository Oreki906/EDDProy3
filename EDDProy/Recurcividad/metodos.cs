using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        public static int BusquedaBinaria(int[] arr, int izquierda, int derecha, int objetivo)
        {
            // Caso base: si el rango es inválido, el objetivo no está en el arreglo
            if (izquierda > derecha)
                return -1;

            // Calcular el punto medio
            int medio = izquierda + (derecha - izquierda) / 2;

            // Verificar si el elemento en la posición media es el objetivo
            if (arr[medio] == objetivo)
                return medio;

            // Si el objetivo es menor que el elemento medio, buscar en la mitad izquierda
            if (arr[medio] > objetivo)
                return BusquedaBinaria(arr, izquierda, medio - 1, objetivo);

            // Si el objetivo es mayor que el elemento medio, buscar en la mitad derecha
            return BusquedaBinaria(arr, medio + 1, derecha, objetivo);
        }
        public static void Hanoi(int numeroDeDiscos, ListBox listBox)
        {
            if (numeroDeDiscos < 1)
            {
                MessageBox.Show("El número de discos debe ser mayor o igual a 1.");
                return;
            }

            listBox.Items.Clear(); // Limpiar los movimientos anteriores
            

            
          

            // Llamar al método recursivo
            MoverDiscos(numeroDeDiscos, 'A', 'C', 'B', listBox);

            

           
        }
        private static void MoverDiscos(int numeroDeDiscos, char origen, char destino, char auxiliar, ListBox listBox)
        {
           

            if (numeroDeDiscos == 1)
            {
                // Movimiento base: mover un disco
                string movimiento = $"Mover disco 1 de {origen} a {destino}";
                listBox.Items.Add(movimiento);
                return;
            }

            // Mover N-1 discos de origen a auxiliar usando destino como auxiliar
            MoverDiscos(numeroDeDiscos - 1, origen, auxiliar, destino, listBox);

            // Mover el disco restante de origen a destino
            string movimientoPrincipal = $"Mover disco {numeroDeDiscos} de {origen} a {destino}";
            listBox.Items.Add(movimientoPrincipal);

            // Mover los N-1 discos de auxiliar a destino usando origen como auxiliar
            MoverDiscos(numeroDeDiscos - 1, auxiliar, destino, origen, listBox);
        }

    }
}
