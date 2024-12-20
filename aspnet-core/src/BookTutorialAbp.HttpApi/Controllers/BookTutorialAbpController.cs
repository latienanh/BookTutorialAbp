using BookTutorialAbp.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace BookTutorialAbp.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class BookTutorialAbpController : AbpControllerBase
{
    protected BookTutorialAbpController()
    {
        LocalizationResource = typeof(BookTutorialAbpResource);
    }
}
