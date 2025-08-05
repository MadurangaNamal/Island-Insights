using Island_Insights.Models;
using System.Text.Json;

namespace Island_Insights.Services;

public class NewsService : INewsService
{
    private readonly HttpClient _httpClient;
    private readonly NewsDataApiSettings _settings;

    public NewsService(HttpClient httpClient, NewsDataApiSettings settings)
    {
        _httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
        _settings = settings ?? throw new ArgumentNullException(nameof(settings));
    }

    public async Task<NewsApiResponse> GetLatestNewsAsync()
    {
        var url = $"{_settings.BaseUrl}&apikey={_settings.ApiKey}";

        var options = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        };

        var jsonString = await _httpClient.GetStringAsync(url);
        var response = JsonSerializer.Deserialize<NewsApiResponse>(jsonString, options);

        return response ?? throw new InvalidOperationException("Failed to deserialize news response.");
    }
}
