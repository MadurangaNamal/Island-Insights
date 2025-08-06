using System.Text.Json.Serialization;

#nullable enable
namespace Island_Insights.Models;

public class NewsSourcesApiResponse
{
    [JsonPropertyName("status")]
    public string Status { get; set; }

    [JsonPropertyName("totalResults")]
    public int TotalResults { get; set; }

    [JsonPropertyName("results")]
    public List<NewsSource> Results { get; set; }

    [JsonPropertyName("nextPage")]
    public string? NextPage { get; set; }
}
