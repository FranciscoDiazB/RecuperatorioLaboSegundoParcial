using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.SQL
{
    internal interface IManejadorSql<T>
    {
        void Agregar(T entidad);


        List<T> Obtener();

    }
}
