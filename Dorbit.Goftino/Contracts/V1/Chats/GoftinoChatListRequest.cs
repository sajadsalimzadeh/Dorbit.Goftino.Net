using System.Text.Json.Serialization;

namespace Dorbit.Goftino.Contracts.V1.Chats
{
    public class GoftinoChatListRequest
    {
        [JsonPropertyName("limit")]
        public int? Limit { get; set; }
        
        [JsonPropertyName("page")]
        public int? Page { get; set; }
        
        [JsonPropertyName("operator_id")]
        public string OperatorId { get; set; }
        
        [JsonPropertyName("status")]
        public string Status { get; set; }
        
        [JsonPropertyName("has_owner")]
        public bool? HasOwner { get; set; }
    }
}