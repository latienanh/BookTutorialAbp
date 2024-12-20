using Microsoft.Extensions.Localization;
using BookTutorialAbp.Localization;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace BookTutorialAbp;

[Dependency(ReplaceServices = true)]
public class BookTutorialAbpBrandingProvider : DefaultBrandingProvider
{
    private IStringLocalizer<BookTutorialAbpResource> _localizer;

    public BookTutorialAbpBrandingProvider(IStringLocalizer<BookTutorialAbpResource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];
}
