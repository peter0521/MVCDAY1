using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MVC5DAY1.Models;

namespace MVC5DAY1.Controllers
{
    public class Customer_ViewController : Controller
    {
        private 客戶資料Entities db = new 客戶資料Entities();

        // GET: Customer_View
        public ActionResult Index()
        {
            return View(db.Customer_View.ToList());
        }
    }
}
