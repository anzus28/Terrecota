using ApplicationCore.Services;
using Infraestructure.Models;
using Infraestructure.Repository;
using Infraestructure.Utils;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;

namespace Web.Controllers
{
    public class IncidenciaController : Controller
    {
        // GET: Incidencia
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult IndexAdmin(Usuario usuario)
        {
            IEnumerable<Incidencias> lista = null;
            try
            {
                IServiceIncidencia _ServiceIncidencia = new ServiceIncidencia();
                lista = _ServiceIncidencia.GetIncidencia();
                //Lista de autocompletado de autores
               // ViewBag.listaNombres = _ServiceIncidencia.GetIncidenciaNombres();

                return View(lista);
            }
            catch (Exception ex)
            {
                Log.Error(ex, MethodBase.GetCurrentMethod());
                TempData["Message"] = "Error al procesar los datos! " + ex.Message;

                // Redireccion a la captura del Error
                return RedirectToAction("Default", "Error");
            }
        }


        // GET: Incidencia/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Incidencia/Create
        [HttpGet]
        public ActionResult Create()
        {
       

            return View();
        }

        // POST: Incidencia/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Incidencia/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Incidencia/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Incidencia/Delete/5
        public ActionResult Delete(int id)
        {
            IServiceIncidencia _ServiceIncidencia = new ServiceIncidencia();
         
      
            return View(   _ServiceIncidencia.GetIncidenciaByID(id));
        }

        // POST: Incidencia/Delete/5
        [HttpPost]
        public ActionResult Delete(Incidencias inci, FormCollection collection)
        {
            IServiceIncidencia _ServiceIncidencia = new ServiceIncidencia();
            _ServiceIncidencia.Delete(inci);
            return View();
        }
        public ActionResult Save(Incidencias _Incidencias)
        {
           
         MemoryStream target = new MemoryStream();
     
            IServiceIncidencia _ServiceIncidencia = new ServiceIncidencia();
            try
            {
                
             
                if (ModelState.IsValid)
                {
                   _ServiceIncidencia.Save(_Incidencias,1);
                }
                else
                {
                    
                    Utils.Util.ValidateErrors(this);
                 
                    if (_Incidencias.Idincidence > 0)
                    {
                        return (ActionResult)View("Edit", _Incidencias);
                    }
                    else
                    {
                        return View("Create", _Incidencias);
                    }
                }

                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                // Salvar el error en un archivo 
                Log.Error(ex, MethodBase.GetCurrentMethod());
                TempData["Message"] = "Error al procesar los datos! " + ex.Message;
                TempData["Redirect"] = "incidencia";
                TempData["Redirect-Action"] = "IndexAdmin";
                // Redireccion a la captura del Error
               return RedirectToAction("Default", "Error");
            }
        }
    }
}
