using EPiServer.Framework.DataAnnotations;
using EPiServer.Web.Mvc;
using Microsoft.AspNetCore.Mvc;

namespace OptimizelyTutorial.Features.Blocks
{
    [TemplateDescriptor(Inherited = true)]
    public class DefaultBlockController : AsyncBlockComponent<BlockBase>
    {
        protected override async Task<IViewComponentResult> InvokeComponentAsync(BlockBase currentBlock)
        {
            var blockName = currentBlock.GetOriginalType().Name;
            return await Task.FromResult(View(string.Format("~/Features/Blocks/{0}/{1}.cshtml", blockName, blockName), currentBlock));
        }
    }
}
