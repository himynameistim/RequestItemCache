using Application;
using RequestItemCache.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RequestItemCache.Controllers
{
    public class HomeController : Controller
    {
     

        public ActionResult Index()
        {
            return View();
        }


        // Initial bad implementation

        //[ChildActionOnly]
        //public ActionResult PartialActionOne()
        //{
        //    GenericRepo repo = new GenericRepo();
        //    ResultModel model = repo.GetModelData();
        //    return PartialView(model);
        //}

        //[ChildActionOnly]
        //public ActionResult PartialActionTwo()
        //{
        //    GenericRepo repo = new GenericRepo();
        //    ResultModel model = repo.GetModelData();
        //    return PartialView(model);
        //}

















































        // Using Reqiest Items to cache the result

        //[ChildActionOnly]
        //public ActionResult PartialActionOne()
        //{
        //    ResultModel model;
        //    if (System.Web.HttpContext.Current.Items.Contains("key"))
        //    {
        //        model = System.Web.HttpContext.Current.Items["key"] as ResultModel;
        //    }
        //    else
        //    {
        //        GenericRepo repo = new GenericRepo();
        //        model = repo.GetModelData();
        //        System.Web.HttpContext.Current.Items["key"] = model;
        //    }
        //    return PartialView(model);
        //}

        //[ChildActionOnly]
        //public ActionResult PartialActionTwo()
        //{
        //    ResultModel model;
        //    if (System.Web.HttpContext.Current.Items.Contains("key"))
        //    {
        //        model = System.Web.HttpContext.Current.Items["key"] as ResultModel;
        //    }
        //    else
        //    {
        //        GenericRepo repo = new GenericRepo();
        //        model = repo.GetModelData();
        //        System.Web.HttpContext.Current.Items["key"] = model;
        //    }
        //    return PartialView(model);
        //}
































        // Using a helper method to keep the controllers clean
        //[ChildActionOnly]
        //public ActionResult PartialActionOne()
        //{
        //    ResultModel model = Helpers.GetCachedModelData.GetModelData();
        //    return PartialView(model);
        //}

        //[ChildActionOnly]
        //public ActionResult PartialActionTwo()
        //{
        //    ResultModel model = Helpers.GetCachedModelData.GetModelData();
        //    return PartialView(model);
        //}































        // Dependancy Injected and Decorated

        IGenericRepo _repo;

        public HomeController(IGenericRepo repo)
        {
            _repo = repo;
        }

        [ChildActionOnly]
        public ActionResult PartialActionOne()
        {
            ResultModel model = _repo.GetModelData();
            return PartialView(model);
        }

        [ChildActionOnly]
        public ActionResult PartialActionTwo()
        {
            ResultModel model = _repo.GetModelData();
            return PartialView(model);
        }



    }
}