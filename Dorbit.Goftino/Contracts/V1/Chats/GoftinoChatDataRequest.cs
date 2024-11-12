using System;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;

namespace Dorbit.Goftino.Contracts.V1.Chats
{
    public class GoftinoChatDataRequest
    {

        [JsonPropertyName("chat_id")]
        public string ChatId { get; }
        
        [JsonPropertyName("limit")]
        public int? Limit { get; set; }
        
        [JsonPropertyName("page")]
        public int? Page { get; set; }
        
        [JsonPropertyName("from_date")]
        public DateTime? FromDate { get; set; }
        
        [JsonPropertyName("to_date")]
        public DateTime? ToDate { get; set; }
        
        public GoftinoChatDataRequest(string chatId)
        {
            ChatId = chatId;
        }
    }
}