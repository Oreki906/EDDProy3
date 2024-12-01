using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo.Metodos_de_ordenamiento
{
    public class Clases
    {
        //Metodo burbuja 
        public void burbuja(int[] array)
        {
            if (array == null || array.Length == 0)
                throw new ArgumentException("El arreglo está vacío o no es válido.");

            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        // Intercambio
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
            
            
        
        
        }




    }
}
