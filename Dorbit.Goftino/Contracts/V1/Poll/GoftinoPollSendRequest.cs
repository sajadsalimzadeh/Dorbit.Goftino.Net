using System.Text.Json.Serialization;

namespace Dorbit.Goftino.Contracts.V1.Poll
{
    public class GoftinoPollSendRequest
    {
        [JsonPropertyName("chat_id")]
        public string ChatId { get; }

        public GoftinoPollSendRequest(string chatId)
        {
            ChatId = chatId;
        }
    }
}