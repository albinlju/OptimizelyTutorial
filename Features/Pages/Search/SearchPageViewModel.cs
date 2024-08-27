using OptimizelyTutorial.Features.Pages.Base;
using OptimizelyTutorial.Features.Pages.Standard;

namespace OptimizelyTutorial.Features.Pages.Search
{
    public class SearchPageViewModel : PageBaseViewModel
    {
        public IEnumerable<StandardPage> SearchResults { get; set; } = Enumerable.Empty<StandardPage>();
        public string Query { get; set; } = string.Empty;
    }
}
