using Infraestructure.Models;
using Infraestructure.Utils;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;


namespace Infraestructure.Repository
{
    public class RepositoryIncidencia : IRepositoryIncidencia
    {
        public IEnumerable<Incidencias> GetIncidencia()
        {
            IEnumerable<Incidencias> lista = null;
            try
            {


                using (MyContext ctx = new MyContext())
                {
                    ctx.Configuration.LazyLoadingEnabled = false;

                    lista = ctx.Incidencias.Include("Usuario").ToList();



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
        public Incidencias GetIncidenciaByID(int id)
        {
            Incidencias oIncidencia = null;
            try
            {
                using (MyContext ctx = new MyContext())
                {
                    ctx.Configuration.LazyLoadingEnabled = false;
                  
                    oIncidencia = ctx.Incidencias.
                        Where(i => i.Idincidence == id).
                        Include("Usuario").
                     
                        FirstOrDefault();

                }
                return oIncidencia;
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
        public Incidencias Save(Incidencias _Incidencias, int idusuario)
        {
            int retorno = 0;
            Incidencias oIncidencia = null;

            using (MyContext ctx = new MyContext())
            {
                ctx.Configuration.LazyLoadingEnabled = false;
                oIncidencia = GetIncidenciaByID((int)_Incidencias.Idincidence);
             

                if (oIncidencia == null)
                {

      
                   
                           
               
                            _Incidencias.idUser=idusuario;


                      
                    
                  
                    ctx.Incidencias.Add(_Incidencias);
                    
                    retorno = ctx.SaveChanges();
                    
                }
                else
                {

                    ctx.Incidencias.Add(_Incidencias);
                    ctx.Entry(_Incidencias).State = EntityState.Modified;
                    retorno = ctx.SaveChanges();



                    _Incidencias.idUser = idusuario;

                    ctx.Entry(_Incidencias).State = EntityState.Modified;
                        retorno = ctx.SaveChanges();
                    
                }
            }

            if (retorno >= 0)
                oIncidencia = GetIncidenciaByID((int)_Incidencias.Idincidence);

            return oIncidencia;
        }
        void IRepositoryIncidencia.Delete(Incidencias inci)
        {
            

            try
            {int id = Convert.ToInt32(inci.Idincidence);
             using (MyContext ctx = new MyContext())
                {




                    /*  var items = ctx.Incidencias.Where(item => item.Idincidence == inci.Idincidence);
                      foreach (var item in items)
                      {
                          ctx.Incidencias.Remove(item);
                      }*/



                    /*  ctx.Incidencias.Remove((from p in ctx.Incidencias
                                        where p.Idincidence == inci.Idincidence
                                       select p).Single());
                      ctx.SaveChanges();*/



                  
                    
                    

                }

            }
            catch (Exception e)
            {
                string error = e.Message;
               
            }
      
        }


    }
}
