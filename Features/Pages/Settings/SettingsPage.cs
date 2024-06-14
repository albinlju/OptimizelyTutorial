using OptimizelyTutorial.Features.Pages.Standard;

namespace OptimizelyTutorial.Features.Pages.Settings
{

    [ContentType(GUID = "2a27a320-4b39-431a-a7e6-b68b2f5d3bbc")]
    public class SettingsPage : PageData
    {
        [CultureSpecific]
        [AllowedTypes([typeof(StandardPage)])]
        public virtual ContentArea MainNavigation { get; set; } = new();
    }
}
