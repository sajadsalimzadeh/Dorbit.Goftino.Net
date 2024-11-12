using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Dorbit.Goftino.Contracts.V1.Chats
{
    public class GoftinoChatListResponse
    {
        [JsonPropertyName("chats")]
        public List<GoftinoChatDto> Chats { get; set; }

        [JsonPropertyName("page")]
        public int Page { get; set; }
    }
}