
namespace marvel.Services
{
    using System.Threading.Tasks;

    public interface IApiService
    {
        Task<T> GetAsync<T>(string url, string endpoint);
    }
}
