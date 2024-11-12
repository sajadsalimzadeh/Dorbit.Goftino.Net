using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Dorbit.Goftino.Contracts.V1.Users
{
    public class GoftinoUserGetVisitedPageResponse
    {
        [JsonPropertyName("pages")]
        public List<GoftinoUserVisitedPageDto> Pages { get; set; }
    }
}