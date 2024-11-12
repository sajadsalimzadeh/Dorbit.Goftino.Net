using System.Net.Http;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;

namespace Dorbit.Goftino.Utils
{
    public static class HttpHelperExtension
    {
        public static async Task<T> JsonAsync<T>(this HttpResponseMessage response, CancellationToken cancellationToken = default)
        {
            var stringContent = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<T>(stringContent);
        }
    }
}