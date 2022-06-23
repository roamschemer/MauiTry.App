using MauiTry.Views;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiTry.Services {
    public interface INavigationService {
        Task NavigateToSecondPage();
        Task NavigateBack();
    }

    public class NavigationService : INavigationService {

        readonly IServiceProvider _services;

        protected INavigation Navigation {
            get {
                INavigation navigation = Application.Current?.MainPage?.Navigation;
                if (navigation is not null)
                    return navigation;
                if (Debugger.IsAttached)
                    Debugger.Break();
                throw new Exception();
            }
        }

        public NavigationService(IServiceProvider services) => _services = services;

        public Task NavigateToSecondPage() => NavigateToPage<SecondPage>();

        private Task NavigateToPage<T>() where T : Page {
            var page = ResolvePage<T>();
            if (page is not null)
                return Navigation.PushAsync(page, true);
            throw new InvalidOperationException($"Unable to resolve type {typeof(T).FullName}");
        }

        private T ResolvePage<T>() where T : Page => _services.GetService<T>();

        public Task NavigateBack() {
            if (Navigation.NavigationStack.Count > 1)
                return Navigation.PopAsync();
            throw new InvalidOperationException("No pages to navigate back to!");
        }
    }
}
