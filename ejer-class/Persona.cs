using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class Alumno
{
            private string idAlumno;
            private string nombreAlumno;

        public Persona(string _nombreAlumno){
            this.idAlumno = Guid.NewGuid().ToString();
            this.nombreAlumno= _nombreAlumno ;
        }
        
}