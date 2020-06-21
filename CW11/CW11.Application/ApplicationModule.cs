using Autofac;

namespace CW11.Application
{
    public class ApplicationModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<DoctorService>().AsImplementedInterfaces();
        }
    }
}