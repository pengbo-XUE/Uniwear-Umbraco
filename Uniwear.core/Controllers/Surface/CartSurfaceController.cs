using System;
using System.Web.Mvc;
using Umbraco.Web.Mvc;
using Vendr.Core.Services;
using Vendr.Core.Session;
using Uniwear.core.Extensions;
using Uniwear.core.Dtos;
using Vendr.Common;
using Vendr.Extensions;
using Uniwear.core.ViewModels;

namespace Uniwear.core.Controllers
{
    public class CartSurfaceController : SurfaceController
    {
        private readonly ISessionManager _sessionManager;
        private readonly IOrderService _orderService;
        private readonly IUnitOfWorkProvider _workProvider;

        public CartSurfaceController(ISessionManager sessionManager,IOrderService orderService,IUnitOfWorkProvider workProvider) 
        {
            _sessionManager = sessionManager;
            _orderService = orderService;
            _workProvider = workProvider;
        }

        //displays number of item in count 
        [ChildActionOnly]
        public ActionResult CartCount() 
        {
            var store = CurrentPage.GetStore();
            var order = _sessionManager.GetCurrentOrder(store.Id);
            return PartialView("~/Views/Partials/Display/CartCount.cshtml", order?. TotalQuantity ?? 0);
        }
        [HttpPost]
        public ActionResult AddToCart(DisplayViewModel postModel, string pageProdcutReference) 
        {
            
            try
            {
                using (var uow = _workProvider.Create()) 
                {
                    var store = CurrentPage.GetStore();
                    var order = _sessionManager.GetOrCreateCurrentOrder(store.Id)
                        .AsWritable(uow)
                        .AddProduct(pageProdcutReference, postModel.quantity);
                    _orderService.SaveOrder(order);
                    uow.Complete();
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("productReference", "Failed to add product to cart");
                return CurrentUmbracoPage();
            }
            TempData["addedProductReference"] = postModel.productReference;
            return RedirectToCurrentUmbracoPage();
        }
        [HttpPost]
        public ActionResult UpdateCart(UpdateCartDto postModel)
        {

            try
            {
                using (var uow = _workProvider.Create())
                {
                    var store = CurrentPage.GetStore();
                    var order = _sessionManager.GetOrCreateCurrentOrder(store.Id)
                        .AsWritable(uow);
                    foreach (var orderLine in  postModel.orderLines)
                    {
                        order.WithOrderLine(orderLine.Id).SetQuantity(orderLine.quantity);
                    }
                    _orderService.SaveOrder(order);
                    uow.Complete();
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("productReference", "Failed to update Cart");
                return CurrentUmbracoPage();
            }
            TempData["cartUpdate"] = "true";
            return RedirectToCurrentUmbracoPage();
        }
        [HttpGet]
        public ActionResult RemoveFromCart(RemoveFromCartDto postModel)
        {

            try
            {
                using (var uow = _workProvider.Create())
                {
                    var store = CurrentPage.GetStore();
                    var order = _sessionManager.GetOrCreateCurrentOrder(store.Id)
                        .AsWritable(uow)
                        .RemoveOrderLine(postModel.orderLineId);
                  
                    _orderService.SaveOrder(order);
                    uow.Complete();
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("productReference", "Failed to remove Cart");
                return CurrentUmbracoPage();
            }
            TempData["itemRemoved"] = "true";
            return RedirectToCurrentUmbracoPage();
        }
        
    }
}
