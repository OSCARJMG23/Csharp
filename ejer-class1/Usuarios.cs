using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ejer_class1;

    public class Usuario
    {
        public string Nombre;
        public string Documento;

        public Usuario(string _nombre, string _documento){
            this.Nombre = _nombre;
            this.Documento = _documento;
        }

        public string getNombre{
            get{return this.Nombre;}
        }

        public string setNombre{
            set{this.Nombre = value;}
        }
        public string getDocumento{
            get{return this.Documento;}
        }
        public string setDocumento{
            set{this.Documento = value;}
        }

    }
