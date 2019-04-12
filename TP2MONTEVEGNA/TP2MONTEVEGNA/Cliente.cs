using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2MONTEVEGNA
{
    public class Cliente:Persona
    {
        public int Cuit { set; get; }
        public int Cuil { set; get; }
        public List<Factura> ListaDeCobros=new List<Factura>();
    }
}
