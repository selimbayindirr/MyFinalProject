using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DependecyResolvers
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {
            //services.AddTransient
            // services.AddSingleton

            services.AddScoped<IProductService, ProductManager>(); 
            services.AddScoped<IProductDal, EfProductDal>();

            //Autofac Kullanımı 


       
        }
    }
}
