using System.Text.Json.Serialization;

namespace Dorbit.Goftino.Contracts.V1.Chats
{
    public class GoftinoChatCreateResponse
    {
        [JsonPropertyName("chat_id")]
        public string ChatId { get; set; }
        
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}