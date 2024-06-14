using EPiServer.ServiceLocation;
using EPiServer.Web.Routing;
using OptimizelyTutorial.Features.Pages.Base;
using OptimizelyTutorial.Features.Shared.ViewModels;

namespace OptimizelyTutorial.Features.Pages.Start
{
    [ServiceConfiguration(typeof(StartPageViewModelFactory), Lifecycle = ServiceInstanceScope.Singleton)]
    public class StartPageViewModelFactory(IUrlResolver _urlResolver, IContentLoader _contentLoader) : PageViewModelFactoryBase
    {
        public StartPageViewModel Create(StartPage page)
        {
            _contentLoader.TryGet(page.CtaLink, out PageBase ctaPage);
               
            return new StartPageViewModel
            {
                Head = CreateHead(page),
                Title = page.Title,
                TopImage = _urlResolver.GetUrl(page.TopImage),
                Intro = page.Intro,
                Blocks = page.Blocks,
                CtaLink = new LinkViewModel
                {
                    Name = ctaPage?.Name,
                    Url = _urlResolver.GetUrl(ctaPage)
                }
            };
        }

    }
}
