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
    public class RepositoryResidencia:IRepositoryResidencia
    {
        public void DeleteResidencia(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Residencia> GetResidencia()
        {
            IEnumerable<Residencia> lista = null;
            try
            {


                using (MyContext ctx = new MyContext())
                {
                    ctx.Configuration.LazyLoadingEnabled = false;
                    //Obtener todos las residencias incluyendo al usuario
                    lista = ctx.Residencia.Include("Usuario").ToList();
                   

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

        public IEnumerable<Residencia> GetResidenciaByNombreUsuario(String nombre)
        {
            IEnumerable<Residencia> oResidencia = null;
            try
            {
                using (MyContext ctx = new MyContext())
                {
                    ctx.Configuration.LazyLoadingEnabled = false;
                    //Obtener libros por Autor
                  //  oResidencia = ctx.Residencia.Where(l => l.IdLibro == idAutor).Include("Autor").ToList();



                }
                return oResidencia;
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

        public IEnumerable<Residencia> GetResidenciaByUsuario(int idUsuario)
        {
            IEnumerable<Residencia> lista = null;
            try
            {
                using (MyContext ctx = new MyContext())
                {
                    ctx.Configuration.LazyLoadingEnabled = false;
                    //Obtener los libros que pertenecen a una categoría
                    /*  lista = ctx.Residencia.Include(c => c.owner).Where(c => c.Usuario.Any(o => o.idUser == idUser)).ToList();
  */

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

        public Residencia GetResidenciaByID(int id)
        {
            Residencia oResidencia = null;
            try
            {
                using (MyContext ctx = new MyContext())
                {
                    ctx.Configuration.LazyLoadingEnabled = false;
                    //Obtener libro por ID inluyendo el autor y todas sus categorías
                      oResidencia = ctx.Residencia.Where(l => l.idHome == id).Include("Usuario").
                           FirstOrDefault();

                }
                return oResidencia;
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



        public Residencia Save(Residencia residencia) { 
        {
            throw new NotImplementedException();
        }
    }
}
}
