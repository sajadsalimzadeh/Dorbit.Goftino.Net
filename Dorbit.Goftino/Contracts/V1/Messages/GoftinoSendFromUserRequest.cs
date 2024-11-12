using System.Text.Json.Serialization;

namespace Dorbit.Goftino.Contracts.V1.Messages
{
    public class GoftinoSendFromUserRequest
    {
        
        [JsonPropertyName("chat_id")]
        public string ChatId { get; set; }

        [JsonPropertyName("message")]
        public string Message { get; set; }
    }
}