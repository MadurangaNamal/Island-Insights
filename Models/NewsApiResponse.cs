using System.Text.Json.Serialization;

namespace Island_Insights.Models;

public class NewsApiResponse
{
    [JsonPropertyName("status")]
    public string Status { get; set; }

    [JsonPropertyName("totalResults")]
    public int TotalResults { get; set; }

    [JsonPropertyName("results")]
    public List<NewsArticle> Results { get; set; }

    [JsonPropertyName("nextPage")]
    public string NextPage { get; set; }
}
