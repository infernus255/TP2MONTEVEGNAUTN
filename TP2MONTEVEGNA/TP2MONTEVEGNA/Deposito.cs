using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2MONTEVEGNA
{
    public class Deposito
    {
        public List<Pasillo> ListaPasillos=new List<Pasillo>();
        public int NroDeposito { set; get; }
        public Medida Medida1;
        public List<Empleado> ListaEmpleados=new List<Empleado>();
        public List<Cliente> ListaClientes=new List<Cliente>();
        public List<Precio> ListaPrecios=new List<Precio>();
        public List<Factura> ListaGastos=new List<Factura>();

    }
}
