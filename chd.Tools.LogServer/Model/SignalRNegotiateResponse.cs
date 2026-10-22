using Microsoft.AspNetCore.Http.Connections;
using System.Text.Json.Serialization;

namespace chd.Tools.LogServer.Model
{
    public class SignalRNegotiateResponse
    {
        [JsonPropertyName("negotiateVersion")]
        public int NegotiateVersion { get; set; }

        [JsonPropertyName("connectionId")]
        public string? ConnectionId { get; set; }

        // nur bei negotiateVersion >= 1
        [JsonPropertyName("connectionToken")]
        public string? ConnectionToken { get; set; }

        [JsonPropertyName("availableTransports")]
        public List<AvailableTransport>? AvailableTransports { get; set; }
    }
}
