using Uniwear.core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Umbraco.Core.Composing;
using Umbraco.Core;


namespace Uniwear.core.Compositions
{
    class RegisterServicesComposer : IUserComposer
    {
        public void Compose(Composition composition)
        {
            //composition.Register<IEmailService, EmailService>(Lifetime.Singleton);
            //composition.Register<IProductService, ProductService>(Lifetime.Singleton);
        }
    }
}

