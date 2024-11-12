using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Dorbit.Goftino.Contracts.V1.Messages
{
    public class GoftinoMessageHistoryResponse
    {
        
        [JsonPropertyName("messages")]
        public List<string> Messages { get; set; }
    }
}