using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Umbraco.Core.Models.PublishedContent;

namespace Uniwear.core.ViewModels
{
    public class ProductViewModel
    {
        public IEnumerable<IPublishedContent> results { get; set; }
        public int pageSize { get; set; }
        public int pageNumber { get; set; }
        public double pageCount { get; set; }
        
    }
}
