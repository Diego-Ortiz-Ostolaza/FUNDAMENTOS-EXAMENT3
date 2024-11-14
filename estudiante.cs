using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3_EXAMEN
{
    internal class estudiante
    {
        public int codigo { get; set; }
        public string nombre { get; set; }
        public string universidad { get; set; }

        
        public override string ToString()
        {
            return $"El estudiante {nombre}, estudia en la universidad {universidad} y tiene como código de alumno {codigo}"; 
        }
    }
}
