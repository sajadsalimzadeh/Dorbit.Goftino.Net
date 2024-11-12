using System.Text.Json.Serialization;

namespace Dorbit.Goftino.Contracts.V1.Users
{
    public class GoftinoUserBanRequest
    {
        public enum RequestType
        {
            ChatId,
            UserId
        }
        
        [JsonPropertyName("operator_id")]
        public string OperatorId { get; set; }
        
        [JsonPropertyName("chat_id")]
        public string ChatId { get; }
        
        [JsonPropertyName("user_id")]
        public string UserId { get; }

        public GoftinoUserBanRequest(string operatorId, RequestType type, string id)
        {
            OperatorId = operatorId;
            if (type == RequestType.ChatId) ChatId = id;
        }
    }
}