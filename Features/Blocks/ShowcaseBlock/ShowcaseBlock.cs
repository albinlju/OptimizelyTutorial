using EPiServer.Web;
using System.ComponentModel.DataAnnotations;

namespace OptimizelyTutorial.Features.Blocks.Blocks.ShowcaseBlock
{
    [ContentType(GUID = "583fb66e-8dff-4fbe-98ee-c7f8cf04516b")]
    public class ShowcaseBlock : BlockBase
    {
        [Display(GroupName = SystemTabNames.Content, Order = 10)]
        public virtual string Title { get; set; } = string.Empty;

        [Display(GroupName = SystemTabNames.Content, Order = 20)]
        [UIHint(UIHint.Textarea)]
        public virtual string Description { get; set; } = string.Empty;

        [Display(GroupName = SystemTabNames.Content, Order = 30)]
        [AllowedTypes([typeof(ShowcaseItemBlock.ShowcaseItemBlock)])]
        public virtual ContentArea ShowcaseItems { get; set; } = new();
    }
}
