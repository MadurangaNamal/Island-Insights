using Island_Insight.Models;

namespace Island_Insight.Services;

public interface INewsService
{
    Task<NewsApiResponse> GetLatestNewsAsync();
}
