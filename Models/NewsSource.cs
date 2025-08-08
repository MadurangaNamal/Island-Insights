using System.Text.Json.Serialization;

namespace Island_Insights.Models;

public class NewsSource
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("url")]
    public string? Url { get; set; }

    [JsonPropertyName("icon")]
    public string? Icon { get; set; }

    [JsonPropertyName("priority")]
    public int Priority { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("category")]
    public List<string>? Category { get; set; }

    [JsonPropertyName("language")]
    public List<string>? Language { get; set; }

    [JsonPropertyName("country")]
    public List<string>? Country { get; set; }

    [JsonPropertyName("total_article")]
    public int? TotalArticle { get; set; }

    [JsonPropertyName("last_fetch")]
    public string? LastFetch { get; set; }
}
