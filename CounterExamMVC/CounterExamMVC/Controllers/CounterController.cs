using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using CounterExamMVC.Entity;

namespace CounterExamMVC.Controllers
{
    public class CounterController : Controller
    {
        // GET: Counter
        public ActionResult Index()
        {
            return View();
        }
        
        [Route("counter/insert/{c}")]
        [HttpPost]
        public JsonResult InsertCounter(int c)
        { 
            using (var db = new TestDBEntities())
            {
                Counter count = new Counter()
                {
                    Counter1 = c
                };

                db.Counter.Add(count);
                db.SaveChanges();

                return Json("success", JsonRequestBehavior.AllowGet);
            }

        }

    }
}