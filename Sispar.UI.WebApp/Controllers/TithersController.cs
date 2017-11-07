using Sispar.Core.EF.Repositories;
using Sispar.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sispar.UI.WebApp.Controllers
{
    [Authorize]
    public class TithersController : Controller
    {
        private readonly TitherRepository _ctx = new TitherRepository();

        public ActionResult Index()
        {
            var tithers = _ctx.GetAll().OrderBy(t => t.Name);
            return View(tithers);
        }

        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(Tither tither)
        {
            tither.NameSpouse = "AAAA";
            tither.MarriegeDate = DateTime.Now;
            tither.MatiralStatus = "2";

            _ctx.Add(tither);

            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            var tither = _ctx.GetById(id);

            if (tither == null)
                return HttpNotFound();

            return View(tither);
        }

        [HttpPost]
        public ActionResult Delete(Tither tAux)
        {
            var tither = _ctx.GetById(tAux.Id);
            _ctx.Delete(tither);

            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            _ctx.Dispose();
        }
    }
}