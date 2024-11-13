using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using EDDemo.Clases;

namespace EDDemo
{
    public partial class frmPilas : Form
    {
        private Nodos Top;
        public frmPilas()
        {
            InitializeComponent();
            Top = null; // la pila inicia vacia
        }
        private void Push(int Dato)
        {
            Nodos Nuevo = new Nodos();
            Nuevo.Dato = Dato;//asignar al nuevo nodo 
            Nuevo.Sig = null;// el siguinte es null

            //metodo if 
            if (Top == null)//si la pila esta vacia 
            {
                Top = Nuevo;//el nuevo nodo es el tope de la pila
            }
            else
            {
                Nodos Aux = Top;
                Top = Nuevo;
                Top.Sig = Aux;
            }
        }
        private void btAgregar_Click(object sender, EventArgs e)
        {
            int valor;
            if (int.TryParse(txtDatos.Text, out valor))//asegura que el dato sea de tiop int 
            {
                Push(valor);
                Imprecion.Items.Add(valor);
            }
            else
            {
                MessageBox.Show("se requiere ingresar un numero");
            }

            txtDatos.Text = "";//blanquea el ingreso de los dATOS 
            txtDatos.Focus();//para no volver a hacer clic eb la barra 

        }

        private void Imprecion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public int Pop()
        {
            if (Top == null)
            {
                MessageBox.Show("pila vasia");
                return -1;
            }
            else
            {
                Nodos Aux = Top;
                int Dato = Aux.Dato;
                Top = Top.Sig;
                Dato = Aux.Dato;
                Aux = null;
                return Dato;
            }
        }
        private void btEliminar_Click(object sender, EventArgs e)
        {
            int valor = Pop();
            if (valor != -1)
            {
                MessageBox.Show("se a eliminado");
                if (Imprecion.Items.Count > 0)
                {
                    Imprecion.Items.RemoveAt(Imprecion.Items.Count - 1);
                }
            }


        }

        private void btVaciar_Click(object sender, EventArgs e)
        {
            Top = null;
            MessageBox.Show("se a vasiado");
            Imprecion.Items.Clear();
        }

        private void Pila_Load(object sender, EventArgs e)
        {

        }
        public int conta()
        {
            int cont = 0;
            Nodos nodo = Top;
            while (nodo != null)
            {
                cont++;
                nodo = nodo.Sig;
            }
            return cont;
        }
        private void btContar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("hay " + conta() + " elemntos");
        }

        public void buscar()
        {
            Nodos act = new Nodos();
            act = Top;
            bool enc = false;
            int valor;
            int.TryParse(txtDatos.Text, out valor);
            if (Top != null)
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
                MessageBox.Show("la pila se encuentra vacia");
            }
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            buscar();
            txtDatos.Text = "";//blanquea el ingreso de los dATOS 

            txtDatos.Focus();//para no volver a hacer clic eb la barra 
        }
    }
    public class Nodos
    {
        public int Dato;//valor del nodo 
        public Nodos Sig;//apuntador 
        public Nodos prev;
    }



}
