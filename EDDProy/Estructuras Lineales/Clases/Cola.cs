using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EDDemo.Estructuras_No_Lineales;

namespace EDDemo.Estructuras_Lineales.Clases
{
    internal class Cola
    {
        private NodoBinario primero;
        private NodoBinario ultimo;

        public Cola()
        {
            primero = null;
            ultimo = null;
        }

        public void enqueue(NodoBinario nodo)
        {
            if (nodo == null) return;

            if (ultimo == null)
            {
                primero = nodo;
                ultimo = nodo;
            }
            else
            {
                ultimo.Sig = nodo; // Sig debe estar en NodoBinario o su tipo
                ultimo = nodo;
            }
        }

        public NodoBinario Dequeue()
        {
            if (primero == null)
            {
                MessageBox.Show("Cola vacía");
                return null;
            }

            NodoBinario aux = primero;
            primero = primero.Sig;

            if (primero == null)
            {
                ultimo = null;
            }

            return aux;
        }

        public bool IsEmpty()
        {
            return primero == null;
        }

        public NodoBinario Frente()
        {
            return primero;
        }

    }
   /* internal class Cola
    {
        private Nodo primero;
        private Nodo ultimo;
        private int tamaño;

        public Cola()
        {
            primero = null;
            ultimo = null;
            tamaño = 0;
        }

        public void enqueue(Nodo nodo)
        {
            nodo.Sig = null;
            if (ultimo == null)
            {
                ultimo = nodo;
                primero = nodo;
            }
            else
            {
                ultimo.Sig = nodo;
                ultimo = nodo;
            }
            tamaño++;
        }

        public Nodo Dequeue()
        {
            if (primero == null)
            {
                MessageBox.Show("Cola vacía");
                return null;
            }
            else
            {
                Nodo aux = primero;
                primero = aux.Sig;
                aux.Sig = null;
                if (primero == null)
                {
                    ultimo = null;
                }
                tamaño--;
                return aux;
            }
        }

        public int conta()
        {
            return tamaño;
        }

        public Nodo FrenteNodo()
        {
            if (primero == null)
            {
                MessageBox.Show("Cola vacía");
                return null;
            }
            else
            {
                return primero;
            }
        }*/
        public class Nodo
        {
            public int Dato;
            public Nodo izquierdoPtr;
            public Nodo derechoPtr;
            public Nodo Sig;
        }
    
    
}
