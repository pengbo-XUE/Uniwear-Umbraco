using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using Umbraco.Web.Mvc;

namespace Uniwear.core.Controllers.Surface
{
    public class CatelogSurfaceController : SurfaceController
    {
        [HttpPost]
        public JsonNetResult Filter(string jsonList, string name)
        {
            Session.Add("list", jsonList);

            var result = new JsonNetResult
            {
                Data = Session["list"]
            };

            return result;
        }
    }
}
