using System.Text.Json.Serialization;

namespace Dorbit.Goftino.Contracts.V1.Chats
{
    public class GoftinoChatUnreadMessageRequest
    {
        public enum RequestType
        {
            ChatId,
            UserId
        }
        
        [JsonPropertyName("chat_id")]
        public string ChatId { get; }
        
        [JsonPropertyName("user_id")]
        public string UserId { get; }

        public GoftinoChatUnreadMessageRequest(RequestType type, string id)
        {
            if(type == RequestType.ChatId) ChatId = id;
            if(type == RequestType.UserId) UserId = id;
        }
    }
}