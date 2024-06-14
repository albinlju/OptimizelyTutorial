using EPiServer.Web.Mvc;
using Microsoft.AspNetCore.Mvc;

namespace OptimizelyTutorial.Features.Pages.Start
{
    public class StartPageController(StartPageViewModelFactory _startPageViewModelFactory)
        : PageController<StartPage>
    {
        public IActionResult Index(StartPage page)
        {
            var viewModel = _startPageViewModelFactory.Create(page);
            return View(viewModel);
        }
    }
}
