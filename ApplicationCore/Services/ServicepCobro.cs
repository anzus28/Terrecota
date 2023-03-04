

using Infraestructure.Models;
using Infraestructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Services
{
    public class ServicepCobro : IServicepCobro
    {
        public void DeletepCobro(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<pCobro> GetpCobro()
        {
            IRepositorypCobro repository = new RepositorypCobro();
            return repository.GetpCobro();
        }

        public IEnumerable<pCobro> GetpCobroByDescrition(string description)
        {
            IRepositorypCobro repository = new RepositorypCobro();
            return repository.GetpCobroByDescrition(description);
        }

        public pCobro GetpCobroByID(int idCollectionPlan)
        {
            IRepositorypCobro repository = new RepositorypCobro();
            return repository.GetpCobroByID(idCollectionPlan);
        }

        public IEnumerable<pCobro> GetpCobrobypCobroDetalle(int idCollectionPlanDetail)
        {
            IRepositorypCobro repository = new RepositorypCobro();
            return repository.GetpCobropByCobroDetalle(idCollectionPlanDetail);
        }

        public IEnumerable<string> GetpCobrodescription()
        {
           /*  IRepositorypCobro repository = new RepositorypCobro();
            repository.GetpCobrodescription().Select(x => x.description);*/
            return null;    }

        

        public pCobro Save(pCobro _pCobro, string[] selectedpCobroDetalle)
        {
            IRepositorypCobro repository = new RepositorypCobro();
            return repository.Save(_pCobro, selectedpCobroDetalle);
        }
    }
}
