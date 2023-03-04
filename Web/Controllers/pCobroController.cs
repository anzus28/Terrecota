using ApplicationCore.Services;
using Infraestructure.Models;
using Infraestructure.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;

namespace Web.Controllers
{
    public class pCobroController : Controller
    {
        // GET: pCobro
        public ActionResult Index()
        {
            IEnumerable<pCobro> lista = null;
            try
            {
                IServicepCobro _ServicepCobro = new ServicepCobro();
                lista = _ServicepCobro.GetpCobro();
                ViewBag.title = "Lista pCobros";
            
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

        // GET: pCobro/Details/5
        public ActionResult Details(int id)
        {
            IServicepCobro _ServicepCobro  = new ServicepCobro ();
            pCobro  _pCobro  = null;

            try
            {
                // Si va null
                if (id == null)
                {
                    return RedirectToAction("Index");
                }

                _pCobro = _ServicepCobro.GetpCobroByID(Convert.ToInt32(id));
                if (_pCobro == null)
                {
                    TempData["Message"] = "No existe el plan de Cobro solicitado";
                    TempData["Redirect"] = "plan de Cobro";
                    TempData["Redirect-Action"] = "Index";
                    // Redireccion a la captura del Error
                    return RedirectToAction("Default", "Error");
                }
                return View(_pCobro);
            }
            catch (Exception ex)
            {
                // Salvar el error en un archivo 
                Log.Error(ex, MethodBase.GetCurrentMethod());
                TempData["Message"] = "Error al procesar los datos! " + ex.Message;
                TempData["Redirect"] = "Libro";
                TempData["Redirect-Action"] = "IndexAdmin";
                // Redireccion a la captura del Error
                return RedirectToAction("Default", "Error");
            }
        }

        // GET: pCobro/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: pCobro/Create
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

        // GET: pCobro/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: pCobro/Edit/5
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

        // GET: pCobro/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: pCobro/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
