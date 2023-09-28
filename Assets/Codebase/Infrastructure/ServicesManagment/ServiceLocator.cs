using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Codebase.Infrastructure.ServicesManagment
{
    public class ServiceLocator
    {
        private static ServiceLocator _instance;
        public static ServiceLocator Container => _instance ??= new ServiceLocator();

        public void RegisterSingle<TService>(TService implementation) where TService : IService
            => Implementation<TService>.ServiceInstance = implementation;

        public TService Single<TService>() where TService : IService
            => Implementation<TService>.ServiceInstance;

        private static class Implementation<TService> where TService : IService
        {
            public static TService ServiceInstance;
        }
    }
}
