namespace OptimizelyTutorial.Features.Pages.Base
{
    public abstract class PageViewModelFactoryBase
    {
        public Head CreateHead(PageBase page)
        {
            return new Head
            {
                MetaTitle = page.MetaTitle,
                MetaDescription = page.MetaDescription,
            };
        }
    }
}
