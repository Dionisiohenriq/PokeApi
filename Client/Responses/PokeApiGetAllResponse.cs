using System.Text.Json.Serialization;

namespace PokeApi.Client.Responses
{
    public class ResultAll
    {
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("url")]
        public string? Url { get; set; }
    }

    public class PokeApiGetAllResponse
    {
        [JsonPropertyName("count")]
        public int Count { get; set; }

        [JsonPropertyName("next")]
        public string? Next { get; set; }

        [JsonPropertyName("previous")]
        public object? Previous { get; set; }

        [JsonPropertyName("results")]
        public List<ResultAll>? Results { get; set; }
    }
}
