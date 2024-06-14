using OptimizelyTutorial.Features.Blocks.Blocks.ShowcaseBlock;
using OptimizelyTutorial.Features.Blocks.CallToActionBlock;
using OptimizelyTutorial.Features.Pages.Base;
using System.ComponentModel.DataAnnotations;

namespace OptimizelyTutorial.Features.Pages.Standard
{
    [ContentType(GUID = "ba7c4955-9109-4f50-a118-8f7a5f18d8f2")]
    public class StandardPage : PageBase
    {
        [CultureSpecific]
        [Display(GroupName = SystemTabNames.Content, Order = 10)]
        public virtual XhtmlString Text { get; set; }

        [Display(GroupName = SystemTabNames.Content, Order = 20)]
        [CultureSpecific]
        [AllowedTypes([typeof(ShowcaseBlock), typeof(CallToActionBlock)])]
        public virtual ContentArea Blocks { get; set; }
    }
}
