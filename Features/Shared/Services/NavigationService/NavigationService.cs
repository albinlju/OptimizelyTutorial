using EPiServer.ServiceLocation;
using EPiServer.Web.Routing;
using OptimizelyTutorial.Features.Pages.Base;
using OptimizelyTutorial.Features.Pages.Settings;
using OptimizelyTutorial.Features.Shared.ViewModels;

namespace OptimizelyTutorial.Features.Shared.Services.NavigationService
{
    [ServiceConfiguration(typeof(INavigationSerrvice), Lifecycle = ServiceInstanceScope.Singleton)]
    public class NavigationService(IContentLoader _contentLoader, IUrlResolver _urlResolver) : INavigationSerrvice
    {
        public IEnumerable<LinkViewModel> GetMainNavigation()
        {
            var links = new List<LinkViewModel>();
            
            var settingsPage = _contentLoader.GetChildren<SettingsPage>(ContentReference.StartPage).FirstOrDefault();
            if (settingsPage is null || settingsPage.MainNavigation == null) return links;

            foreach(var pageReference in settingsPage.MainNavigation.Items)
            {
                var page = _contentLoader.Get<PageBase>(pageReference.ContentLink);
                links.Add(new LinkViewModel
                {
                    Name = page.Title,
                    Url = _urlResolver.GetUrl(page)
                });
            }

            return links;
        }
    }
}
