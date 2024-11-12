using System.Text.Json.Serialization;

namespace Dorbit.Goftino.Contracts.V1.Operators
{
    public class GoftinoOperatorDto
    {
        [JsonPropertyName("avatar")]
        public string Avatar { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("email")]
        public string Email { get; set; }

        [JsonPropertyName("is_online")]
        public bool IsOnline { get; set; }

        [JsonPropertyName("operator_id")]
        public string OperatorId { get; set; }
    }
}