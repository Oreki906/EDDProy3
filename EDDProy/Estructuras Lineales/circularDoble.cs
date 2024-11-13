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
    public partial class circularDoble : Form
    {
        private Nodos inicio;
        private Nodos fin;
        public circularDoble()
        {
            InitializeComponent();
            inicio = null;
            fin = null;
        }

        private void listcircdoubl_Load(object sender, EventArgs e)
        {

        }
        private void ingresar(int Dato, int posicion)
        {
            {
                Nodos Nuevo = new Nodos();
                Nuevo.Dato = Dato;

                if (inicio == null)
                {
                    inicio = Nuevo;
                    fin = Nuevo;
                    Nuevo.Sig = inicio;
                    Nuevo.prev = inicio;
                    return;
                }

                if (posicion == 0)
                {
                    Nuevo.Sig = inicio;
                    Nuevo.prev = fin;
                    inicio.prev = Nuevo;
                    fin.Sig = Nuevo;
                    inicio = Nuevo;
                    return;
                }

                Nodos Aux = inicio;
                int pos = 0;

                while (pos < posicion - 2 && Aux.Sig != inicio)
                {
                    Aux = Aux.Sig;
                    pos++;
                }

                if (Aux == fin && pos < posicion - 1)
                {
                    Nuevo.Sig = inicio;  // Conectar al inicio para cerrar el ciclo
                    Nuevo.prev = fin;
                    fin.Sig = Nuevo;
                    inicio.prev = Nuevo;
                    fin = Nuevo;
                }
                else
                {
                    Nuevo.Sig = Aux.Sig;
                    Nuevo.prev = Aux;

                    Aux.Sig.prev = Nuevo;
                    Aux.Sig = Nuevo;
                }

            }
        }

        private void ver()
        {
            imprecion.Items.Clear();

            if (inicio == null)
            {
                return; // Si la lista está vacía
            }

            Nodos actual = inicio;

            do
            {
                imprecion.Items.Add(actual.Dato);
                actual = actual.Sig;
            } while (actual != inicio);
        }

       
       

        private int eliminar(int posicion)
        {

            /*
             la diferencia entre una enlasada circular simple y una doble es 
            que en la doble tambien es nesesario usar los puenteros prev al moimento de 
            eliminar los nodos para asi temer un puentero que apunte al nodo siguinte y
            al anterior
             
             */
            if (inicio == null && fin == null)
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
                    inicio = inicio.Sig;
                    inicio.prev = fin;
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
            } while (pos < posicion && Aux != inicio);
            if (Aux != inicio)
            {
                Dato = Aux.Dato;

                if (Aux == fin)
                {
                    fin = prev;
                    fin.Sig = inicio;
                    inicio.prev = fin;
                }
                else
                {
                    prev.Sig = Aux.Sig;
                    Aux.Sig.prev = prev;
                }

                return Dato;
            }
            else
            {
                MessageBox.Show("No se encontró la posición");
                return -1;
            }

            /* if (inicio == null && fin == null)
            {
                MessageBox.Show("lista vacia");
                return -1;
            }
            else
            {
                int pos = 1;
                Nodo Aux = inicio;
                int Dato;
                if (posicion == 1)
                {
                    Dato = inicio.Dato;
                    inicio = inicio.Sig;
                    if (inicio != null)
                    {
                        inicio.prev = null;
                    }
                    else
                    {
                        // Si la lista queda vacía
                        fin = null;
                    }
                    return Dato;
                }

                // Buscar el nodo en la posición especificada
                while (pos < posicion && Aux != null)
                {
                    Aux = Aux.Sig;
                    pos++;
                }

                // Verificar si se encontró el nodo en la posición
                if (Aux != null)
                {
                    Dato = Aux.Dato;

                    // Caso: Eliminar el último nodo
                    if (Aux.Sig == null)
                    {
                        fin = Aux.prev;
                        fin.Sig = null;
                    }
                    // Caso: Eliminar un nodo intermedio
                    else
                    {
                        Aux.prev.Sig = Aux.Sig;
                        Aux.Sig.prev = Aux.prev;
                    }

                    Aux = null; // Liberar el nodo eliminado
                    return Dato;
                }
                else
                {
                    MessageBox.Show("No se encontró el nodo en esa posición");
                    return 0;
                }
            }*/
        }

      

        private void vaciar()
        {
            inicio = null;
            fin = null;
            imprecion.Items.Clear();
            MessageBox.Show("la lista se a vaciado");
        }
        private int conta()
        {
            if (inicio == null)
            {
                MessageBox.Show("la lista esta vacia");
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
        public void buscar()
        {
            Nodos act = new Nodos();
            act = inicio;
            bool enc = false;
            int valor;
            int.TryParse(cbDatos.Text, out valor);
            if (inicio != null)
            {
                do
                {
                    if (act.Dato == valor)
                    {
                        MessageBox.Show("dato encontrado");
                        enc = true;
                    }
                    act = act.Sig;
                } while (act != inicio && enc != true);
                if (!enc)
                {
                    MessageBox.Show("dato no encontrado");
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
                ingresar(valor, x);
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
            if (int.TryParse(cbPosicion.Text, out x) && x > 0)
            {
                int eliminado = eliminar(x);
                if (eliminado != 0)
                {
                    MessageBox.Show("Dato eliminado: " + eliminado);
                    ver(); // Actualiza la lista visual
                }
            }
            else
            {
                MessageBox.Show("Ingresa una posición válida mayor a 0");
            }
            cbPosicion.Text = "";
            cbPosicion.Focus();
        }
        

        private void btVaciar_Click_1(object sender, EventArgs e)
        { 
            vaciar();
            
        }

        private void btContar_Click_1(object sender, EventArgs e)
        {if (conta() != 0)
            {
                conta();
                MessageBox.Show("hay " + conta() + " datos");
            }

        }

        private void BtBuscar_Click_1(object sender, EventArgs e)
        {
            buscar();
            cbDatos.Text = "";
            cbPosicion.Text = "";
            cbDatos.Focus();
        }
    }
}
