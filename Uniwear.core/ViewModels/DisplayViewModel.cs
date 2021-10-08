using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web.PublishedModels;

namespace Uniwear.core.ViewModels
{
    public class DisplayViewModel
    {
        [Required (ErrorMessage ="Please pick a size")]
        public string size { get; set; }
        public IPublishedContent productDisplay { get; set; }
    }
}
