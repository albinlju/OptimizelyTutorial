using OptimizelyTutorial.Features.Pages.Base;
using System.ComponentModel.DataAnnotations;

namespace OptimizelyTutorial.Features.Pages.Search
{
    [ContentType(GUID = "90e231a7-0132-4a27-80a2-931a3f6d9c2d")]
    public class SearchPage : PageBase
    {
        [Display(GroupName = SystemTabNames.Settings, Order = 10)]
        [Range(0, 30)]
        public virtual int CacheTime { get; set; }

        [Display(GroupName = SystemTabNames.Settings,Order = 20)]
        [Range(1, 100)]
        public virtual int SearchResultSize { get; set; }


        public override void SetDefaultValues(ContentType contentType)
        {
            base.SetDefaultValues(contentType);
            this.CacheTime = 0;
            this.SearchResultSize = 12;
        }
    }
}
