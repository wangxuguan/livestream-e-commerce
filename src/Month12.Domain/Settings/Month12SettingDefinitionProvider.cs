using Volo.Abp.Settings;

namespace Month12.Settings
{
    public class Month12SettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(Month12Settings.MySetting1));
        }
    }
}
