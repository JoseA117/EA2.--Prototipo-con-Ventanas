using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototipo_con_Ventanas
{
    internal interface ICrud<T>
    {
        void Crear(T entity);
        T Leer(int id);
        void Actualizar(T entity);
        void Eliminar(int id);
    }

}