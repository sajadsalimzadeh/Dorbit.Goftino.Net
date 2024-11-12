using System.Text.Json.Serialization;

namespace Dorbit.Goftino.Contracts.V1.Messages
{
    public class GoftinoMessageSendResponse
    {
        [JsonPropertyName("message_id")]
        public string MessageId { get; set; }
    }
}