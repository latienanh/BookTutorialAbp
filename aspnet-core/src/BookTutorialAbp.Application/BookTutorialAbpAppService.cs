using System;
using System.Collections.Generic;
using System.Text;
using BookTutorialAbp.Localization;
using Volo.Abp.Application.Services;

namespace BookTutorialAbp;

/* Inherit your application services from this class.
 */
public abstract class BookTutorialAbpAppService : ApplicationService
{
    protected BookTutorialAbpAppService()
    {
        LocalizationResource = typeof(BookTutorialAbpResource);
    }
}
