using OptimizelyTutorial.Features.Shared.ViewModels;

namespace OptimizelyTutorial.Features.Shared.Services.NavigationService
{
    public interface INavigationSerrvice
    {
        public IEnumerable<LinkViewModel> GetMainNavigation();
    }
}
