using Volo.Abp.Settings;

namespace ShortUrl.Settings;

public class ShortUrlSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(ShortUrlSettings.MySetting1));
    }
}
