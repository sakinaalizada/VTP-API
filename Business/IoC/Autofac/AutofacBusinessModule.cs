
using Autofac;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using EntityFramework.DataAccess.Abstract;

namespace Business.IoC.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {

            builder.RegisterType<EFEventDal>().As<IEventDal>().SingleInstance();
            builder.RegisterType<EFParticipantDal>().As<IParticipantDal>().SingleInstance();
            builder.RegisterType<EventManager>().As<IEventService>().SingleInstance();
            builder.RegisterType<ParticipantManager>().As<IParticipantService>().SingleInstance();


        }
    }
}
