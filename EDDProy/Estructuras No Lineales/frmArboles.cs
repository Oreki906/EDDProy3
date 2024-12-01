using EDDemo;
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
using System.Windows.Forms.VisualStyles;
using System.Xml.Linq;


//using GraphVizWrapper;
//using GraphVizWrapper.Queries;
//using GraphVizWrapper.Commands;

//using csdot;
//using csdot.Attributes.DataTypes;

namespace EDDemo.Estructuras_No_Lineales
{
    public partial class frmArboles : Form
    {
        ArbolBusqueda miArbol;
        NodoBinario miRaiz;
        

        public frmArboles()
        {
            InitializeComponent();
            miArbol = new ArbolBusqueda();
            miRaiz = null;
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {

            //Obtenemos el nodo Raiz del arbol
            miRaiz = miArbol.RegresaRaiz();

            //Limpiamos la cadena donde se concatenan los nodos del arbol 
            miArbol.strArbol = "";

            //Se inserta el nodo con el dato capturado
            miArbol.InsertaNodo(int.Parse(txtDato.Text),
                                ref miRaiz);

            //Leer arbol completo y mostrarlo en caja de texto
            miArbol.MuestraArbolAcostado(1, miRaiz);
            txtArbol.Text = miArbol.strArbol;
            
            txtDato.Text = "";

 
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            miArbol = null;
            miRaiz = null;
            miArbol = new ArbolBusqueda();
            txtArbol.Text  = "";
            txtDato.Text = "";
            lblRecorridoPreOrden.Text = "";
            lblRecorridoInOrden.Text = "";
            lblRecorridoPostOrden.Text = "";
        }

        private void btnGrafica_Click(object sender, EventArgs e)
        {
            String graphVizString;
            String strOrientacion = "";

            miRaiz = miArbol.RegresaRaiz();
            if (miRaiz == null)
            {
                MessageBox.Show("El arbol esta vacio");
                return;
            }

            if (rbOrientacion2.Checked)
            {
                strOrientacion = "rankdir=\"LR\";";
            }
            StringBuilder b = new StringBuilder();
            //rankdir="LR";
            b.Append("digraph G { " + strOrientacion + " node [shape=\"circle\"]; " + Environment.NewLine);
            b.Append(miArbol.ToDot(miRaiz));
            b.Append("}");
            graphVizString =  b.ToString();

            //graphVizString = @" digraph g{ label=""Graph""; labelloc=top;labeljust=left;}";
            //graphVizString = @"digraph Arbol{Raiz->60; 60->40. 60->90; 40->34; 40->50;}";
            Bitmap bm = FileDotEngine.Run(graphVizString);

            
            frmGrafica graf = new frmGrafica();
            graf.ActualizaGrafica(bm);
            graf.MdiParent = this.MdiParent;
            graf.Show();
        }


        private void btnRecorrer_Click(object sender, EventArgs e)
        {
            //Recorrido en PreOrden
            //Obtenemos el nodo Raiz del arbol
            miRaiz = miArbol.RegresaRaiz();
            miArbol.strRecorrido = "";

            if (miRaiz == null)
            {
                lblRecorridoPreOrden.Text = "El arbol esta vacio";
                return;
            }
            lblRecorridoPreOrden.Text = "";
            miArbol.PreOrden(miRaiz);

            lblRecorridoPreOrden.Text = miArbol.strRecorrido;


            //Recorrido en InOrden
            //Obtenemos el nodo Raiz del arbol
            miRaiz = miArbol.RegresaRaiz();
            miArbol.strRecorrido = "";

            if (miRaiz == null)
            {
                lblRecorridoPostOrden.Text = "El arbol esta vacio";
                return;
            }
            lblRecorridoInOrden.Text = "";
            miArbol.InOrden(miRaiz);
            lblRecorridoInOrden.Text = miArbol.strRecorrido;


            //Recorrido en PostOrden
            //Obtenemos el nodo Raiz del arbol
            miRaiz = miArbol.RegresaRaiz();
            miArbol.strRecorrido = "";

            if (miRaiz == null)
            {
                lblRecorridoPostOrden.Text = "El arbol esta vacio";
                return;
            }
            lblRecorridoPostOrden.Text = "";
            miArbol.PostOrden(miRaiz);
            lblRecorridoPostOrden.Text = miArbol.strRecorrido;
        


        miRaiz = miArbol.RegresaRaiz();
            miArbol.strRecorrido = "";

            if (miRaiz == null)
            {
                lblRecorridoPreOrden.Text = "El arbol esta vacio";
                return;
            }
            lblrecorridoniveles.Text = "";
            miArbol.Niveles(miRaiz);

            lblrecorridoniveles.Text = miArbol.strRecorrido;
        }

        private void btnCrearArbol_Click(object sender, EventArgs e)
        {
            //Limpiamos los objetos y clases del anterior arbol
            miArbol = null;
            miRaiz = null;
            miArbol = new ArbolBusqueda();
            txtArbol.Text = "";
            txtDato.Text = "";
             
            miArbol.strArbol = "";

            Random rnd = new Random();

            for (int nNodos =1; nNodos <= txtNodos.Value; nNodos++)
            {
                int Dato = rnd.Next(1, 100);
                //Obtenemos el nodo Raiz del arbol
                miRaiz = miArbol.RegresaRaiz();

                //Se inserta el nodo con el dato capturado
                miArbol.InsertaNodo(Dato, ref miRaiz);
            }

            //Leer arbol completo y mostrarlo en caja de texto
            miArbol.MuestraArbolAcostado(1, miRaiz);
            txtArbol.Text = miArbol.strArbol;

            txtDato.Text = "";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtDato.Text, out int busc))
            {
                miArbol.enc = false;
                miArbol.BuscarNodo(miArbol.Raiz, busc);

                if (miArbol.enc)
                    MessageBox.Show("el nodo fue encontrado");
                else
                {
                    MessageBox.Show("no se ha encontrado el nodo");

                }

            }
            else
            {
                MessageBox.Show("ingrese un dato valido");
            }
        }

