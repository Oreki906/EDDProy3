using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDDemo.Recurcividad
{
    public partial class FormRecursividad : Form
    {
        public int[] array;
        public int actual = 0;
        public FormRecursividad()
        {
            InitializeComponent();
            metodos metodos = new metodos();
            btnCalcular.Visible = false;
            btnAgregar.Visible = false;
            btnTamano.Visible = false;
            lblObj.Visible = false;
            cbObjetivo.Visible = false;

        }


        private void btnExponente_Click(object sender, EventArgs e)
        {
            lblVariable1.Text = ("");
            lblVariable1.Text = ("base");
            lblVariable2.Text = ("");
            lblVariable2.Text = ("exponente");
            btnCalcular.Visible = true;
            lblVariable2.Visible = true;
            cbDato2.Visible = true;
            btnTamano.Visible = false;
            btnAgregar.Visible = false;
            cbObjetivo.Visible = false;
            lblObj.Visible = false;

            btnCalcular.Click -= btnCalcular_Click;
            btnCalcular.Click += (s, args) => exponente();

        }

        private void btnFactorial_Click(object sender, EventArgs e)
        {
            lblVariable1.Text = ("");
            lblVariable1.Text = ("numero");
            lblVariable2.Visible = false;
            cbDato2.Visible = false;
            btnCalcular.Visible = true;

            btnCalcular.Click -= btnCalcular_Click;
            btnCalcular.Click += (s, args) => factorial();
            btnTamano.Visible = false;
            btnAgregar.Visible = false;
            cbObjetivo.Visible = false;
            lblObj.Visible = false;

        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        public void exponente()
        {
            if (int.TryParse(cbDato1.Text, out int b))
            {
                if (int.TryParse(cbDato2.Text, out int expo))
                {
                    double resltado = metodos.Exponente(b, expo);
                    try
                    {
                        double resultado = metodos.Exponente(b, expo);
                        lblMostrar.Text = ("el resultado es " + resultado);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        public void factorial()
        {
            if (int.TryParse(cbDato1.Text, out int numero))
            {
                try
                {
                    long resultado = metodos.Factorial(numero);
                    lblMostrar.Text = ("el resultado es " + resultado);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        public void btnCalcular_Click(object sender, EventArgs e)
        {
            exponente();
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            lblVariable1.Text = ("");
            lblVariable1.Text = ("tamaño");
            lblVariable2.Text = ("");
            lblVariable2.Text = ("numeros");
            btnCalcular.Visible = true;
            lblVariable2.Visible = true;
            cbDato2.Visible = true;
            btnTamano.Visible = true;
            btnAgregar.Visible = true;
            btnCalcular.Click -= btnCalcular_Click;
            btnCalcular.Click += (s, args) => Suma();
        }

        private void Suma()
        {
            if (array == null || actual == 0)
            {
                MessageBox.Show("El arreglo está vacío o no se ha inicializado.");
                return;
            }

            // Llamamos a la función SumaArreglo pasando el índice del último elemento ingresado
            int suma = metodos.SumaArreglo(array, actual - 1);
            MessageBox.Show($"La suma de los elementos del arreglo es: {suma}");
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (array == null)
            {
                MessageBox.Show("Primero defina un tamaño para el arreglo.");
                return;
            }
            if (actual >= array.Length)
            {
                MessageBox.Show("El arreglo está lleno.");
                return;
            }
            if (int.TryParse(cbDato2.Text, out int numero))
            {
                array[actual] = numero;
                actual++;
                MessageBox.Show("Número agregado.");
                cbDato2.Text = "";
                if (actual == array.Length)
                {
                    MessageBox.Show("El arreglo está completo.");
                }
            }
            else
            {
                MessageBox.Show("Ingrese un número válido.");
            }
        }

        private void btnTamano_Click(object sender, EventArgs e)
        {
            if (int.TryParse(cbDato1.Text, out int tam))
            {
                if (tam <= 0)
                {
                    MessageBox.Show("El tamaño debe ser mayor que 0.");
                    return;
                }
                array = new int[tam];
                actual = 0;
                cbDato1.Text = "";
                MessageBox.Show("Tamaño definido.");
            }
            else
            {
                MessageBox.Show("Ingrese un tamaño válido.");
            }
        }

        private void fib()
        {
            if (int.TryParse(cbDato1.Text, out int limite))
            {
                if (limite < 0)
                {
                    MessageBox.Show("Ingrese un número mayor o igual a 0.");
                    return;
                }

                try
                {
                    string secuencia = GenerarFibonacci(limite); // Llama al método para generar la secuencia
                    lblMostrar.Text = $"La secuencia de Fibonacci hasta {limite} es:\n{secuencia}";
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al generar la secuencia: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Ingrese un número válido.");
            }
        }
        public static string GenerarFibonacci(int limite) // Genera la secuencia completa
        {
            List<int> fibonacciNumeros = new List<int>(); // Almacena los números de Fibonacci

            for (int i = 0; i <= limite; i++)
            {
                fibonacciNumeros.Add(metodos.fibonacci(i)); // Calcula cada número
            }

            return string.Join(", ", fibonacciNumeros); // Retorna la secuencia como texto
        }

        private void btnFibo_Click(object sender, EventArgs e)
        {
            lblVariable1.Text = ("");
            lblVariable1.Text = ("numero");
            lblVariable2.Visible = false;
            cbDato2.Visible = false;
            btnCalcular.Visible = true;

            btnCalcular.Click -= btnCalcular_Click;
            btnCalcular.Click += (s, args) => fib();
            btnTamano.Visible = false;
            btnAgregar.Visible = false;
            cbObjetivo.Visible = false;
            lblObj.Visible = false;
        }

        private void Buscar()
        {
            {
                if (array == null || actual == 0)
                {
                    MessageBox.Show("El arreglo no está definido o está vacío.");
                    return;
                }

                if (!int.TryParse(cbObjetivo.Text, out int objetivo))
                {
                    MessageBox.Show("Por favor, ingrese un número válido para buscar.");
                    return;
                }

                try
                {
                    // Asegúrate de que el arreglo esté ordenado antes de la búsqueda binaria
                    Array.Sort(array, 0, actual);
                    int resultado = metodos.BusquedaBinaria(array, 0, actual - 1, objetivo);

                    if (resultado != -1)
                        lblMostrar.Text = $"El número {objetivo} está en la posición {resultado} del arreglo ordenado.";
                    else
                        lblMostrar.Text = $"El número {objetivo} no está en el arreglo.";


                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error durante la búsqueda: {ex.Message}");
                }
            }
        }

        private void btnBusqueda_Click(object sender, EventArgs e)
        {
            lblVariable1.Text = ("");
            lblVariable1.Text = ("tamano");
            lblVariable2.Text = ("");
            lblVariable2.Text = ("numero y busqueda");
            btnCalcular.Visible = true;
            lblVariable2.Visible = true;
            cbDato2.Visible = true;
            btnTamano.Visible = true;
            btnAgregar.Visible = true;
            btnCalcular.Click -= btnCalcular_Click;
            btnCalcular.Click += (s, args) => Buscar();
            cbObjetivo.Visible = true;
            lblObj.Visible = true;
        }
        private void hanoi()
        {
            {
                if (int.TryParse(cbDato1.Text, out int numeroDeDiscos))
                {
                    if (numeroDeDiscos > 0)
                    {
                        metodos.Hanoi(numeroDeDiscos, listBox1);
                    }
                    else
                    {
                        MessageBox.Show("Ingrese un número de discos mayor a 0.");
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese un número válido.");
                }
            }
        }

        private void btTorre_Click(object sender, EventArgs e)
        {
            
        }
    }
}
