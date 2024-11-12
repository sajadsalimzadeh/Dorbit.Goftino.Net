using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using System.Web;

namespace Dorbit.Goftino.Utils
{
    public class HttpHelper
    {
        private readonly HttpClient _client;

        public HttpHelper(string baseUrl, string apiKey)
        {
            _client = new HttpClient();
            _client.BaseAddress = new Uri(baseUrl);
            _client.DefaultRequestHeaders.Add("goftino-key", apiKey);
        }

        public async Task<T> GetAsync<T>(string url, CancellationToken cancellationToken = default)
        {
            var response = await _client.GetAsync(url, cancellationToken);
            return await response.JsonAsync<T>();
        }

        public Task<T> GetAsync<T>(string url, object queryParameter, CancellationToken cancellationToken = default)
        {
            var parameters = new Dictionary<string, string>();
            foreach (var propertyInfo in queryParameter.GetType().GetProperties())
            {
                var value = propertyInfo.GetValue(queryParameter);
                if (value != null)
                {
                    var attr = propertyInfo.GetCustomAttribute<JsonPropertyNameAttribute>();
                    var name = attr == null ? propertyInfo.Name : attr.Name;
                    parameters.Add(name, HttpUtility.UrlEncode(value.ToString()));
                }
            }

            var queryString = string.Join('&', parameters.Select(x => $"{x.Key}={x.Value}"));
            url += (url.Contains('?') ? '&' : '?') + queryString;
            return GetAsync<T>(url, cancellationToken);
        }

        public async Task<T> PostAsync<T>(string url, object body, CancellationToken cancellationToken = default)
        {
            var content = new StringContent(JsonSerializer.Serialize(body), Encoding.UTF8, "application/json");
            var response = await _client.PostAsync(url, content, cancellationToken);
            return await response.JsonAsync<T>();
        }
    }
}