namespace marvel.Services
{
    public interface INavigationParameters
    {
        INavigationParameters Add(string key, object value);
        T GetValue<T>(string key);
    }
}
