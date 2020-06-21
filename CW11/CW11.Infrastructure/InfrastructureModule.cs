using Autofac;

namespace CW11.Infrastructure
{
    public class InfrastructureModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<DoctorRepository>().AsImplementedInterfaces();
        }
    }
}