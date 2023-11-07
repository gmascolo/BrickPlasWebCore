using Newtonsoft.Json;

namespace BrickPlasWebMVC.Extensions
{
    public static class SessionExtensions
    {
        public static void SetSession<T>(this ISession session, string name, T value)
        {

            string jsonValue = JsonConvert.SerializeObject(value);
            session.SetString(name, jsonValue);
        }

        public static T GetSession<T>(this ISession session, string name)
        {
            var jsonResponse = session.GetString(name);

            if (string.IsNullOrEmpty(jsonResponse))
                return default;

            return (T)JsonConvert.DeserializeObject(jsonResponse, typeof(T));
        }
    }
}
