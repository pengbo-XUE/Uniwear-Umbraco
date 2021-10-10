using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uniwear.core.Dtos
{
    public class UpdateCartDto
    {
        public OrderLineQuantityDto[] orderLines { get; set; }
    }

    public class OrderLineQuantityDto
    {
        public Guid Id {get; set; }
        public decimal quantity { get; set; }
    }
}
