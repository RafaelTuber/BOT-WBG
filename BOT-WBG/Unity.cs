using BOT_WBG.Storage;
using BOT_WBG.Storage.Implementation;
using Unity;
using Unity.Lifetime;
using Unity.Resolution;

namespace BOT_WBG
{
    public static class Unity
    {
        private static UnityContainer _container;

        public static IUnityContainer Container
        {
            get
            {
                if (_container == null)
                    RegisterTypes();
                return _container;
            }
        }

        public static void RegisterTypes()
        {
            _container = new UnityContainer();
            _container.RegisterType<IDateStorage, InMemoryStorage>(new ContainerControlledLifetimeManager());
        }

        public static T Resolve<T>()
        {
            return (T)Container.Resolve(typeof(T), string.Empty, new CompositeResolverOverride());
        }
    }
}