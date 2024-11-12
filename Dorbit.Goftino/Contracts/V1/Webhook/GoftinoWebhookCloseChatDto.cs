using System.Text.Json.Serialization;

namespace Dorbit.Goftino.Contracts.V1.Webhook
{
    public class GoftinoWebhookCloseChatDto
    {
        [JsonPropertyName("chat_id")]
        public string ChatId { get; set; }

        [JsonPropertyName("user_id")]
        public string UserId { get; set; }

        [JsonPropertyName("date")]
        public string Date { get; set; }

        [JsonPropertyName("action_by")]
        public string ActionBy { get; set; }
    }
}