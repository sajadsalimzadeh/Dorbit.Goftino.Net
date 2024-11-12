using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Dorbit.Goftino.Contracts.V1.Operators
{
    public class GoftinoOperatorGetResponse
    {
        [JsonPropertyName("operators")]
        public List<GoftinoOperatorDto> Operators { get; set; }
    }
}