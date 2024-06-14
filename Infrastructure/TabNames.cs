using System.ComponentModel.DataAnnotations;

namespace OptimizelyTutorial.Infrastructure;

[GroupDefinitions]
public static class TabNames
{
    [Display(Order = 10)]
    public const string SEO = "SEO";

    [Display(Order = 20)]
    public const string Navigation = "Navigation";
}

