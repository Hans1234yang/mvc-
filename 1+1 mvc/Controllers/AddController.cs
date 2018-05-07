using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _1_1_mvc.Controllers
{
    public class AddController : Controller
    {
        // GET: Add
        public ActionResult jiafa()
        {
            return View();
        }

        [HttpPost]
        public JsonResult Xiangjia(string a,string b)
        {
            int c=0;
            c = Convert.ToInt32(a) + Convert.ToInt32(b);


            return Json(c);
        }
        public JsonResult Xiangjian(string a,string b)
        {
            int c = 0;
            c = Convert.ToInt32(a) - Convert.ToInt32(b);

            return Json(c);
        }

        public JsonResult XiangCheng(string a,string b)
        {
            int c = 0;

            c = Convert.ToInt32(a) * Convert.ToInt32(b);

            return Json(c);
        }
    }
}