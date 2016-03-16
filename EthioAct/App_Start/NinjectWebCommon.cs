[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(EthioAct.App_Start.NinjectWebCommon), "Start")]
[assembly: WebActivatorEx.ApplicationShutdownMethodAttribute(typeof(EthioAct.App_Start.NinjectWebCommon), "Stop")]

namespace EthioAct.App_Start
{
    using System;
    using System.Web;

    using Microsoft.Web.Infrastructure.DynamicModuleHelper;
    using EthioAct.Data.Repository;

    using EthioAct.Services;
    using Ninject;
    using Ninject.Web.Common;
    using EthioAct.Data.UnitOfWork;


 

    public static class NinjectWebCommon 
    {
        private static readonly Bootstrapper bootstrapper = new Bootstrapper();

        /// <summary>
        /// Starts the application
        /// </summary>
        public static void Start() 
        {
            DynamicModuleUtility.RegisterModule(typeof(OnePerRequestHttpModule));
            DynamicModuleUtility.RegisterModule(typeof(NinjectHttpModule));
            bootstrapper.Initialize(CreateKernel);
        }
        
        /// <summary>
        /// Stops the application.
        /// </summary>
        public static void Stop()
        {
            bootstrapper.ShutDown();
        }
        
        /// <summary>
        /// Creates the kernel that will manage your application.
        /// </summary>
        /// <returns>The created kernel.</returns>
        private static IKernel CreateKernel()
        {
            var kernel = new StandardKernel();
            try
            {
                kernel.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
                kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();

                RegisterServices(kernel);

                System.Web.Http.GlobalConfiguration.Configuration.DependencyResolver = new NinjectResolver(kernel);
                //System.Web.Http.GlobalConfiguration.Configuration.DependencyResolver = new Ninject.Web.WebApi.NinjectDependencyResolver(kernel);

                return kernel;
            }
            catch
            {
                kernel.Dispose();
                throw;
            }
        }

        /// <summary>
        /// Load your modules or register your services here!
        /// </summary>
        /// <param name="kernel">The kernel.</param>
        private static void RegisterServices(IKernel kernel)
        {
            kernel.Bind<IUnitOfWork>().To<UnitOfWork>();
            kernel.Bind<IActingTypeService>().To<ActingTypeService>();
           // kernel.Bind<IActor>().To<Actor>();

            kernel.Bind<IActingTypeService>().To<ActingTypeService>();
            kernel.Bind<IActorRequirementService>().To<ActorRequirementService>();
            kernel.Bind<IActorVsActingTypeService>().To<ActorVsActingTypeService>();
            kernel.Bind<IActorVsTalentService>().To<ActorVsTalentService>();
            kernel.Bind<IAddressService>().To<AddressService>();
            //kernel.Bind<ICategoryService>().To<CategoryService>();
            //kernel.Bind<IPackageService>().To<PackageService>();
            
            //kernel.Bind<IAspNetUserService>().To<AspNetUserService>();
            //kernel.Bind<ICompaniesCategoryService>().To<CompaniesCategoryService>();
            //kernel.Bind<ICompanyServiceService>().To<CompanyServiceService>();

            
            //kernel.Bind<IMapAreaService>().To<MapAreaService>();
            //kernel.Bind<ICompanyRateService>().To<CompanyRateService>();
            //kernel.Bind<ICompanyMemberService>().To<CompanyMemberService>();
            //kernel.Bind<IProductCategoryService>().To<ProductCategoryService>();
        }        
    }
}
