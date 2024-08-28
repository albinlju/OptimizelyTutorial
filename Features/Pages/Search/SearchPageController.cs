using EPiServer.Find;
using EPiServer.Find.Cms;
using EPiServer.Find.Statistics;
using EPiServer.Globalization;
using EPiServer.Web.Mvc;
using Microsoft.AspNetCore.Mvc;
using OptimizelyTutorial.Features.Pages.Standard;

namespace OptimizelyTutorial.Features.Pages.Search
{
    public class SearchPageController(
        SearchPageViewModelFactory _searchPageViewModelFactory,
        IClient _client
        ) : PageController<SearchPage>
    {
        public IActionResult Index(SearchPage page, string query)
        {

            var search = _client.Search<StandardPage>()
            .For(query)
            .WithAndAsDefaultOperator()
            .InField(x => x.Name)
            .InField(x => x.Title)
            .InField(x => x.Intro)
            .FilterForVisitor()
            .FilterOnCurrentSite()
            .ApplyBestBets(2000)
            .StatisticsTrack();
                
            if(TimeSpan.FromMinutes(page.CacheTime) != TimeSpan.Zero)
            {
                search.StaticallyCacheFor(TimeSpan.FromMinutes(page.CacheTime));
            }

            var results = search.GetContentResult();

            var viewModel = _searchPageViewModelFactory.Create(page, results.Items, query);
            return View(viewModel);
        }
    }
}
