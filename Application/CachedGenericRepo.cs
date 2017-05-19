using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public class CachedGenericRepo : IGenericRepo
    {
        private readonly IGenericRepo _repo;

        public CachedGenericRepo(IGenericRepo repo)
        {
            _repo = repo;
        }
        public ResultModel GetModelData()
        {
            ResultModel model;
            if (System.Web.HttpContext.Current.Items.Contains("key"))
            {
                model = System.Web.HttpContext.Current.Items["key"] as ResultModel;
            }
            else
            {
                model = _repo.GetModelData();
                System.Web.HttpContext.Current.Items["key"] = model;
            }
            return model;
        }
    }
}
