using System;
using marvel.Models.Domain;
using marvel.Services;

namespace marvel.ViewModels
{
    public class CharacterViewModel : BaseViewModel, INavigated
    {
        public MarvelCharacter Character { get; set; }
        public CharacterViewModel()
        {
        }

        public void Navigated(INavigationParameters parameters)
        {
            Character = parameters.GetValue<MarvelCharacter>("character");
        }
    }
}
