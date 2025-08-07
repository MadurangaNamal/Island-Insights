using System.Text.Json.Serialization;

namespace Island_Insights.Models;

public class NewsArticlesApiResponse : NewsApiResponse
{
    [JsonPropertyName("results")]
    public List<NewsArticle>? Results { get; set; }
}
