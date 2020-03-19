using MainProject.SBussiness.LandingPage.Models.News;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MainProject.Controllers
{
    public class NewsController : Controller
    {
        // GET: News
        public ActionResult Index()
        {
            return View(new NewsViewModel());
        }
        public ActionResult Detail()
        {
            return View(new NewsDetailViewModel());
        }
        public ActionResult Introduction()
        {
            return View(new IntroductionViewModel());
        }
        //GET: OFFICE
        public ActionResult Office()
        {
            return View(new OfficeViewModel());
        }
        public ActionResult OfficeDetail()
        {
            return View(new OfficeDetailViewModel());
        }
        //GET: RECRUITMENT
        public ActionResult TuyenDung()
        {
            return View(new TuyenDungViewModel());
        }
        public ActionResult TuyenDungDetail()
        {
            return View(new TuyenDungDetailViewModel());
        }
    }
}