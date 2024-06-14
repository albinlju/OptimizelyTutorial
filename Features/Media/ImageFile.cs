using EPiServer.Framework.DataAnnotations;
using System.ComponentModel.DataAnnotations;

namespace OptimizelyTutorial.Features.Media
{
    [ContentType(GUID = "183A753E-ACFB-4EE9-8EF1-423D1953D238")]
    [MediaDescriptor(ExtensionString = "jpg,jpeg,gif,bmp,png,webp,svg")]

    public class ImageFile : ImageData
    {
        [Display(GroupName = SystemTabNames.Content, Order = 10)]
        public virtual string Alt { get; set; } = string.Empty;
    }
}
