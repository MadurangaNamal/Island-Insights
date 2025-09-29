using Island_Insights.Models;
using System.Text.Json;

namespace Island_Insights.Services;

public class NewsService : INewsService
{
    private readonly HttpClient _httpClient;
    private readonly NewsDataApiSettings _settings;
    private readonly JsonSerializerOptions _jsonOptions;

    public NewsService(HttpClient httpClient, NewsDataApiSettings settings)
    {
        _httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
        _settings = settings ?? throw new ArgumentNullException(nameof(settings));

        _jsonOptions = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
    }

    public Task<NewsSourcesApiResponse> GetNewsSourcesAsync(string countryCode, string? nextPage = null)
    {
        var url = BuildUrl("sources", countryCode, null, nextPage);
        return GetApiResponseAsync<NewsSourcesApiResponse>(url);
    }

    public Task<NewsArticlesApiResponse> GetNewsArticlesAsync(string countryCode, string? queryString = null, string? nextPage = null)
    {
        var url = BuildUrl("latest", countryCode, queryString, nextPage);
        return GetApiResponseAsync<NewsArticlesApiResponse>(url);
    }

    private async Task<T> GetApiResponseAsync<T>(string url)
    {
        var jsonString = await _httpClient.GetStringAsync(url);
        var response = JsonSerializer.Deserialize<T>(jsonString, _jsonOptions);
        return response ?? throw new InvalidOperationException($"Failed to deserialize response of type {typeof(T).Name}.");
    }

    private string BuildUrl(string endpoint, string countryCode, string? queryString, string? page)
    {
        var query = string.IsNullOrEmpty(queryString) ? "" : $"&category={Uri.EscapeDataString(queryString)}";

        var url = $"{_settings.BaseUrl}/{endpoint}?country={countryCode}{query}&apikey={_settings.ApiKey}";
        if (!string.IsNullOrEmpty(page))
        {
            url += $"&page={page}";
        }
        return url;
    }
}
