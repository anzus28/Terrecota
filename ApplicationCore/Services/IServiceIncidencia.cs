using Infraestructure.Models;
using Infraestructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Services
{
    public interface IServiceIncidencia
    {
      Incidencias Save(Incidencias _Incidencias, int idusuario);
        IEnumerable<Incidencias> GetIncidencia();
         Incidencias GetIncidenciaByID(int id);
        IEnumerable<string> GetUsuarioIncidencia();
        void Delete(Incidencias inci);

    }
}
