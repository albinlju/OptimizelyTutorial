using OptimizelyTutorial.Features.Pages.Base;

namespace OptimizelyTutorial.Features.Pages.Standard
{
    public class StandardPageViewModel : PageBaseViewModel
    {
        public XhtmlString Text { get; set; } = new();
        public ContentArea Blocks { get; set; } = new();
    }
}
