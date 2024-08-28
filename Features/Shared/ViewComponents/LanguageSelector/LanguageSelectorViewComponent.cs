using EPiServer.Globalization;
using EPiServer.Web.Routing;
using Microsoft.AspNetCore.Mvc;
using OptimizelyTutorial.Features.Shared.ViewModels;

namespace OptimizelyTutorial.Features.Shared.ViewComponents.LanguageSelector
{
    public class LanguageSelectorViewComponent(
        ILanguageBranchRepository _languageBranchRepository,
        IPageRouteHelper _pageRouteHelper,
        IUrlResolver _urlResolver) : ViewComponent
    {

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var currentLanguage = _languageBranchRepository.ListEnabled().FirstOrDefault(x => x.LanguageID != ContentLanguage.PreferredCulture.Name);
            
            return View(new LanguageSelectorViewModel
            {
                CurrentLanguage = currentLanguage?.Name ?? "",
                Url = _urlResolver.GetUrl(_pageRouteHelper.PageLink, currentLanguage.LanguageID),
            });
        }
    }
}
