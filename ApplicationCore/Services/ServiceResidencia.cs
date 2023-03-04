using Infraestructure.Models;
using Infraestructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Services
{
    public class ServiceResidencia : IServiceResidencia
    {
        public void DeleteResidencia(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Residencia> GetResidencia()
        {
            IRepositoryResidencia repository = new RepositoryResidencia();
            return repository.GetResidencia();
        }

        public Residencia GetResidenciaByID(int id)
        {
            IRepositoryResidencia repository = new RepositoryResidencia();
            return repository.GetResidenciaByID(id);
        }

        public IEnumerable<Residencia> GetResidenciaByNombreUsuario(string nombre)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Residencia> GetResidenciaByUsuario(int idUsuario)
        {
            throw new NotImplementedException();
        }

        public Residencia Save(Residencia residencia)
        {
            throw new NotImplementedException();
        }
    }
}
