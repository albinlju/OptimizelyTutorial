using EPiServer.Web;
using System.ComponentModel.DataAnnotations;

namespace OptimizelyTutorial.Features.Blocks.ShowcaseItemBlock
{
    [ContentType(GUID = "71317535-ea7d-420d-8f54-767a94745ed5")]
    public class ShowcaseItemBlock : BlockBase
    {
        [Display(GroupName = SystemTabNames.Content, Order = 10)]
        public virtual string Title { get; set; } = string.Empty;

        [Display(GroupName = SystemTabNames.Content, Order = 10)]
        [UIHint(UIHint.Textarea)]
        public virtual string Description { get; set; } = string.Empty;
    }
}
