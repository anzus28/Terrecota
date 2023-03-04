using Infraestructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Services
{
 public interface IServicepCobro
    {
         IEnumerable<pCobro> GetpCobro();
        IEnumerable<string> GetpCobrodescription();
        IEnumerable<pCobro> GetpCobroByDescrition(String description);
    
        IEnumerable<pCobro> GetpCobrobypCobroDetalle(int idCollectionPlanDetail);
        pCobro GetpCobroByID(int idCollectionPlan);
        void DeletepCobro(int id);
        pCobro Save(pCobro _pCobro, string[] selectedpCobroDetalle);
    }
}
