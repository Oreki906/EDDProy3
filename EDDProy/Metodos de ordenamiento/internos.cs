using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo.Metodos_de_ordenamiento
{
    public class internos
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
        public void ShellSort(int[] array)
        {
            int n= array.Length;

            for(int x = n / 2; x > 0; x /= 2)
            {
                for (int i = x; i < n; i++)
                {
                    int tem = array[i];
                    int j = i;

                    while (j >= x && array[j - x] > tem)
                    {
                        array[j]=array[j - x];
                        j -= x;
                    }
                    array[j] = tem;
                }
            }
        }
        public void QuickSort(int [] array, int inicio, int fin)
        {
            int pivote;
            if (inicio<fin)
            {
                pivote = particionar(array, inicio,fin);
                QuickSort(array, inicio, pivote - 1);
                QuickSort(array,pivote+1,fin);
            }
        }
        static int particionar(int[] array, int inicio, int fin)
        {
            int pivote = array[fin];  
            int i = inicio - 1;     

            for (int j = inicio; j < fin; j++)
            {
                if (array[j] <= pivote)
                {
                    i++;
                    // Intercambia elementos
                    int temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                }
            }

           
            int tempPivote = array[i + 1];
            array[i + 1] = array[fin];
            array[fin] = tempPivote;

            return i + 1; 
        }


       public void RadixSort(int[]array, int n)
        {
            int m = getMax(array, n);
            for(int exp =1; m/exp > 0; exp*=10)
                CountSort(array,n,exp);
        }
        
        public static int getMax(int[]array,int n)
        {
            int max = array[0];
            for(int i = 1; i < n; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
                
            }
            return max;
        }
        public static void CountSort(int[] array,int n, int exp)
        {
            int[]output = new int[n];
            int[]count = new int[10];
            for (int i = 0; i < 10; i++)
                count[i] = 0;
            for(int i = 0; i < n;i++)
                count[(array[i]/exp)%10]++;
            for (int i = 1; i < 10; i++)
                count[i] += count[i - 1];
            for(int i = n-1; i >= 0; i--)
            {
                output[count[(array[i]/exp)%10]-1] =array[i];
                count[(array[i] / exp) % 10]--;
            }
            for (int i = 0;i < n;i++)
                array[i] = output[i];
        }
        public int BusquedaLineal(int[] arreglo, int valor)
        {
            for (int i = 0; i < arreglo.Length; i++)
            {
                if (arreglo[i] == valor)
                {
                    return i; 
                }
            }
            return -1; 
        }
        public int BusquedaSecuencial(int[] array, int valor)
        {
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] == valor)
                    {
                        return i; 
                    }
                }
                return -1; 
            }
        }
        public int? BusquedaHash(Dictionary<int, string> diccionario, string valor)
        {
            foreach (var kvp in diccionario)
            {
                if (kvp.Value.Equals(valor, StringComparison.OrdinalIgnoreCase))
                {
                    return kvp.Key; 
                }
            }
            return null; 
        }



    }
}
