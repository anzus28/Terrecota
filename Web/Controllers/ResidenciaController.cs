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
    public class ResidenciaController : Controller
    {
        // GET: Residencia
        public ActionResult Index()
        {
            IEnumerable<Residencia> lista = null;
            try
            {
                ServiceResidencia _ServiceResidencia = new ServiceResidencia();
                lista = _ServiceResidencia.GetResidencia();
                ViewBag.title = "Lista Residencias";

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


        public ActionResult IndexAdmin()
        {
            IEnumerable<Residencia> lista = null;
            try
            {
                IServiceResidencia _ServiceResidencia = new ServiceResidencia();
                lista = _ServiceResidencia.GetResidencia();


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
        // GET: Residencia/Details/5
        public ActionResult Details(int? id)
        {
            ServiceResidencia _ServiceResidencia = new ServiceResidencia();
            Residencia residencia = null;

            try
            {
                // Si va null
                if (id == null)
                {
                    return RedirectToAction("Index");
                }

                residencia = _ServiceResidencia.GetResidenciaByID(Convert.ToInt32(id));
                if (residencia == null)
                {
                    TempData["Message"] = "No existe la residencia solicitada";
                    TempData["Redirect"] = "Residencia";
                    TempData["Redirect-Action"] = "Index";
                    // Redireccion a la captura del Error
                    return RedirectToAction("Default", "Error");
                }
                return View(residencia);
            }
            catch (Exception ex)
            {
                // Salvar el error en un archivo 
                Log.Error(ex, MethodBase.GetCurrentMethod());
                TempData["Message"] = "Error al procesar los datos! " + ex.Message;
                TempData["Redirect"] = "Residencia";
                TempData["Redirect-Action"] = "IndexAdmin";
                // Redireccion a la captura del Error
                return RedirectToAction("Default", "Error");
            }
        }

        // GET: Residencia/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Residencia/Create
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

        // GET: Residencia/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Residencia/Edit/5
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

        // GET: Residencia/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Residencia/Delete/5
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


