using SimpleInjector;

namespace Tarefas.Infrastructure.CrossCutting.IoC.SimpleInjector
{
    public class BootStrapper
    {
        public static Container SIContainer { get; set; }

        public static void Register(Container container)
        {
            SIContainer = container;

            #region Application Services
            #endregion

            #region Domain Services
            //container.Register(typeof(IServiceBase<>), typeof(ServiceBase<>), Lifestyle.Scoped);

            #endregion

            #region Infra Data

            //container.Register<ConteudoContext>(Lifestyle.Scoped); //EF
            //container.Register<ConteudoContext>(Lifestyle.Scoped); //Dapper

            #endregion

            #region Infra CrossCutting
            #endregion

        }
    }
}
