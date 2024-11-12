using System.Text.Json.Serialization;

namespace Dorbit.Goftino.Contracts.V1.Chats
{
    public class GoftinoChatRemoveRequest
    {
        [JsonPropertyName("chat_id")]
        public string ChatId { get; }

        public GoftinoChatRemoveRequest(string chatId)
        {
            ChatId = chatId;
        }
    }
}