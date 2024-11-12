using System.Text.Json.Serialization;

namespace Dorbit.Goftino.Contracts.V1.Chats
{
    public class GoftinoChatTransferRequest
    {
        [JsonPropertyName("chat_id")]
        public string ChatId { get; set; }

        [JsonPropertyName("from_operator")]
        public string FromOperator { get; set; }

        [JsonPropertyName("to_operator")]
        public string ToOperator { get; set; }

        public GoftinoChatTransferRequest(string chatId, string fromOperator, string toOperator)
        {
            ChatId = chatId;
            FromOperator = fromOperator;
            ToOperator = toOperator;
        }
    }
}