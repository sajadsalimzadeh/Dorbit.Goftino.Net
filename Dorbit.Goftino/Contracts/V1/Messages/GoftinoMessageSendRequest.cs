using System.Text.Json.Serialization;

namespace Dorbit.Goftino.Contracts.V1.Messages
{
    public class GoftinoMessageSendRequest
    {
        [JsonPropertyName("chat_id")]
        public string ChatId { get; }

        [JsonPropertyName("operator_id")]
        public string OperatorId { get; }

        [JsonPropertyName("message")]
        public string Message { get; }

        [JsonPropertyName("reply_id")]
        public string ReplyId { get; set; }

        public GoftinoMessageSendRequest(string chatId, string operatorId, string message)
        {
            ChatId = chatId;
            OperatorId = operatorId;
            Message = message;
        }
    }
}