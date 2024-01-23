using Autofac;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IContainer = Autofac.IContainer;

namespace Presentation
{
    public class AutoFact
    {
        public static IContainer Inject()
        {
            var builder = new ContainerBuilder();
            ///builder.RegisterType<>().As<>;
            ///
            return builder.Build();
        }
    }
}
