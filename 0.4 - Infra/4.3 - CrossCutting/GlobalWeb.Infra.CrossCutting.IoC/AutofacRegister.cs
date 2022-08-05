using Autofac;
using GlobalWeb.Application;
using GlobalWeb.Application.Interfaces;
using GlobalWeb.Domain;
using GlobalWeb.Domain.Interfaces;
using GlobalWeb.Infra.Repository;
using GlobalWeb.Infra.Repository.Interfaces;

namespace GlobalWeb.Infra.CrossCutting.IoC
{
    public class AutofacRegister : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ClientApplication>()
                .As<IClientApplication>()
                .InstancePerDependency();

            builder.RegisterType<ClientDomain>()
                .As<IClientDomain>()
                .InstancePerDependency();

            builder.RegisterType<ClientRepository>()
                .As<IClientRepository>()
                .InstancePerDependency();
        }
    }
}
