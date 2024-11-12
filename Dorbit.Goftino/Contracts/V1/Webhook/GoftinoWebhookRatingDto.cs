using System.Text.Json.Serialization;

namespace Dorbit.Goftino.Contracts.V1.Webhook
{

    public class GoftinoWebhookRatingDto
    {
        [JsonPropertyName("chat_id")]
        public string ChatId { get; set; }

        [JsonPropertyName("user_id")]
        public string UserId { get; set; }

        [JsonPropertyName("date")]
        public string Date { get; set; }

        [JsonPropertyName("rate")]
        public string Rate { get; set; }

        [JsonPropertyName("to_operator")]
        public string ToOperator { get; set; }
    }
}