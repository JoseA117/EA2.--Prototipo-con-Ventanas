using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Prototipo_con_Ventanas
{
    internal class CrudGrupo : ICrud<Grupo>
    {
        private List<Grupo> grupos = new List<Grupo>();

        public void Crear(Grupo grupo)
        {
            grupos.Add(grupo);
            Console.WriteLine("Grupo agregado.\n");
        }

        public Grupo Leer(int id)
        {
            foreach (Grupo grupo in grupos)
            {
                if (grupo.Id == id)
                {
                    return grupo;
                }
            }
            return null;
        }

        public void Actualizar(Grupo grupo)
        {
            Grupo grupoExistente = Leer(grupo.Id);
            if (grupoExistente != null)
            {
                grupoExistente.Nombre = grupo.Nombre;
                grupoExistente.Alumnos = grupo.Alumnos;
                grupoExistente.Maestro = grupo.Maestro;
                Console.WriteLine("Grupo actualizado.\n");
            }
            else
            {
                Console.WriteLine("Grupo no encontrado.\n");
            }
        }

        public void Eliminar(int id)
        {
            Grupo grupo = Leer(id);
            if (grupo != null)
            {
                grupos.Remove(grupo);
                Console.WriteLine("Grupo eliminado.\n");
            }
            else
            {
                Console.WriteLine("Grupo no encontrado.\n");
            }
        }
    }
}
