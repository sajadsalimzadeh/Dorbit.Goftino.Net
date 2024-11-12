using System.Text.Json.Serialization;

namespace Dorbit.Goftino.Contracts.V1.Messages
{
    public class GoftinoMessageSendFromUserRequest
    {
        [JsonPropertyName("chat_id")]
        public string ChatId { get; }

        [JsonPropertyName("message")]
        public string Message { get; }
        
        [JsonPropertyName("reply_id")]
        public string ReplyId { get; set; }

        public GoftinoMessageSendFromUserRequest(string chatId, string message)
        {
            ChatId = chatId;
            Message = message;
        }
    }
}