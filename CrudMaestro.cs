using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototipo_con_Ventanas
{
    internal class CrudMaestro : ICrud<Maestro>
    {
        private List<Maestro> maestros = new List<Maestro>();

        public void Crear(Maestro maestro)
        {
            maestros.Add(maestro);
            Console.WriteLine("Maestro agregado.\n");
        }

        public Maestro Leer(int id)
        {
            foreach (Maestro maestro in maestros)
            {
                if (maestro.Id == id)
                {
                    return maestro;
                }
            }
            return null;
        }

        public void Actualizar(Maestro maestro)
        {
            Maestro maestroExistente = Leer(maestro.Id);
            if (maestroExistente != null)
            {
                maestroExistente.Nombre = maestro.Nombre;
                maestroExistente.Apellido = maestro.Apellido;
                maestroExistente.Contacto = maestro.Contacto;
                Console.WriteLine("Maestro actualizado.\n");
            }
            else
            {
                Console.WriteLine("Maestro no encontrado.\n");
            }
        }

        public void Eliminar(int id)
        {
            Maestro maestro = Leer(id);
            if (maestro != null)
            {
                maestros.Remove(maestro);
                Console.WriteLine("Maestro eliminado.\n");
            }
            else
            {
                Console.WriteLine("Maestro no encontrado.\n");
            }
        }
    }
}
