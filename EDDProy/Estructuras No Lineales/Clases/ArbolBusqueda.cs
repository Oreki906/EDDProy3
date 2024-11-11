using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDDemo.Estructuras_No_Lineales
{
    public class ArbolBusqueda
    {
        public NodoBinario Raiz;
        public String strArbol;
        public String strRecorrido;
        public bool enc= false;

        public ArbolBusqueda()
        {
            Raiz = null;
            strArbol = "";
            strRecorrido = "";
        }

        public Boolean EstaVacio()
        {
            if (Raiz == null)
                return true;
            else
                return false;
        }
        public NodoBinario RegresaRaiz()
        {
            return Raiz;
        }

        public void InsertaNodo(int Dato, ref NodoBinario Nodo)
        {            
            if (Nodo == null)
            {
                Nodo = new NodoBinario(Dato);
                // CAMBIO 2

                if (Raiz == null)
                    Raiz = Nodo;
            }
            else if (Dato < Nodo.Dato)
                InsertaNodo(Dato, ref Nodo.Izq);
            else if (Dato > Nodo.Dato)
                InsertaNodo(Dato, ref Nodo.Der);          
        }
        public void MuestraArbolAcostado(int nivel, NodoBinario nodo )
        {
            if (nodo == null)
                return;
            MuestraArbolAcostado(nivel + 1, nodo.Der);
            for(int i=0; i<nivel; i++)
            {
                strArbol = strArbol + "      ";
            }
            strArbol = strArbol + nodo.Dato.ToString() + "\r\n";
            MuestraArbolAcostado(nivel + 1, nodo.Izq);
        }

        public  String ToDot(NodoBinario nodo)
        {
            StringBuilder b = new StringBuilder();
            if (nodo.Izq != null)
            {
                b.AppendFormat("{0}->{1} [side=L label=\"L\"] {2} ", nodo.Dato.ToString(), nodo.Izq.Dato.ToString(), Environment.NewLine);
                b.Append(ToDot(nodo.Izq));
            }
            else
            {
                b.AppendFormat("{0}->L{1} [side=L, style=\"invis\" label=\"L\"] {2} ", nodo.Dato.ToString(), nodo.Dato.ToString(), Environment.NewLine);
                b.AppendFormat("L{0}[style = \"invisible\" shape = none] {1} ", nodo.Dato.ToString(), Environment.NewLine);
            }

            if (nodo.Der != null)
            {
                b.AppendFormat("{0}->{1} [side=R label=\"R\"] {2} ", nodo.Dato.ToString(), nodo.Der.Dato.ToString(), Environment.NewLine);
                b.Append(ToDot(nodo.Der));
            } else
            {
                b.AppendFormat("{0}->R{1} [side=R, style=\"invis\" label=\"R\"] {2} ", nodo.Dato.ToString(), nodo.Dato.ToString(), Environment.NewLine);
                b.AppendFormat("R{0}[style = \"invisible\" shape = none] {1} ", nodo.Dato.ToString(), Environment.NewLine);

            }
            return b.ToString();
        }

        public void PreOrden(NodoBinario nodo)
        {
            if (nodo == null)
                return;

            strRecorrido = strRecorrido + nodo.Dato + ", ";
            PreOrden(nodo.Izq);
            PreOrden(nodo.Der);
            
            return;
        }

        public void InOrden(NodoBinario nodo)
        {
            if (nodo == null)
                return;

            InOrden(nodo.Izq);
            strRecorrido = strRecorrido + nodo.Dato + ", ";
            InOrden(nodo.Der);

            return;
        }
        public void PostOrden(NodoBinario nodo )
        {
            if (nodo == null)
                return;

            PostOrden(nodo.Izq);
            PostOrden(nodo.Der);
            strRecorrido = strRecorrido + nodo.Dato + ", ";

            return;
         }
        public void BuscarNodo(NodoBinario nodo, int valor)
        {
            if (nodo == null || enc)
                return;


            if (nodo.Dato == valor)
            {
                enc = true;
                return;
            }
            BuscarNodo(nodo.Izq, valor);
            BuscarNodo(nodo.Der, valor);
        }

        public void podararbol(ref NodoBinario nodo)
        {
            if (nodo == null)
                return;

            podararbol(ref nodo.Izq);
            podararbol(ref nodo.Der);
            nodo = null;
            return;
        }

        public NodoBinario buscaMayor( NodoBinario nodo)
        {
            if(nodo == null)
            {
                return null;
            }
            else
            {
                if (nodo.Der == null)
                    return nodo;
                else 
                    return buscaMayor( nodo.Der);
            }
        }
        public NodoBinario BusacaMenor( NodoBinario nodo)
        {
            if (nodo == null)
                return null;
            else if (nodo.Izq == null)
                return nodo;
            else 
                return BusacaMenor(nodo.Izq);
        }

        public void eliminarPredesor(int x, NodoBinario nodo)
        {
            if (nodo == null)
                return;
            else if (x<nodo.Dato)
                eliminarPredesor(x, nodo.Izq);
            else if (x>nodo.Dato) 
                eliminarPredesor(x,  nodo.Der);
            else if (nodo.Izq !=null && nodo.Der!=null)
            {
                // tiene hijos
              NodoBinario mayor  = buscaMayor( nodo.Izq);
              nodo.Dato = mayor.Dato;
                eliminarPredesor(mayor.Dato, nodo.Izq);
            }
            else
            {
                //tiene un solo hijo o ninguno
                NodoBinario temp = nodo;
                if (nodo.Izq == null)
                    nodo = nodo.Der;
                else if (nodo.Der ==null)
                    nodo = nodo.Izq;
                //eliminar el nodo
                temp = null;
            }

        }

        public void eliminarsucesor (int x , NodoBinario nodo)
        {
            if (nodo==null)
                return;
            else if(x<nodo.Dato)
                eliminarPredesor(x,nodo.Izq);
            else if (x>nodo.Dato)
                eliminarPredesor(x,nodo.Der);
            else if (nodo.Izq!=null && nodo.Der!=null)
            {
                //tiene 2 hijos 
                NodoBinario menor = BusacaMenor( nodo.Der);
                nodo.Dato= menor.Dato;
                eliminarsucesor(menor.Dato, nodo.Der);

            }
            else
            {
                //tiene un solo hijo 
                NodoBinario temp = nodo;
                if (nodo.Izq == null)
                    nodo= nodo.Der;
                else if(nodo.Der ==null)
                    nodo=nodo.Izq;
                //eliminar nodohoja
                temp=null;
            }
        }
        public int Altura()
        {
            return altura(Raiz);
        }
        public int altura(NodoBinario nodo)
        {
            if (nodo==null)
                return 0;
            return(1+Math.Max(altura(nodo.Izq),altura(nodo.Der)));
        }
        public int Contar()
        {
            return contarHojas(Raiz);
        }
        int contarHojas(NodoBinario nodo)
        {
            if(nodo==null)
                return 0;
            if (nodo.Der==null && nodo.Izq==null)
                return 1;
            else 
                return contarHojas(nodo.Der)+contarHojas(nodo.Der);
        }
        public int contnod()
        {
            return contarNodos(Raiz);
        }
        int contarNodos(NodoBinario nodo)
        {
            if (nodo==null)
                return 0;
            return 1 + contarNodos(nodo.Izq)+contarNodos(nodo.Der) ;
        }

    }
}
    

