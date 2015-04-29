using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ScratchMVC3.Controllers
{
    public class MembershipController : Controller
    {
        // GET: Membership
        public ActionResult Registration()
        {
            return View();
        }
    }
}