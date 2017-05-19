using Application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RequestItemCache.Helpers
{
    public class GetCachedModelData
    {
        public static ResultModel GetModelData()
        {
            ResultModel model;
            if (System.Web.HttpContext.Current.Items.Contains("key"))
            {
                model = System.Web.HttpContext.Current.Items["key"] as ResultModel;
            }
            else
            {
                GenericRepo repo = new GenericRepo();
                model = repo.GetModelData();
                System.Web.HttpContext.Current.Items["key"] = model;
            }
            return model;
        }
    }
}