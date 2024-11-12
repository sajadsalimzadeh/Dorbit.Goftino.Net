using System.Text.Json.Serialization;

namespace Dorbit.Goftino.Contracts.V1.Operators
{
    public class GoftinoOperatorGetRequest
    {
        public enum RequestType
        {
            Email,
            OperatorId
        }
        
        [JsonPropertyName("email")]
        public string Email { get; }
        
        [JsonPropertyName("operator_id")]
        public string OperatorId { get; }

        public GoftinoOperatorGetRequest(RequestType type, string value)
        {
            if (type == RequestType.Email) Email = value;
            else if(type == RequestType.OperatorId) OperatorId = value;
        }
    }
}