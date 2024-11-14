using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3_EXAMEN
{
    internal class citas
    {
        public int numero {  get; set; }
        public estudiante estudiante { get; set; }
        public string enfermedad {  get; set; }
        
        public double precio { get; set; }
        public override string ToString()
        {
            return $"{numero}:\n{estudiante.nombre} de la universidad {estudiante.universidad} con codigo de alumno{estudiante.codigo}, tendrá una cita médica por tener {enfermedad}. \n La cita costará {precio}";
        }
        public void agregar() { 

        }
    }
}
