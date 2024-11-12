using System.Text.Json.Serialization;

namespace Dorbit.Goftino.Contracts.V1.Users
{
    public class GoftinoUserGetVisitedPageRequest
    {
        [JsonPropertyName("user_id")]
        public string UserId { get; }

        public GoftinoUserGetVisitedPageRequest(string userId)
        {
            UserId = userId;
        }
    }
}