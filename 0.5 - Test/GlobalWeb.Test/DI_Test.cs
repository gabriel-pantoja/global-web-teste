using Autofac;
using GlobalWeb.Infra.CrossCutting.IoC;

namespace GlobalWeb.Test
{
    public class DI_Test
    {
        public IContainer DICollections()
        {
            var container = new ContainerBuilder();
            container.RegisterModule(new AutofacRegister());
            //Create a new container using the registered component
            var ApplicationContainer = container.Build();
            return ApplicationContainer;
        }
    }
}
