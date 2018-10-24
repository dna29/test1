using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormPersona
{
   
    public class Persona
    {
        public string nombre { get; set; }
        public string apellidos { get; set; }
        public string sexo { get; set; }
        public string ciudad { get; set; }

        public Persona(string nombre, string apellidos, string sexo, string ciudad)
        {
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.sexo = sexo;
            this.ciudad = ciudad;
        }
    }
}
