using System;
using DryIoc;
using marvel.ViewModels;

namespace marvel.Services
{
    public class AppContainer
    {
        private static IContainer container;

        public AppContainer()
        {
            container = new Container();

            // services
            container.Register<INavigationService, NavigationService>();
            container.Register<IApiService, ApiService>();

            // view models
            container.Register<HomeViewModel>();
            container.Register<CharacterViewModel>();
        }

        public T Resolve<T>() => container.Resolve<T>();

        public object Resolve(Type type) => container.Resolve(type);
    }
}
