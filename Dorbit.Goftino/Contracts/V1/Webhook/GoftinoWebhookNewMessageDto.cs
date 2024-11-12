using System.Collections.Generic;
using System.Text.Json.Serialization;
using Dorbit.Goftino.Contracts.V1.Users;

namespace Dorbit.Goftino.Contracts.V1.Webhook
{
    public class GoftinoWebhookNewMessageDto
    {
        [JsonPropertyName("chat_id")]
        public string ChatId { get; set; }

        [JsonPropertyName("user_id")]
        public string UserId { get; set; }

        [JsonPropertyName("sender")]
        public GoftinoUserSenderDto Sender { get; set; }

        [JsonPropertyName("date")]
        public string Date { get; set; }

        [JsonPropertyName("content")]
        public string Content { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("message_id")]
        public string MessageId { get; set; }

        [JsonPropertyName("current_owner")]
        public List<string> CurrentOwner { get; set; }
    }
}