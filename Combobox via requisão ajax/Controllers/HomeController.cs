using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Combobox_via_requisão_ajax.Models;

namespace Combobox_via_requisão_ajax.Controllers
{
    public class HomeController : Controller
    {
        
        [HttpGet]
        public ActionResult Index()
        {
            var model = new Model();
            this.CreateLists(model);
            return View(model);
        }

        [HttpPost]
        public ActionResult Index(Model model)
        {
            this.CreateLists(model);
            return View(model);
        }

        
        private void CreateLists(Model model)
        {
            ViewBag.Valor = new SelectList(this.GetValores(), "ValorID", "Descricao", model.Valor);            
        }

        private List<ValorModel> GetValores()
        {
            var valores = new List<ValorModel>();
            for (int indice = 1; indice <= 10; indice++)
            {
                var tmp = indice.ToString("00");
                valores.Add(new ValorModel
                {
                    ValorID = indice,
                    Descricao = "Valor " + tmp
                });
            }
            return valores;
        }
    }
}