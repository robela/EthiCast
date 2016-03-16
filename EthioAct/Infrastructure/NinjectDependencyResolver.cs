//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using EthioAct.Models.Models;
//using EthioAct.Services;
//using Ninject;


//namespace EthioAct.Infrastructure
//{
//    public class NinjectDependencyResolver
//    {
//        private IKernel kernel;

//        public NinjectDependencyResolver()
//        {
//            kernel = new StandardKernel();
//            AddBindings();
           
//        }


//        public object GetService(Type serviceType)
//        {
//            return kernel.TryGet(serviceType);
//        }

//        public IEnumerable<object> GetServices(Type serviceType)
//        {
//            return kernel.GetAll(serviceType);
//        }
//        private void AddBindings()
//        {
            


//            kernel.Bind<IImageService>().To<ImageService>();
//        }

//    }
//}