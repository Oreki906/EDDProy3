using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace EDDemo.Metodos_de_ordenamiento
{
    public partial class FrmOrdenamiento : Form
    {
        public Clases clas = new Clases();
        public int[] array;
        public int actual = 0;
        public FrmOrdenamiento()
        {
            InitializeComponent();
          
        }

        private void FrmOrdenamiento_Load(object sender, EventArgs e)
        {

        }

        private void txtNodos_ValueChanged(object sender, EventArgs e)
        {

        }
       
        Random rnd = new Random();

        private void btnCrearLista_Click(object sender, EventArgs e)
        {
            try
            {
                clas.burbuja(array);
                MessageBox.Show("ordenado correctamente");
                mostrar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } 
        }
        public void mostrar()
        {
            lbOrden.Items.Clear();
            foreach(int valor in array)
            {
               lbOrden.Items.Add(valor);
            }
        }

        private void cbTamaño_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (int.TryParse(cbTamaño.SelectedItem.ToString(), out int tam))
            {
                array = new int[tam];
                actual = 0;
                cbnumb.Clear();
                MessageBox.Show("tamaño definido");
            }
            else
            {
                MessageBox.Show("seleccione un dato");
            }
        }

        

        private void lbOrden_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if(array == null)
            {
                return;
            }
            if (actual >= array.Length)
            {
                MessageBox.Show("lleno");
                return;
            }
            if(int.TryParse(cbnumb.Text, out int numero))
            {
                array[actual] = numero;
                actual++;
                MessageBox.Show("agregado");
                cbnumb.Clear();
                if(actual == array.Length)
                {
                    MessageBox.Show("arreglo completo");

                }
            }

            else
            {
                MessageBox.Show("ingrese un numero valido");
            }
            mostrar();
        }

        private void btnShell_Click(object sender, EventArgs e)
        {
            try
            {
                clas.ShellSort(array);
                MessageBox.Show("ordenado correctamente");
                mostrar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnQuickSort_Click(object sender, EventArgs e)
        {
            try
            {
                clas.QuickSort(array, 0, array.Length - 1);
                MessageBox.Show("ordenado correctamente");
                mostrar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRadix_Click(object sender, EventArgs e)
        {

            try
            {
                clas.RadixSort(array, array.Length);
                MessageBox.Show("ordenado correctamente");
                mostrar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
