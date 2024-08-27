using EPiServer.Globalization;
using EPiServer.Web.Routing;
using Microsoft.AspNetCore.Mvc;
using OptimizelyTutorial.Features.Shared.ViewModels;

namespace OptimizelyTutorial.Features.Shared.ViewComponents.LanguageSelector
{
    public class LanguageSelectorViewComponent(
        ILanguageBranchRepository _languageBranchRepository,
        IPageRouteHelper _pageRouteHelper) : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync() => View(new LanguageSelectorViewModel {
          Languages =  _languageBranchRepository.ListEnabled(),
          PreferredLanguage = ContentLanguage.PreferredCulture.Name,
          CurrentPageLink = _pageRouteHelper.PageLink
        });
    }
}
