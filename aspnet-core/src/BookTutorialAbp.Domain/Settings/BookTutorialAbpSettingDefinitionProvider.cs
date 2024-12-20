using Volo.Abp.Settings;

namespace BookTutorialAbp.Settings;

public class BookTutorialAbpSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(BookTutorialAbpSettings.MySetting1));
    }
}
