[assembly: WebActivator.PostApplicationStartMethod(typeof(IssueTracker.App_Start.SimpleInjectorWebApiInitializer), "Initialize")]

namespace IssueTracker.App_Start
{
    using System.Web.Http;
    using IssueTrackerShared.Data;
    using SimpleInjector;
    using SimpleInjector.Integration.WebApi;
    using SimpleInjector.Lifestyles;
    
    public static class SimpleInjectorWebApiInitializer
    {
        /// <summary>Initialize the container and register it as Web API Dependency Resolver.</summary>
        public static void Initialize()
        {
            var container = new Container();
            container.Options.DefaultScopedLifestyle = new AsyncScopedLifestyle();
            
            InitializeContainer(container);

            container.RegisterWebApiControllers(GlobalConfiguration.Configuration);
       
            container.Verify();
            
            GlobalConfiguration.Configuration.DependencyResolver =
                new SimpleInjectorWebApiDependencyResolver(container);
        }
     
        private static void InitializeContainer(Container container)
        {
            container.Register<Context>(Lifestyle.Scoped);
            container.Register<DepartmentsRepository>(Lifestyle.Scoped);
            container.Register<IssuesRepository>(Lifestyle.Scoped);
            
        }
    }
}