using System.Text.Json.Serialization;

namespace Dorbit.Goftino.Contracts.V1.Users
{
    public class GoftinoUserVisitedPageDto
    {
        [JsonPropertyName("url")]
        public string Url { get; set; }

        [JsonPropertyName("date")]
        public string Date { get; set; }

        [JsonPropertyName("time_on_page")]
        public int TimeOnPage { get; set; }
    }
}