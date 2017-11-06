using Sispar.Core.EF.Repositories;
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

        protected override void Dispose(bool disposing)
        {
            _ctx.Dispose();
        }
    }
}