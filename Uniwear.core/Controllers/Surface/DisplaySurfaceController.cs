using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web.Mvc;
using Umbraco.Web.PublishedModels;
using Uniwear.core.ViewModels;

namespace Uniwear.core.Controllers
{
    public class DisplaySurfaceController : SurfaceController
    {
        [HttpGet]
        public ActionResult RenderProduct(DisplayViewModel viewModel) 
        {
            //DisplayViewModel viewModel = new DisplayViewModel() { productDisplay = _productDisplay};
            return PartialView("~/Views/Partials/Display/DisplayProduct.cshtml", viewModel); 
        }

        [HttpPost]
        public ActionResult RenderProduct(DisplayViewModel viewModel, string Msg ="Product added to cart")
        {
            //DisplayViewModel viewModel = new DisplayViewModel() { productDisplay = _productDisplay};
            ViewData["Msg"] = Msg;
            return PartialView("~/Views/Partials/Display/DisplayProduct.cshtml", viewModel);
        }
    }
}
