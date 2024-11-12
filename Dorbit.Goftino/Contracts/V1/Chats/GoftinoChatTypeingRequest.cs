using System.Text.Json.Serialization;

namespace Dorbit.Goftino.Contracts.V1.Chats
{
    public class GoftinoChatTypeingRequest
    {
        
        [JsonPropertyName("chat_id")]
        public string ChatId { get; }

        [JsonPropertyName("operator_id")]
        public string OperatorId { get; }

        [JsonPropertyName("typing_status")]
        public string TypingStatus { get; }

        public GoftinoChatTypeingRequest(string chatId, string operatorId, bool typingStatus)
        {
            ChatId = chatId;
            OperatorId = operatorId;
            TypingStatus = typingStatus ? "true" : "false";
        }
    }
}