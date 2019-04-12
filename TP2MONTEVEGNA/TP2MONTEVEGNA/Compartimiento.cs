using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2MONTEVEGNA
{
    public class Compartimiento
    {
        public int NroCompartimiento { set; get; }
        public bool Lado { set; get; } ///0 izquierdo, 1 derecho
        public string TipoProducto { set; get; }
        public int NroCliente { set; get; }///Si no tiene cliente es -1
        public Medida Medida1=new Medida();
        public int Espacio { set; get; } ///0 vacio, 1 ocupado, 2 lleno
        public int Nivel { set; get; } /// Desde 1 a 5 para saber la altura si es que hay estantes
        public int TiempoDeUso { set; get; } /// Solo se utiliza si esta asignado a un cliente, sino es -1

    }
}
