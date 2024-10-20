using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototipo_con_Ventanas
{
    internal class CrudMateria : ICrud<Materia>
    {
        private List<Materia> materias = new List<Materia>();

        public void Crear(Materia materia)
        {
            materias.Add(materia);
            Console.WriteLine("Materia agregada.\n");
        }

        public Materia Leer(int id)
        {
            foreach (Materia materia in materias)
            {
                if (materia.Id == id)
                {
                    return materia;
                }
            }
            return null;
        }

        public void Actualizar(Materia materia)
        {
            Materia materiaExistente = Leer(materia.Id);
            if (materiaExistente != null)
            {
                materiaExistente.Nombre = materia.Nombre;
                materiaExistente.Creditos = materia.Creditos;
                Console.WriteLine("Materia actualizada.\n");
            }
            else
            {
                Console.WriteLine("Materia no encontrada.\n");
            }
        }

        public void Eliminar(int id)
        {
            Materia materia = Leer(id);
            if (materia != null)
            {
                materias.Remove(materia);
                Console.WriteLine("Materia eliminada.\n");
            }
            else
            {
                Console.WriteLine("Materia no encontrada.\n");
            }
        }
    }
}
