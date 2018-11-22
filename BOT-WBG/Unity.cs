using BOT_WBG.Discord;
using BOT_WBG.Storage;
using BOT_WBG.Storage.Implementation;
using Discord.WebSocket;
using Unity;
using Unity.Injection;
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
            _container.RegisterSingleton<IDateStorage, JsonStorage>();
            _container.RegisterSingleton<ILogger, Logger>();
            _container.RegisterType<DiscordSocketConfig>(new InjectionFactory(i => SocketConfig.GetDefault()));
            _container.RegisterSingleton<DiscordSocketClient>(new InjectionConstructor(typeof(DiscordSocketConfig)));
            _container.RegisterSingleton<Discord.Connection>();
        }

        public static T Resolve<T>()
        {
            return (T)Container.Resolve(typeof(T), string.Empty, new CompositeResolverOverride());
        }
    }
}