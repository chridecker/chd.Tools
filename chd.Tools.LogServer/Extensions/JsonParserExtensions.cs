using chd.Tools.LogServer.Model;
using System.Text.Json;

namespace chd.Tools.LogServer.Extensions
{
    public static class JsonParserExtensions
    {
        const char RecordSeparator = '\u001e';

        public static IEnumerable<(SignalRMessageType Type, string Json)> ParseFrame(this string frame)
        {
            foreach (var part in frame.Split(RecordSeparator, StringSplitOptions.RemoveEmptyEntries))
                yield return (GetMessageType(part), part);
        }

        public static string RootValue(this string json, string name)
        {
            using var doc = JsonDocument.Parse(json);
            var root = doc.RootElement;
            if (root.ValueKind != JsonValueKind.Object)
            {
                return string.Empty;
            }

            if (root.TryGetProperty(name, out var typeProp))
            {
                return typeProp.GetString();
            }
            return string.Empty;
        }
        public static string[] RootValueArray(this string json, string name)
        {
            using var doc = JsonDocument.Parse(json);
            var root = doc.RootElement;
            if (root.ValueKind != JsonValueKind.Object)
            {
                return [];
            }

            if (root.TryGetProperty("arguments", out var args) && args.ValueKind == JsonValueKind.Array)
            {
                var lst = new List<string>();
                foreach (var item in args.EnumerateArray())
                {
                    lst.Add(item.ToString());
                }

                return lst.ToArray();
            }
            return [];
        }

        private static SignalRMessageType GetMessageType(string json)
        {
            if (string.IsNullOrWhiteSpace(json))
                return SignalRMessageType.None;

            try
            {
                using var doc = JsonDocument.Parse(json);
                var root = doc.RootElement;

                if (root.ValueKind != JsonValueKind.Object)
                    return SignalRMessageType.None;

                if (root.TryGetProperty("type", out var typeProp) && typeProp.TryGetInt32(out var type))
                {
                    return Enum.IsDefined(typeof(SignalRMessageType), type)
                        ? (SignalRMessageType)type
                        : SignalRMessageType.None;
                }

                // Kein "type" -> Handshake
                if (root.TryGetProperty("protocol", out _))
                    return SignalRMessageType.HandshakeRequest;

                return SignalRMessageType.HandshakeResponse; // {} oder {"error":"..."}
            }
            catch (JsonException)
            {
                return SignalRMessageType.None;
            }
        }

    }
}
