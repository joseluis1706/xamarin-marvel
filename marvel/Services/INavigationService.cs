namespace marvel.Services
{
    using System.Threading.Tasks;
    using Xamarin.Forms;

    public interface INavigationService
    {
        Task NavigateAsync(Page page);
        Task NavigateAsync(Page page, INavigationParameters parameters);
        Task BackAsync();
    }
}
