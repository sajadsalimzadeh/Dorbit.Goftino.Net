using System.Text.Json.Serialization;

namespace Dorbit.Goftino.Contracts.V1.Messages
{
    public class GoftinoMessageHistoryRequest
    {
        [JsonPropertyName("message_id")]
        public string MessageId { get; }

        public GoftinoMessageHistoryRequest(string messageId)
        {
            MessageId = messageId;
        }
    }
}