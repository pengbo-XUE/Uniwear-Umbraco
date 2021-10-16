using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Umbraco.Core.Models.PublishedContent;

namespace Uniwear.core.ViewModels
{
    public class CatelogViewModel
    {
        public IEnumerable<IPublishedContent> productList{ get; set; }
    }
}
