using Island_Insights.Models;

namespace Island_Insights.Services;

public interface INewsService
{
    Task<NewsSourcesApiResponse> GetNewsSourcesAsync(string countryCode, string? nextPage);
    Task<NewsArticlesApiResponse> GetNewsArticlesAsync(string countryCode, string? queryString, string? nextPage);
}
