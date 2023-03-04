using Infraestructure.Models;
using Infraestructure.Utils;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;





namespace Infraestructure.Repository
{
    public  class RepositorypCobro : IRepositorypCobro
    {
        public void DeletepCobro(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<pCobro> GetpCobro()
        {
            IEnumerable<pCobro> lista = null;
            try
            {


                using (MyContext ctx = new MyContext())
                {
                    ctx.Configuration.LazyLoadingEnabled = false;
                 
                    lista = ctx.pCobro.Include("pCobrodetalle").ToList();

         

                }
                return lista;
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

        public IEnumerable<pCobro> GetpCobroByDescrition(string description)
        {
            throw new NotImplementedException();
        }

        public pCobro GetpCobroByID(int idCollectionPlan)
        {
            pCobro  opCobro  = null;
            try
            {
                using (MyContext ctx = new MyContext())
                {
                    ctx.Configuration.LazyLoadingEnabled = false;
                    //Obtener pCobro  por ID incluyendo el autor y todas sus categorías
                    opCobro  = ctx.pCobro .
                        Where(l => l.idCollectionPlan  == idCollectionPlan).
                        
                        Include("pCobroDetalle").
                        FirstOrDefault();

                }
                return opCobro ;
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

        public IEnumerable<string> GetpCobrodescription()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<pCobro> GetpCobropByCobroDetalle(int idCollectionPlanDetail)
        {
            IEnumerable<pCobro> lista = null;
            try
            {
                using (MyContext ctx = new MyContext())
                {
                    ctx.Configuration.LazyLoadingEnabled = false;

                    lista = ctx.pCobro.Include(c => c.pCobroDetalle).
                        Where(c => c.pCobroDetalle.Any(o => o.idCollectionPlanDetail == idCollectionPlanDetail))
                        .ToList();

                }
                return lista;
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

        public pCobro Save(pCobro _pCobro, string[] selectedpCobroDetalle)
        {
            throw new NotImplementedException();
        }

        
    }
}
