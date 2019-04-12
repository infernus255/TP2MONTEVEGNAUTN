using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2MONTEVEGNA
{
    public class Pasillo
    {
        public int NroPasillo { set; get; }
        public List<Compartimiento> ListaDeCompartimientos=new List<Compartimiento>();
        public int NroCliente { set; get; } /// Si no tiene un cliente es -1
        public int Espacio { set; get; } ///0 vacio, 1 ocupado, 2 lleno
        public Medida Medida1;
        public int TiempoDeUso { set; get; }        ///Solo lo utilizo si un pasillo entero es asignado a un cliente sino es -1
    }
}
