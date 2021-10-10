using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Umbraco.Web.Mvc;
using System.Web.Mvc;

namespace Uniwear.core.Controllers
{
    class ProductSurfaceController : SurfaceController
    {
        public ActionResult RenderForm() 
        {
            return PartialView();
        }
    }
}
