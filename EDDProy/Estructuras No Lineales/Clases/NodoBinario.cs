using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EDDemo.Estructuras_Lineales.Clases;

namespace EDDemo.Estructuras_No_Lineales
{
    public class NodoBinario
    {
        public int Dato;
        public NodoBinario Izq;
        public NodoBinario Der;
        //public NodoBinario ColaAuxiliar;
       // public NodoBinario nodoLleno;
        //public NodoBinario nodoAuxiliar;

        public NodoBinario(int Dato)
        {
            this.Dato = Dato;
            this.Izq = null;
            this.Der = null;
            // CAMBIO 2
        }

        public NodoBinario Sig { get; internal set; }
    }
}
