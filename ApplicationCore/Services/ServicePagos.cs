using Infraestructure.Models;
using Infraestructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Services
{
    public class ServicePagos : IServicePagos
    {
        public void DeletePagos(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Pagos> GetDeudasByIdResidencia(int IdResidencia)
        {
            IRepositoryPagos repository = new RepositoryPagos();
            return repository.GetDeudasByIdResidencia(IdResidencia);
        }

        public IEnumerable<Pagos> GetPagos()
        {
            throw new NotImplementedException();
        }

        public Pagos GetPagosByID(int idCollectionPlan)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Pagos> GetPagosCancelByIdResidencia(int IdResidencia)
        {
            IRepositoryPagos repository = new RepositoryPagos();
            return repository.GetPagosCancelByIdResidencia(IdResidencia);
        }

        public IEnumerable<string> GetPagosdescription()
        {
            throw new NotImplementedException();
        }

        public Pagos Save(Pagos _Pagos, string[] selectedPagosDetalle)
        {
            throw new NotImplementedException();
        }
    }
}
