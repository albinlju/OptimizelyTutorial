using OptimizelyTutorial.Features.Blocks.Blocks.ShowcaseBlock;
using OptimizelyTutorial.Features.Blocks.CallToActionBlock;
using OptimizelyTutorial.Features.Pages.Base;
using System.ComponentModel.DataAnnotations;

namespace OptimizelyTutorial.Features.Pages.Start
{
    [ContentType(GUID = "dba63624-e5c8-4929-a97c-5232a0dff200")]
    public class StartPage : PageBase
    {

        [Display(GroupName = SystemTabNames.Content, Order = 10)]
        [CultureSpecific]
        public virtual ContentReference CtaLink { get; set; }

        [Display(GroupName = SystemTabNames.Content, Order = 20)]
        [CultureSpecific]
        [AllowedTypes([typeof(ShowcaseBlock), typeof(CallToActionBlock)])]
        public virtual ContentArea Blocks { get; set; }
    }
}
