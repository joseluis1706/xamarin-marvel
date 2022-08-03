using System;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace marvel.Services
{
    public class NavigationService: INavigationService
    {

        public async Task BackAsync()
        {
            await App.Current.MainPage.Navigation.PopAsync();
        }

        public async Task NavigateAsync(Page page)
        {
            await App.Current.MainPage.Navigation.PushAsync(page);
        }

        public async Task NavigateAsync(Page page, INavigationParameters parameters)
        {
            await App.Current.MainPage.Navigation.PushAsync(page);

            if (page.BindingContext is INavigated viewModel)
                viewModel.Navigated(parameters);
        }
    }
}
