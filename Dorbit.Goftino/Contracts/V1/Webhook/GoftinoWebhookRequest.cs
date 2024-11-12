using System.Text.Json;
using System.Text.Json.Serialization;

namespace Dorbit.Goftino.Contracts.V1.Webhook
{

    public class GoftinoWebhookRequest
    {
        [JsonPropertyName("event")]
        public string Event { get; set; }
        
        [JsonPropertyName("data")]
        public JsonElement Data { get; set; }
    }
}