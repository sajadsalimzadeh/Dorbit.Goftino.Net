using System.Collections.Generic;
using System.Text.Json.Serialization;
using Dorbit.Goftino.Contracts.V1.Messages;

namespace Dorbit.Goftino.Contracts.V1.Chats
{
    public class GoftinoChatDto
    {
        [JsonPropertyName("chat_id")]
        public string ChatId { get; set; }

        [JsonPropertyName("chat_status")]
        public string ChatStatus { get; set; }

        [JsonPropertyName("current_owner")]
        public List<string> CurrentOwner { get; set; }

        [JsonPropertyName("all_operators")]
        public List<string> AllOperators { get; set; }

        [JsonPropertyName("unread_messages")]
        public int UnreadMessages { get; set; }

        [JsonPropertyName("user_id")]
        public string UserId { get; set; }

        [JsonPropertyName("user_name")]
        public string UserName { get; set; }

        [JsonPropertyName("last_message")]
        public GoftinoMessageDto LastMessage { get; set; }
    }
}