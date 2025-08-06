using System.Text.Json.Serialization;

namespace Island_Insights.Models;

public class NewsSource
{
    [JsonPropertyName("id")]
    public string Id { get; set; } = string.Empty;

    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;

    [JsonPropertyName("url")]
    public string Url { get; set; } = string.Empty;

    [JsonPropertyName("icon")]
    public string Icon { get; set; } = string.Empty;

    [JsonPropertyName("priority")]
    public int Priority { get; set; }

    [JsonPropertyName("description")]
    public string Description { get; set; } = string.Empty;

    [JsonPropertyName("category")]
    public List<string> Category { get; set; } = new();

    [JsonPropertyName("language")]
    public List<string> Language { get; set; } = new();

    [JsonPropertyName("country")]
    public List<string> Country { get; set; } = new();

    [JsonPropertyName("total_article")]
    public int? TotalArticle { get; set; }

    [JsonPropertyName("last_fetch")]
    public string? LastFetch { get; set; }
}
