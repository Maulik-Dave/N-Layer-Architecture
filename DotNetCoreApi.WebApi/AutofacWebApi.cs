using Autofac;
using DotNetCoreApi.Data.Infrastructure;
using DotNetCoreApi.Data.Repository;
using DotNetCoreApi.Service;
using RestSharp;
using System.Reflection;
using Module = Autofac.Module;

namespace DotNetCoreApi.WebApi
{
    public class AutofacWebApi : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            var webAssembly = Assembly.GetExecutingAssembly();
            var repoAssembly = Assembly.GetAssembly(typeof(EmployeeMasterRepository));
            var serAssembly = Assembly.GetAssembly(typeof(EmployeeMasterService));
            builder.RegisterAssemblyTypes(webAssembly, serAssembly, repoAssembly).AsImplementedInterfaces();

            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>().InstancePerLifetimeScope();
            builder.RegisterType<DBConCall>().As<IDBCon>().InstancePerLifetimeScope();

            //Repository
            builder.RegisterAssemblyTypes(webAssembly, serAssembly, repoAssembly)
                .Where(t => t.Name.EndsWith("Repository"))
                .AsImplementedInterfaces().InstancePerLifetimeScope();

            // Services
            builder.RegisterAssemblyTypes(webAssembly, serAssembly, repoAssembly)
               .Where(t => t.Name.EndsWith("Service"))
               .AsImplementedInterfaces().InstancePerLifetimeScope();

            builder.RegisterType<HttpContextAccessor>().As<IHttpContextAccessor>();
            builder.RegisterType<RestClient>().As<IRestClient>();
        }
    }
}