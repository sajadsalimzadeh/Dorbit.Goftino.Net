using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Dorbit.Goftino.Contracts.V1.Users
{
    public class GoftinoUserDto
    {
        [JsonPropertyName("avatar")]
        public string Avatar { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("email")]
        public string Email { get; set; }

        [JsonPropertyName("phone")]
        public string Phone { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("tags")]
        public List<string> Tags { get; set; }

        [JsonPropertyName("ip")]
        public string Ip { get; set; }

        [JsonPropertyName("location")]
        public string Location { get; set; }

        [JsonPropertyName("browser")]
        public string Browser { get; set; }

        [JsonPropertyName("os")]
        public string Os { get; set; }

        [JsonPropertyName("is_banned")]
        public bool IsBanned { get; set; }

        [JsonPropertyName("last_url")]
        public string LastUrl { get; set; }

        [JsonPropertyName("last_visit")]
        public string LastVisit { get; set; }

        [JsonPropertyName("first_visit")]
        public string FirstVisit { get; set; }

        [JsonPropertyName("page_view")]
        public string PageView { get; set; }

        [JsonPropertyName("chat_id")]
        public string ChatId { get; set; }

        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}