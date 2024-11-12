using System.Text.Json.Serialization;

namespace Dorbit.Goftino.Contracts.V1.Messages
{
    public class GoftinoMessageEditRequest
    {
        
        [JsonPropertyName("message")]
        public string Message { get; }

        [JsonPropertyName("message_id")]
        public string MessageId { get; }

        public GoftinoMessageEditRequest(string message, string messageId)
        {
            Message = message;
            MessageId = messageId;
        }
    }
}