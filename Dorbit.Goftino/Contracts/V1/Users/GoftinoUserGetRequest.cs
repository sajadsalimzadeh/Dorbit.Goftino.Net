using System.Text.Json.Serialization;

namespace Dorbit.Goftino.Contracts.V1.Users
{
    public class GoftinoUserGetRequest
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

        public GoftinoUserGetRequest(RequestType type, string id)
        {
            if(type == RequestType.UserId) UserId = id;
            else if(type == RequestType.ChatId) ChatId = id;
        }
    }
}