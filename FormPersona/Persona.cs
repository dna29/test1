using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormPersona
{
   [Serializable]
    public class Persona
    {
        public string name { get; set; }
        public string surname { get; set; }
        public string sex { get; set; }
        public string city { get; set; }

        public Persona(string name, string surname, string sex, string city)
        {
            this.name = name;
            this.surname = surname;
            this.sex = sex;
            this.city = city;
        }


    }
}
