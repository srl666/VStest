using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using TourismWeb.DAL;
using TourismWeb.Models;

namespace TourismWeb.Controllers
{
    public class StatementController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Create()
        {
            ViewBag.Message = "CreateTest page.";

            return View();
        }


        //Async  way to access  
        [HttpPost]
        [AllowAnonymous]
        public async Task<ActionResult> Create(Customer model)
        {

            if (ModelState.IsValid)
            {

                using (var db = new MyDbContext())
                {

                    db.Customers.Add(model);
                    await db.SaveChangesAsync();
                }

            }

            return View("Index");
        }

        //Normal way to access
        //[HttpPost]
        //[AllowAnonymous]
        //public ActionResult Create(Customer model)
        //{


        //    if (ModelState.IsValid)
        //    {
        //        using (var db = new TourismContext())
        //        {

        //            db.Customers.Add(model);
        //            db.SaveChanges();
        //        }
        //    }

        //    // 如果執行到這裡，發生某項失敗，則重新顯示表單
        //    return View("Index");
        //}
    }
}