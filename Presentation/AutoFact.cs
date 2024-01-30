using Appliaction.Contract;
using Appliaction.Services;
using Autofac;
using Context;
using Infrastructure.Contract;
using Infrastructure.Repositores;
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
            builder.RegisterType<CategoryService>().As<ICategoryService>();
            builder.RegisterType<CatgoryRepositry>().As<ICategoryRepository>();

            builder.RegisterType<ProductService>().As<IProductService>();
            builder.RegisterType<ProudectRepository>().As<IProudectRepository>();
           
            builder.RegisterType<CartService>().As<ICartService>();
            builder.RegisterType<CartRepository>().As<ICartRepository>();
            builder.RegisterType<CartproudectRepository>().As<ICartproudectRepository>();

            builder.RegisterType<OrderService>().As<IOrderService>();
            builder.RegisterType<OrderRepository>().As<IOrderRepository>();

            builder.RegisterType<_Context>().As<_Context>();
            
            return builder.Build();
        }
    }
}
