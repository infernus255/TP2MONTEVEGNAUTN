using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2MONTEVEGNA
{
    public class Persona
    {
        public int Dni { set; get; }
        public string Apellido { set; get; }
        public string Nombre { set; get; }
        public DateTime FechaNac;
        public int Telefono { set; get; }
        public string Email { set; get; }
        public DateTime FechaInicio;
        public bool Genero { set; get; } ///0 masculino, 1 femenino
    }
}
