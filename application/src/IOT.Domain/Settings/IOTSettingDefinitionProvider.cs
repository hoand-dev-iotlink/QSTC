using Volo.Abp.Settings;

namespace IOT.Settings
{
    public class IOTSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(IOTSettings.MySetting1));
        }
    }
}
