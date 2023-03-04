using Infraestructure.Models;
using Infraestructure.Utils;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Repository
{
    public class RepositoryPagos : IRepositoryPagos
    {
        public void DeletePagos(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Pagos> GetDeudasByIdResidencia(int IdResidencia)
        {
            IEnumerable<Pagos> oPago = null;
            try
            {
                using (MyContext ctx = new MyContext())
                {
                    ctx.Configuration.LazyLoadingEnabled = false;
                    //Obtener Deudas por Idresidencia
                    oPago = ctx.Pagos.
                        Where(l => l.idHome == IdResidencia && l.status == "Pendiente").Include("pCobro").
                        Include("Residencia").ToList();

                }
                return oPago;
            }

            catch (DbUpdateException dbEx)
            {
                string mensaje = "";
                Log.Error(dbEx, System.Reflection.MethodBase.GetCurrentMethod(), ref mensaje);
                throw new Exception(mensaje);
            }
            catch (Exception ex)
            {
                string mensaje = "";
                Log.Error(ex, System.Reflection.MethodBase.GetCurrentMethod(), ref mensaje);
                throw;
            }
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

            IEnumerable<Pagos> oPago = null;
            try
            {
                using (MyContext ctx = new MyContext())
                {
                    ctx.Configuration.LazyLoadingEnabled = false;
                    //Obtener Pagos por IdResidencia
                    oPago = ctx.Pagos.
                        Where(l => l.idHome == IdResidencia && l.status == "Cancelado").Include("pCobro").Include("Residencia").ToList();



                }
                return oPago;
            }

            catch (DbUpdateException dbEx)
            {
                string mensaje = "";
                Log.Error(dbEx, System.Reflection.MethodBase.GetCurrentMethod(), ref mensaje);
                throw new Exception(mensaje);
            }
            catch (Exception ex)
            {
                string mensaje = "";
                Log.Error(ex, System.Reflection.MethodBase.GetCurrentMethod(), ref mensaje);
                throw;
            }

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
