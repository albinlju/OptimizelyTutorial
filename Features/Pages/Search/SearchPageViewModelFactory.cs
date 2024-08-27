using EPiServer.ServiceLocation;
using EPiServer.Web.Routing;
using OptimizelyTutorial.Features.Pages.Base;
using OptimizelyTutorial.Features.Pages.Standard;

namespace OptimizelyTutorial.Features.Pages.Search
{
    [ServiceConfiguration(typeof(SearchPageViewModelFactory), Lifecycle = ServiceInstanceScope.Singleton)]
    public class SearchPageViewModelFactory(IUrlResolver _urlResolver) : PageViewModelFactoryBase
    {
        public SearchPageViewModel Create(SearchPage page, IEnumerable<StandardPage> searchResults, string query)
        {
            return new SearchPageViewModel
            {
                Head = CreateHead(page),
                Title = page.Title,
                TopImage = _urlResolver.GetUrl(page.TopImage),
                Intro = page.Intro,
                SearchResults = searchResults,
                Query = query
            };
        }
    }
}
