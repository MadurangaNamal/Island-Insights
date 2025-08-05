using Island_Insights.Models;

namespace Island_Insights.Services;

public interface INewsService
{
    Task<NewsApiResponse> GetLatestNewsAsync();
}
