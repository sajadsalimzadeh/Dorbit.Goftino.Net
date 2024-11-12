using System.Text.Json.Serialization;
using Dorbit.Goftino.Contracts.V1.Users;

namespace Dorbit.Goftino.Contracts.V1.Messages
{
    public class GoftinoMessageDto
    {
        [JsonPropertyName("message_id")]
        public string MessageId { get; set; }
        
        [JsonPropertyName("sender")]
        public GoftinoUserSenderDto Sender { get; set; }

        [JsonPropertyName("date")]
        public string Date { get; set; }

        [JsonPropertyName("content")]
        public string Content { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("is_seen")]
        public bool IsSeen { get; set; }

        [JsonPropertyName("reply_to")]
        public string ReplyTo { get; set; }
    }
}