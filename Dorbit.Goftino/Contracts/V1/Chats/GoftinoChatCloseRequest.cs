using System.Text.Json.Serialization;

namespace Dorbit.Goftino.Contracts.V1.Chats
{
    public class GoftinoChatCloseRequest
    {
        
        [JsonPropertyName("chat_id")]
        public string ChatId { get; set; }

        [JsonPropertyName("operator_id")]
        public string OperatorId { get; set; }

        public GoftinoChatCloseRequest(string chatId, string operatorId)
        {
            ChatId = chatId;
            OperatorId = operatorId;
        }
    }
}