using Microsoft.AspNetCore.Mvc.Razor;

namespace OptimizelyTutorial.Infrastructure.Display
{
    public static class RazorExtensions
    {
        public static void ConfigureFeatureFolders(this RazorViewEngineOptions options)
        {
            // {0} - Action Name
            // {1} - Controller Name
            // {2} - Area Name
            // {3} - Feature Name

            options.ViewLocationFormats.Insert(0, "~/Features/Shared/{0}.cshtml");
            options.ViewLocationFormats.Insert(0, "~/Features/Blocks/{0}.cshtml");
            options.ViewLocationFormats.Insert(0, "~/Features/Blocks/{1}/{0}.cshtml");
            options.ViewLocationFormats.Insert(0, "~/Features/Shared/Views/{0}.cshtml");
            options.ViewLocationFormats.Insert(0, "~/Features/Shared/Views/{1}/{0}.cshtml");
            options.ViewLocationFormats.Insert(0, "~/Features/Shared/Views/Header/{0}.cshtml");
            options.ViewLocationFormats.Insert(0, "~/Features/{3}/{1}/{0}.cshtml");
            options.ViewLocationFormats.Insert(0, "~/Features/{3}/{0}.cshtml");
            options.ViewLocationExpanders.Add(new FeatureViewLocationExpander());

        }
    }
}
