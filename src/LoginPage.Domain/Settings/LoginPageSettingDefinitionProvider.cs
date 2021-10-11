using Volo.Abp.Settings;

namespace LoginPage.Settings
{
    public class LoginPageSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(LoginPageSettings.MySetting1));
        }
    }
}
