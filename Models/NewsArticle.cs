using System.Text.Json.Serialization;

namespace Island_Insights.Models;

public class NewsArticle
{
    [JsonPropertyName("article_id")]
    public string? ArticleId { get; set; }

    [JsonPropertyName("title")]
    public string? Title { get; set; }

    [JsonPropertyName("link")]
    public string? Link { get; set; }

    [JsonPropertyName("keywords")]
    public List<string>? Keywords { get; set; }

    [JsonPropertyName("creator")]
    public List<string>? Creator { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("content")]
    public string? Content { get; set; }

    [JsonPropertyName("pubDate")]
    public string? PubDate { get; set; }

    [JsonPropertyName("pubDateTZ")]
    public string? PubDateTZ { get; set; }

    [JsonPropertyName("image_url")]
    public string? ImageUrl { get; set; }

    [JsonPropertyName("video_url")]
    public string? VideoUrl { get; set; }

    [JsonPropertyName("source_id")]
    public string? SourceId { get; set; }

    [JsonPropertyName("source_name")]
    public string? SourceName { get; set; }

    [JsonPropertyName("source_priority")]
    public int? SourcePriority { get; set; }

    [JsonPropertyName("source_url")]
    public string? SourceUrl { get; set; }

    [JsonPropertyName("source_icon")]
    public string? SourceIcon { get; set; }

    [JsonPropertyName("language")]
    public string? Language { get; set; }

    [JsonPropertyName("country")]
    public List<string>? Country { get; set; }

    [JsonPropertyName("category")]
    public List<string>? Category { get; set; }

    [JsonPropertyName("sentiment")]
    public string? Sentiment { get; set; }

    [JsonPropertyName("sentiment_stats")]
    public string? SentimentStats { get; set; }

    [JsonPropertyName("ai_tag")]
    public string? AiTag { get; set; }

    [JsonPropertyName("ai_region")]
    public string? AiRegion { get; set; }

    [JsonPropertyName("ai_org")]
    public string? AiOrg { get; set; }

    [JsonPropertyName("ai_summary")]
    public string? AiSummary { get; set; }

    [JsonPropertyName("ai_content")]
    public string? AiContent { get; set; }

    [JsonPropertyName("duplicate")]
    public bool Duplicate { get; set; }

    [JsonIgnore]
    public DateTime? ParsedPubDate
    {
        get
        {
            if (DateTime.TryParse(PubDate, out var date))
                return date;
            return null;
        }
    }
}
