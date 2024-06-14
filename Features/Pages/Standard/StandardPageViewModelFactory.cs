using EPiServer.ServiceLocation;
using EPiServer.Web.Routing;
using OptimizelyTutorial.Features.Pages.Base;

namespace OptimizelyTutorial.Features.Pages.Standard
{
    [ServiceConfiguration(typeof(StandardPageViewModelFactory), Lifecycle = ServiceInstanceScope.Singleton)]
    public class StandardPageViewModelFactory(IUrlResolver _urlResolver) : PageViewModelFactoryBase
    {
        public StandardPageViewModel Create(StandardPage page)
        {
            return new StandardPageViewModel
            {
                Head = CreateHead(page),
                Title = page.Title,
                TopImage = _urlResolver.GetUrl(page.TopImage),
                Intro = page.Intro,
                Text = page.Text,
                Blocks = page.Blocks
            };
        }
    }
}
