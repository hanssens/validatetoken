using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ValidateToken.Controllers
{
    public class PagesController : Controller
    {
        //
        // GET: /Pages/

        public ActionResult Index()
        {
            return View();
        }

        [RequireSessionKey("SessionKey")]
        public ActionResult AuthorizedCall()
        {
            return View();
        }

    }
}
