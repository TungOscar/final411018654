using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace web411018654final.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Music()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Music(string name, int number)
        {
            if (number==1)
            {
                ViewBag.number = "請輸入姓名";
            }

            return View();
        }
    }
}