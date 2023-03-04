using Infraestructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Repository
{
    public interface IRepositorypCobro
    {
        IEnumerable<pCobro> GetpCobro();
        IEnumerable<string> GetpCobrodescription();
        IEnumerable<pCobro> GetpCobroByDescrition(String description);

        IEnumerable<pCobro> GetpCobropByCobroDetalle(int idCollectionPlanDetail);
        pCobro GetpCobroByID(int idCollectioPlan);
        void DeletepCobro(int id);
        pCobro Save(pCobro _pCobro, string[] selectedpCobroDetalle);
    }
}
