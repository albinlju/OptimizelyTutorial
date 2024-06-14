namespace OptimizelyTutorial.Features.Pages.Base
{
    public class PageBaseViewModel
    {
        public Head Head { get; set; } = new();
        public string Title { get; set; } = string.Empty;
        public string TopImage { get; set; } = string.Empty;
        public string Intro { get; set; } = string.Empty;
    }

    public class Head
    {
        public string MetaTitle { get; set; } = string.Empty;
        public string MetaDescription { get; set; } = string.Empty;
    }
}

