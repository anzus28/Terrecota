using Infraestructure.Models;
using Infraestructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Services
{
    public class ServiceIncidencia: IServiceIncidencia
    {
        public IEnumerable<Incidencias> GetIncidencia()
        {
            IRepositoryIncidencia repository = new RepositoryIncidencia();
            return repository.GetIncidencia();
        }

        public Incidencias Save(Incidencias _Incidencias, int idusuario)
        {
            IRepositoryIncidencia repository = new RepositoryIncidencia();
            return repository.Save(_Incidencias, idusuario);
        }
        public Incidencias GetIncidenciaByID(int id)
        {
            IRepositoryIncidencia repository = new RepositoryIncidencia();
            return repository.GetIncidenciaByID(id);
        }
        public IEnumerable<string> GetUsuarioIncidencia()
        {
            IRepositoryIncidencia repository = new RepositoryIncidencia();
            return repository.GetIncidencia().Select(x => x.status);
        }
      public  void Delete(Incidencias inci)
        {
            IRepositoryIncidencia repository = new RepositoryIncidencia();
     repository.Delete( inci);

        }
    }
}
