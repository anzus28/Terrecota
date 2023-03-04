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
    public class EstadoCuentaController : Controller
    {
        // GET: EstadoCuenta
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

        public ActionResult Deudas(int id)
        {
            IEnumerable<Pagos> lista = null;
            Pagos pago = null;

            
                // Si va null
                if (id == null)
                {
                    return RedirectToAction("Index");
                }

                try
                {
                    ServicePagos _ServicePagos = new ServicePagos();
                    lista = _ServicePagos.GetDeudasByIdResidencia(id);
                    ViewBag.title = "Lista Residencias";

                    return View(lista);
                }

                catch
                {
                    if (lista == null)
                    {
                        TempData["Message"] = "No existe la residencia solicitada";
                        TempData["Redirect"] = "Residencia";
                        TempData["Redirect-Action"] = "Index";
                        // Redireccion a la captura del Error
                        return RedirectToAction("Default", "Error");
                    }
                   
                }
            return RedirectToAction("Index");


        }

        public ActionResult PagosCancelados(int? id)
        {
            IEnumerable<Pagos> lista = null;


            // Si va null
            if (id == null)
            {
                return RedirectToAction("Index");
            }

            try
            {
                ServicePagos _ServicePagos = new ServicePagos();
                lista = _ServicePagos.GetPagosCancelByIdResidencia(Convert.ToInt32(id));
                ViewBag.title = "Lista Residencias";

                return View(lista);
            }

            catch
            {
                if (lista == null)
                {
                    TempData["Message"] = "No existe la residencia solicitada";
                    TempData["Redirect"] = "Residencia";
                    TempData["Redirect-Action"] = "Index";
                    // Redireccion a la captura del Error
                    return RedirectToAction("Index", "Error");
                }

            }
            return RedirectToAction("Index");


        }


        // GET: EstadoCuenta/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: EstadoCuenta/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EstadoCuenta/Create
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

        // GET: EstadoCuenta/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: EstadoCuenta/Edit/5
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

        // GET: EstadoCuenta/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: EstadoCuenta/Delete/5
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
