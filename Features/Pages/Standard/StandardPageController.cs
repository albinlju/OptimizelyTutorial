using EPiServer.Web.Mvc;
using Microsoft.AspNetCore.Mvc;

namespace OptimizelyTutorial.Features.Pages.Standard
{
    public class StandardPageController(StandardPageViewModelFactory _standardPageViewModelFactory)
        : PageController<StandardPage>
    {
        public IActionResult Index(StandardPage page)
        {
            var viewModel = _standardPageViewModelFactory.Create(page);
            return View(viewModel);
        }
    }
}
