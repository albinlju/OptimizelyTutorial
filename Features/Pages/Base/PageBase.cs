using EPiServer.Web;
using OptimizelyTutorial.Infrastructure;
using System.ComponentModel.DataAnnotations;

namespace OptimizelyTutorial.Features.Pages.Base;

public class PageBase : PageData
{
    #region SEO
    [CultureSpecific]
    [Display(GroupName = TabNames.SEO, Order = 1)]
    public virtual string MetaTitle { get; set; } 

    [CultureSpecific]
    [Display(GroupName = TabNames.SEO, Order = 2)]
    public virtual string MetaDescription { get; set; }
    #endregion

    #region Content
    [CultureSpecific]
    [Display(GroupName = SystemTabNames.Content, Order = 1)]
    public virtual string Title { get; set; }   

    [Display(GroupName = SystemTabNames.Content, Order = 2)]
    public virtual ContentReference? TopImage { get; set; }

    [CultureSpecific]
    [UIHint(UIHint.Textarea)]
    [Display(GroupName = SystemTabNames.Content, Order = 3)]
    public virtual string Intro { get; set; }
    #endregion
}

