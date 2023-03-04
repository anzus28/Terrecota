using Infraestructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Repository
{
    public interface IRepositoryIncidencia
    {
        Incidencias Save(Incidencias _Incidencias, int idusuario);
        IEnumerable<Incidencias> GetIncidencia();
         Incidencias GetIncidenciaByID(int id);
        void Delete(Incidencias inci);
    }
}
