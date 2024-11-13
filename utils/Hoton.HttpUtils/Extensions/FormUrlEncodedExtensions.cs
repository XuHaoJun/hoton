using System.Reflection;
using System.Text.Json.Serialization;
using System.Web;

namespace Hoton.HttpUtils.Extensions;

public static class FormUrlEncodedExtensions
{
    public static FormUrlEncodedContent ToFormUrlEncoded<T>(this T obj, bool useJsonPropertyName = false)
        where T : class
    {
        var properties = typeof(T)
            .GetProperties(BindingFlags.Public | BindingFlags.Instance)
            .Where(p => p.GetValue(obj) != null);

        var keyValuePairs = new List<KeyValuePair<string, string>>();

        foreach (var property in properties)
        {
            var jsonPropertyName = property.GetCustomAttribute<JsonPropertyNameAttribute>()?.Name;

            var name = useJsonPropertyName && !string.IsNullOrEmpty(jsonPropertyName) ? jsonPropertyName : property.Name;

            var value = property.GetValue(obj);

            // Handle collections
            if (value is IEnumerable<object> collection && !(value is string))
            {
                foreach (var item in collection)
                {
                    keyValuePairs.Add(
                        new KeyValuePair<string, string>(name, HttpUtility.UrlEncode(item?.ToString() ?? ""))
                    );
                }
            }
            // Handle normal properties
            else
            {
                keyValuePairs.Add(
                    new KeyValuePair<string, string>(name, HttpUtility.UrlEncode(value?.ToString() ?? ""))
                );
            }
        }

        return new FormUrlEncodedContent(keyValuePairs);
    }

}
