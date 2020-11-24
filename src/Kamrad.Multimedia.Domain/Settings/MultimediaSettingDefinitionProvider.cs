using Volo.Abp.Settings;

namespace Kamrad.Multimedia.Settings
{
    public class MultimediaSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(MultimediaSettings.MySetting1));
        }
    }
}