        private void btnPodar_Click(object sender, EventArgs e)
        {
            miRaiz = miArbol.RegresaRaiz();

            if (miRaiz == null)
            {
                MessageBox.Show("El árbol está vacío");
                return;
            }

            // Llama al método para podar el árbol
            miArbol.podararbol(ref miRaiz);

            // Actualiza la raíz en la clase ArbolBusqueda
            miArbol.Raiz = miRaiz;

            MessageBox.Show("El árbol ha sido podado");
        }

        private void btnelimpred_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtDato.Text, out int valor))
            {
                miArbol.eliminarPredesor(valor, miArbol.Raiz);
                MessageBox.Show("el dato " + valor + " se ha eliminado ");


            }
            else
                MessageBox.Show("ingresde un numero valido");
        }

        private void btnelimsuces_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtDato.Text, out int valor))
            {
                miArbol.eliminarsucesor(valor, miArbol.Raiz);
                MessageBox.Show("el dato " + valor + " se ha eliminado");

            }
            else
                MessageBox.Show("ingrese un numero valido");
        }

        private void Altura_Click(object sender, EventArgs e)
        {
            int altura = miArbol.Altura();
            MessageBox.Show("la altura es " + altura);

        }

        private void btncontho_Click(object sender, EventArgs e)
        {
            int hojas = miArbol.Contar();
            MessageBox.Show("el arbol tiene " + hojas + " hojas");
        }

        private void btnContnod_Click(object sender, EventArgs e)
        {
            int nodos = miArbol.contnod();
            MessageBox.Show("hay " + nodos + " nodos ");
        }

        

        private void lblrecorridoniveles_Click(object sender, EventArgs e)
        {

        }

        private void frmArboles_Load(object sender, EventArgs e)
        {
        
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btncompleto_Click(object sender, EventArgs e)
        {
            bool com = miArbol.comp();
            if (com==true)
            {
                MessageBox.Show("el arbol esta completo");
            }
            else
            {
                MessageBox.Show("el arbol no esta completo");
            }
        }

        private void btnlleno_Click_1(object sender, EventArgs e)
        {
 bool yeno = miArbol.llen();
            if (yeno==true)
            {
                MessageBox.Show("el arbol esta lleno");
            }
            else
            {
                MessageBox.Show("el no esta lleno");
            }

        }

        private void lblRecorridoPreOrden_Click(object sender, EventArgs e)
        {

        }

        private void lblRecorridoPreOrden_Click_1(object sender, EventArgs e)
        {

        }

        private void txtDato_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNodos_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
