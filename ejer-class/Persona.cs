using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class Alumno
{
            private string idAlumono;
            private string nombreAlumno;

        public Persona(string _nombreAlumno){
            this._idAlumno = Guid.NewGuid().ToString();
            this._nombreAlumno= _nombreAlumno ;
        }
        
}