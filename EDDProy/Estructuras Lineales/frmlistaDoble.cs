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
    public partial class frmlistaDoble : Form
    {
        private Nodos inicio;
        private Nodos fin;
        public frmlistaDoble()
        {
            InitializeComponent();
        }
        private void incertar(int posicion, int Dato)
        {
            Nodos Nuevo = new Nodos();//instancia
            Nuevo.Dato = Dato;//asignar al nuevo nodo 
            Nuevo.Sig = null;// el siguinte es null
            Nuevo.prev = null;

            if (inicio == null && fin == null)
            {
                inicio = Nuevo;
                fin = Nuevo;
                return;
            }
            if (posicion == 0 || posicion == 1)
            {
                Nuevo.Sig = inicio;
                inicio.prev = Nuevo;
                inicio = Nuevo;
                return;
            }
            Nodos Aux = inicio;
            int pos = 1;

            while (pos < posicion - 1 && Aux.Sig != null)
            {
                Aux = Aux.Sig;
                pos++;
            }

            // Insertar en la posición intermedia
            if (Aux.Sig != null)
            {
                Nuevo.Sig = Aux.Sig;
                Aux.Sig.prev = Nuevo;
                Aux.Sig = Nuevo;
                Nuevo.prev = Aux;
            }
            // Insertar al final de la lista
            else
            {
                fin.Sig = Nuevo;
                Nuevo.prev = fin;
                fin = Nuevo;
            }
        }
        private void ListDobl_Load(object sender, EventArgs e)
        {

        }
        private void ver()
        {
            Imprecion.Items.Clear();

            if (inicio == null)
            {
                return; // Si la lista está vacía
            }

            Nodos actual = inicio;

            while (actual != null)
            {
                Imprecion.Items.Add(actual.Dato);
                actual = actual.Sig;
            }
        }
        

       
        private int eliminar(int posicion)
        {
            if (inicio == null && fin == null)
            {
                MessageBox.Show("lista vacia");
                return -1;
            }
            else
            {
                int pos = 1;
                Nodos Aux = inicio;
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
            }
        }

        
        public int conta()
        {
            if (inicio == null)
            {
                MessageBox.Show("la lista esta vacia");
                return 0;
            }
            int cont = 0;
            Nodos nodo = inicio;
            while (nodo != null)
            {
                cont++;
                nodo = nodo.Sig;
            }
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
                while (act != null && enc != true)
                {
                    if (act.Dato == valor)
                    {
                        MessageBox.Show("el nodo con el dato " + valor + " fue encontrado");
                        enc = true;
                    }
                    act = act.Sig;
                }
                if (!enc)
                {
                    MessageBox.Show("no encontrado");
                }
            }
            else
            {
                MessageBox.Show("la lista se encuentra vacia");
            }

        }
       

        
       //qqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqq
        private void btAgregar_Click_1(object sender, EventArgs e)
        {
            int valor;
            int x;
            if (int.TryParse(cbDatos.Text, out valor) && int.TryParse(cbPosicion.Text, out x))
            {
                incertar(x, valor);
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
            if (int.TryParse(cbDatos.Text, out x) && x > 0)
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
            inicio = null;
            fin = null;
            Imprecion.Items.Clear();
            MessageBox.Show("la lista fue vaciada ");
        }

        private void btContar_Click_1(object sender, EventArgs e)
        {
            if (conta() != 0)
            {
                conta();
                MessageBox.Show("hay " + conta() + " cantdad de datos");
            }
        }

        private void btAnt_Click_1(object sender, EventArgs e)
        {
            Imprecion.Items.Clear();
            Nodos actual = fin;
            while (actual != null)
            {
                Imprecion.Items.Add(actual.Dato);
                actual = actual.prev;
            }
        }

        private void btBuscar_Click_1(object sender, EventArgs e)
        {
            Nodos act = new Nodos();
            act = inicio;
            bool enc = false;
            int valor;
            int.TryParse(cbDatos.Text, out valor);
            if (inicio != null)
            {
                while (act != null && enc != true)
                {
                    if (act.Dato == valor)
                    {
                        MessageBox.Show("el nodo con el dato " + valor + " fue encontrado");
                        enc = true;
                    }
                    act = act.Sig;
                }
                if (!enc)
                {
                    MessageBox.Show("no encontrado");
                }
            }
            else
            {
                MessageBox.Show("la lista se encuentra vacia");
            }
        }
    }
}