using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDDemo.Estructuras_Lineales
{
   
    public partial class frmCircular : Form
    { 
        private Nodos inicio;
    private Nodos fin;
    Nodos prev = null;
        public frmCircular()
        {
            InitializeComponent();
        }
        private void insertar(int Dato, int posiscion)
        {
            Nodos Nuevo = new Nodos();
            Nuevo.Dato = Dato;
            Nuevo.Sig = null;

            if (inicio == null && fin == null)
            {
                inicio = Nuevo;
                fin = Nuevo;
                Nuevo.Sig = inicio;
                return;
            }
            if (posiscion == 0 || posiscion == 1)
            {
                Nuevo.Sig = inicio;
                inicio = Nuevo;
                fin.Sig = inicio;
                return;

            }
            int pos = 1;
            Nodos Aux = inicio;

            while (pos < posiscion && Aux != fin)
            {
                prev = Aux;
                Aux = Aux.Sig;
                pos++;
            }
            if (Aux != null && Aux != fin)
            {
                Nuevo.Sig = Aux;
                prev.Sig = Nuevo;
            }
            else
            {
                Nuevo.Sig = inicio;
                fin.Sig = Nuevo;
                fin = Nuevo;
            }
        }

        private void ver()
        {
            Imprecion.Items.Clear();

            if (inicio == null)
            {
                return; // Si la lista está vacía
            }

            Nodos actual = inicio;

            do
            {
                Imprecion.Items.Add(actual.Dato);
                actual = actual.Sig;
            } while (actual != inicio);
        }
       

        private int eliminar(int posicion)
        {

            if (inicio == null)
            {
                MessageBox.Show("La lista esta vacia");
                return -1;
            }

            Nodos Aux = inicio;
            Nodos prev = null;
            int Dato;


            if (posicion == 1)
            {
                Dato = Aux.Dato;


                if (inicio == fin)
                {
                    inicio = null;
                    fin = null;
                }
                else
                {
                    inicio = inicio.Sig; // Mover el inicio
                    fin.Sig = inicio;
                }

                return Dato;
            }


            int pos = 1;
            do
            {
                prev = Aux;
                Aux = Aux.Sig;
                pos++;
            } while (pos < posicion && Aux != inicio); // Recorre hasta la posición

            if (Aux != inicio)
            {
                Dato = Aux.Dato;

                if (Aux == fin)
                {
                    fin = prev;
                    fin.Sig = inicio;
                }
                else
                {
                    prev.Sig = Aux.Sig;
                }

                return Dato;
            }
            else
            {
                MessageBox.Show("No se encontró la posición");
                return -1;
            }
        }



        
        public int conta()
        {
            if (inicio == null)
            {
                MessageBox.Show("la lista esta vasia");
                return 0;
            }

            int cont = 0;
            Nodos nodo = inicio;
            do
            {
                cont++;
                nodo = nodo.Sig;
            } while (nodo != inicio);
            return cont;
        }
        
        private void buscar()
        {
            Nodos act = new Nodos();
            act = inicio;
            bool enc = false;
            int valor;
            int.TryParse(cbDatos.Text, out valor);
            if (act != null)
            {
                do
                {
                    if (act.Dato == valor)
                    {
                        MessageBox.Show("el dato a sido encontrado");
                        enc = true;
                    }
                    act = act.Sig;
                } while (act != inicio && enc != true);
                if (!enc)
                {
                    MessageBox.Show("el dato no se ha encontrado");
                }
            }
            else
            {
                MessageBox.Show("la lista se encuentra vacia");
            }
        }
       

        private void btAgregar_Click_1(object sender, EventArgs e)
        {
 int valor;
            int x;
            if (int.TryParse(cbDatos.Text, out valor) && int.TryParse(cbPosicion.Text, out x))//asegura que el dato sea de tiop int 
            {
                insertar(valor, x);
                ver();
            }
            else
            {
                MessageBox.Show("se requiere ingresar un dato y una posision");
            }

            cbDatos.Text = "";//blanquea el ingreso de los dATOS 
            cbPosicion.Text = "";
            cbDatos.Focus();//para no volver a hacer clic eb la barra 

        }

        private void btEliminar_Click_1(object sender, EventArgs e)
        {
int x;
            if (int.TryParse(cbPosicion.Text, out x))
            {
                int eliminado = eliminar(x);
                if (eliminado != 0)
                {
                    MessageBox.Show("dato eliminda");
                    ver();
                }
            }
            else
            {
                MessageBox.Show("ingresa una posision");
            }
            cbPosicion.Text = "";
            cbPosicion.Focus();
        }

        private void btVaciar_Click_1(object sender, EventArgs e)
        {
inicio = null;
            fin = null;

            Imprecion.Items.Clear();
            MessageBox.Show("la lista fue vaciada");
        }

        private void btContar_Click_1(object sender, EventArgs e)
        {
 if (conta() != 0)
            {
                conta();
                MessageBox.Show("hay " + conta() + " cantdad de datos");
            }
        }

        private void btBuscar_Click_1(object sender, EventArgs e)
        {
buscar();
            cbDatos.Text = "";
            cbPosicion.Text = "";
            cbDatos.Focus();
        }
    }
}