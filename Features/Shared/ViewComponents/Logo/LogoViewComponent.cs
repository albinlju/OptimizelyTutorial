using Microsoft.AspNetCore.Mvc;

namespace OptimizelyTutorial.Features.Shared.ViewComponents.Logo
{
    public class LogoViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(int? width, int? height)
        {
            return await Task.FromResult(View(new LogoViewComponentViewModel
            {
                Width = width != null ? width : 60,
                Height = height != null ? height : 60
            }));
        }
    }
}
