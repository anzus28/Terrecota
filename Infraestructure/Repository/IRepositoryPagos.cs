using Infraestructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Repository
{
    public interface IRepositoryPagos
    {

        IEnumerable<Pagos> GetPagos();
        IEnumerable<string> GetPagosdescription();
        IEnumerable<Pagos> GetDeudasByIdResidencia(int IdResidencia);
        IEnumerable<Pagos> GetPagosCancelByIdResidencia(int IdResidencia);

        Pagos GetPagosByID(int idCollectionPlan);
        void DeletePagos(int id);
        Pagos Save(Pagos _Pagos, string[] selectedPagosDetalle);
    }
}
