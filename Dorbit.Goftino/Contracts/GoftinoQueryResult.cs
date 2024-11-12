using System.Text.Json.Serialization;

namespace Dorbit.Goftino.Contracts
{
    public class GoftinoCommandResult
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }
        [JsonPropertyName("code")]
        public string Code { get; set; }

        public bool Success => Status == "success";
    }
    public class GoftinoQueryResult<T> : GoftinoCommandResult
    {
        [JsonPropertyName("data")]
        public T Data { get; set; }
    }
}