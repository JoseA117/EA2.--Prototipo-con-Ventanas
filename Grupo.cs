using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototipo_con_Ventanas
{
    internal class Grupo
    {
        public int Id;
        public string Nombre;
        public List<Alumno> Alumnos;  
        public Maestro Maestro;
    }
}
