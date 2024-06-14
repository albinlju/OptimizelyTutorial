using Microsoft.AspNetCore.Mvc;
using OptimizelyTutorial.Features.Shared.Services.NavigationService;

namespace OptimizelyTutorial.Features.Shared.ViewComponents.Navigation
{
    public class MainNavigationViewComponent(INavigationSerrvice _navigationSerrvice) : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync() => View(_navigationSerrvice.GetMainNavigation());
        
    }
}
