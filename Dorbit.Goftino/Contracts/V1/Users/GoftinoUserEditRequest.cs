using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Dorbit.Goftino.Contracts.V1.Users
{
    public class GoftinoUserEditRequest
    {
        [JsonPropertyName("user_id")]
        public string UserId { get; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("phone")]
        public string Phone { get; set; }

        [JsonPropertyName("avatar")]
        public string Avatar { get; set; }

        [JsonPropertyName("tags")]
        public List<string> Tags { get; set; }

        public GoftinoUserEditRequest(string userId)
        {
            UserId = userId;
        }
    }
}