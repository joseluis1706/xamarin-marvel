namespace marvel.Services
{
    using System.Collections.Generic;

    public class NavigationParameters : INavigationParameters
    {
        private Dictionary<string, object> parameters;

        public NavigationParameters()
        {
            parameters = new Dictionary<string, object>();
        }

        public INavigationParameters Add(string key, object value)
        {
            parameters.Add(key, value);

            return this;
        }

        public T GetValue<T>(string key)
        {
            parameters.TryGetValue(key, out object value);

            if (value != null && value is T valueCast)
            {
                return valueCast;
            }

            return default;
        }
    }
}
