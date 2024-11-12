using System.Text.Json.Serialization;

namespace Dorbit.Goftino.Contracts.V1.Chats
{
    public class GoftinoChatCreateRequest
    {
        [JsonPropertyName("message")]
        public string Message { get; }

        public GoftinoChatCreateRequest(string message)
        {
            Message = message;
        }
    }
}