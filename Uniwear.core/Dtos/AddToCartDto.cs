using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uniwear.core.Dtos
{
   
    public class AddToCartDto
    {
        public string productReference { get; set; }
        public decimal quantity { get; set; }
        public string size { get; set; }
    
    }
}
 