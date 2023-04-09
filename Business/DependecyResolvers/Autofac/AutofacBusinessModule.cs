using Autofac.Core;
using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Abstract;

namespace Business.DependecyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            //base.Load(builder);
            //builder.RegisterType<>
            builder.RegisterType<ProductManager>().As<IProductService>().SingleInstance();//SingleInstance:tek bir instance oluştur.
            builder.RegisterType<EfProductDal>().As<IProductDal>().SingleInstance();

        }

    }
}
