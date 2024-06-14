using OptimizelyTutorial.Features.Pages.Base;
using OptimizelyTutorial.Features.Shared.ViewModels;

namespace OptimizelyTutorial.Features.Pages.Start
{
    public class StartPageViewModel : PageBaseViewModel
    {
        public ContentArea Blocks { get; set; } = new();
        public LinkViewModel CtaLink { get; set; } = new();
    }
}
