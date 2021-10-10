using System.Threading;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;
using Vendr.Core.Api;
using Vendr.Core.Models;
using Vendr.Extensions;
using Vendr.Umbraco.Models;
using Vendr.Core;

namespace Uniwear.core.Extensions
{
    public static class PublishedContentExtensions
    {
        public static string GetProductReference(this IPublishedContent content)
        {
            return content.Key.ToString();
        }

        public static IProductSnapshot AsVendrProducts(this IPublishedContent content)
        {
            return VendrApi.Instance.GetProduct(content.GetProductReference(), Thread.CurrentThread.CurrentCulture.Name);
        }

        public static Price CalculatePrice(this IPublishedContent content)
        {
            return content.AsVendrProducts()?.CalculatePrice();
        }

       
        public static StoreReadOnly GetStore(this IPublishedContent content) 
        {
            return content.Root().Value<StoreReadOnly>("store");
        }

        public static OrderReadOnly GetCunrrentOrder(this IPublishedContent content) 
        {
            return VendrApi.Instance.GetCurrentOrder(content.GetStore().Id);
        }
    }
}
