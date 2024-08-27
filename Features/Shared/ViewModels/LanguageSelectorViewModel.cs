namespace OptimizelyTutorial.Features.Shared.ViewModels
{
    public class LanguageSelectorViewModel
    {
        public IList<LanguageBranch> Languages { get; set; }
        public string PreferredLanguage { get; set; }
        public PageReference CurrentPageLink { get; set; }
    }
}
