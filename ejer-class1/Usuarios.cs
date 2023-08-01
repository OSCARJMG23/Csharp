using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ejer_class1;

    public class Usuario
    {
        public string Nombre;
        public int Documento;

        public Usuario(string _nombre, int _documento){
            this.Nombre = _nombre;
            this.Documento = _documento;
        }

        public string getNombre{
            get{return this.nombre;}
        }

        public string setNombre{
            set{this.nombre = value;}
        }
        public string getDocumento{
            get{return this.documento;}
        }
        public string setDocumento{
            set{this.documento = value;}
        }

    }
