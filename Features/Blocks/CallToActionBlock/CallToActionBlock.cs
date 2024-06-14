using EPiServer.Web;
using System.ComponentModel.DataAnnotations;

namespace OptimizelyTutorial.Features.Blocks.CallToActionBlock
{
    [ContentType(GUID = "f930a0af-2a71-4b7e-8348-6859ad91e3f4")]
    public class CallToActionBlock : BlockBase
    {
        [Display(GroupName = SystemTabNames.Content, Order = 10)]
        public virtual string Title { get; set; } = string.Empty;

        [Display(GroupName = SystemTabNames.Content, Order = 20)]
        [UIHint(UIHint.Textarea)]
        public virtual string Description { get; set; } = string.Empty;

        [Display(GroupName = SystemTabNames.Content, Order = 30)]
        public virtual ContentReference Link { get; set; }
    }
}
