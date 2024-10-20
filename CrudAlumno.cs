using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototipo_con_Ventanas
{
    internal class CrudAlumno : ICrud<Alumno>
    {
        private List<Alumno> alumnos = new List<Alumno>();

        public void Crear(Alumno alumno)
        {
            alumnos.Add(alumno);
            Console.WriteLine("Alumno agregado.\n");
        }

        public Alumno Leer(int id)
        {
            foreach (Alumno alumno in alumnos)
            {
                if (alumno.Id == id)
                {
                    return alumno;
                }
            }
            return null;
        }

        public void Actualizar(Alumno alumno)
        {
            Alumno alumnoExistente = Leer(alumno.Id);
            if (alumnoExistente != null)
            {
                alumnoExistente.Nombre = alumno.Nombre;
                alumnoExistente.Apellido = alumno.Apellido;
                alumnoExistente.Carrera = alumno.Carrera;
                alumnoExistente.Promedio = alumno.Promedio;
                Console.WriteLine("Alumno actualizado.\n");
            }
            else
            {
                Console.WriteLine("Alumno no encontrado.\n");
            }
        }

        public void Eliminar(int id)
        {
            Alumno alumno = Leer(id);
            if (alumno != null)
            {
                alumnos.Remove(alumno);
                Console.WriteLine("Alumno eliminado.\n");
            }
            else
            {
                Console.WriteLine("Alumno no encontrado.\n");
            }
        }
    }
}
