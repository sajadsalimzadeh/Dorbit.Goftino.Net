using System.Text.Json.Serialization;

namespace Dorbit.Goftino.Contracts.V1.Chats
{
    public class GoftinoChatUnAssignRequest
    {
        [JsonPropertyName("chat_id")]
        public string ChatId { get; set; }

        [JsonPropertyName("from_operator")]
        public string FromOperator { get; set; }

        public GoftinoChatUnAssignRequest(string chatId, string fromOperator)
        {
            ChatId = chatId;
            FromOperator = fromOperator;
        }
    }
}