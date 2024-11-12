using System.Text.Json.Serialization;

namespace Dorbit.Goftino.Contracts.V1.Users
{
    public class GoftinoUserSenderDto
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }
        
        [JsonPropertyName("from")]
        public string From { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}