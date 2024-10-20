using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototipo_con_Ventanas
{
    internal class CrudCarrera : ICrud<Carrera>
    {
        private List<Carrera> carreras = new List<Carrera>();

        public void Crear(Carrera carrera)
        {
            carreras.Add(carrera);
            Console.WriteLine("Carrera agregada.\n");
        }

        public Carrera Leer(int id)
        {
            foreach (Carrera carrera in carreras)
            {
                if (carrera.Id == id)
                {
                    return carrera;
                }
            }
            return null;
        }

        public void Actualizar(Carrera carrera)
        {
            Carrera carreraExistente = Leer(carrera.Id);
            if (carreraExistente != null)
            {
                carreraExistente.Nombre = carrera.Nombre;
                Console.WriteLine("Carrera actualizada.\n");
            }
            else
            {
                Console.WriteLine("Carrera no encontrada.\n");
            }
        }

        public void Eliminar(int id)
        {
            Carrera carrera = Leer(id);
            if (carrera != null)
            {
                carreras.Remove(carrera);
                Console.WriteLine("Carrera eliminada.\n");
            }
            else
            {
                Console.WriteLine("Carrera no encontrada.\n");
            }
        }
    }
}
