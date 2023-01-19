using Autofac;
using ETicaretAkinsoft.Business.Abstract;
using ETicaretAkinsoft.Business.Concrate;
using ETicaretAkinsoft.DataAccess.Abstract;
using ETicaretAkinsoft.DataAccess.Concrate.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAkinsoft.Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ProductManager>().As<IProductService>().SingleInstance();
            builder.RegisterType<EfProductDal>().As<IProductDal>().SingleInstance();


        }
    }
}
