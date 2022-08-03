using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;
using marvel.Models.Domain;
using marvel.Models.Response;
using marvel.Services;
using marvel.Views;
using Xamarin.Forms;

namespace marvel.ViewModels
{
    public class HomeViewModel : BaseViewModel, INavigated
    {
        private readonly IApiService apiService;
        private readonly INavigationService navigationService;
        private ObservableCollection<MarvelCharacter> characters;

        public ObservableCollection<MarvelCharacter> Characters
        {
            get => characters;
            set => SetProperty(ref characters, value);
        }

        public ICommand CharacterDetailCommand { get; set; }

        public HomeViewModel(IApiService apiService, INavigationService navigationService)
        {
            this.apiService = apiService;
            this.navigationService = navigationService;
            CharacterDetailCommand = new Command<MarvelCharacter>(async (character)=> await ViewDetailAsync(character));
            _ = GetCharactersAsync();
        }

        private async Task ViewDetailAsync(MarvelCharacter character)
        {
            await navigationService.NavigateAsync(new CharacterView(),
                new NavigationParameters().Add("character", character));
        }

        async Task GetCharactersAsync()
        {
            try
            {
                MarvelCharactersResponse response = await apiService.GetAsync<MarvelCharactersResponse>(
                    "https://gateway.marvel.com/v1/public",
                    "/characters?ts=1000&apikey=70bc7cd5a9a698341bea120a6fd30171&hash=29c48db729c18ee81ceb7cc69a5a9061");

                Characters = new ObservableCollection<MarvelCharacter>(response.Data.Results);
            }
            catch (Exception ex)
            {
                await App.Current.MainPage.DisplayAlert("Error", ex.Message, "Ok");
            }
        }

        public void Navigated(INavigationParameters parameters)
        {
            var name = parameters.GetValue<string>("name");
        }
    }
}
