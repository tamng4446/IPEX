using IPEx.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Umbraco.Web.Mvc;

namespace IPEx.Controllers
{
    public class MemberController : SurfaceController
    {
        // GET: Member
        [ChildActionOnly]
        public ActionResult MemberRegistration()
        {
            return PartialView("MemberRegistration", new RegisterModel());
        }
    }
}