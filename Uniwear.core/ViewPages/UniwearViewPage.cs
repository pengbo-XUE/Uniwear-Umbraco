using Umbraco.Core;
using Umbraco.Core.Cache;
using Umbraco.Core.Services;
using Umbraco.Web.Mvc;
using Current = Umbraco.Web.Composing.Current;

namespace Uniwear.core.ViewPages
{
    
    public abstract class UniwearViewPage<T> : UmbracoViewPage<T>
    {
        //public readonly IProductService productService;

        public UniwearViewPage() : this(
            //Current.Factory.GetInstance<IProductService>(),
            Current.Factory.GetInstance<ServiceContext>(),
            Current.Factory.GetInstance<AppCaches>()
        )
        {
        }
        public UniwearViewPage(/*IProductService _productService, */ServiceContext services, AppCaches appCaches)
        {
            //productService = _productService;
            Services = services;
            AppCaches = appCaches;
        }
    }

    public abstract class UniwearViewPage : UmbracoViewPage
    {
        //public readonly IProductService productService;
        public UniwearViewPage() : this(
            //Current.Factory.GetInstance<IProductService>(),
            Current.Factory.GetInstance<ServiceContext>(),
            Current.Factory.GetInstance<AppCaches>()
        )
        { 
        }

        public UniwearViewPage(/*IProductService _productService,*/ ServiceContext services, AppCaches appCaches)
        {
            //productService = _productService;
            Services = services;
            AppCaches = appCaches;
        }
    }

}
