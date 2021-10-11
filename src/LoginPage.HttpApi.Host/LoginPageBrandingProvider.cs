using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace LoginPage
{
    [Dependency(ReplaceServices = true)]
    public class LoginPageBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "LoginPage";
    }
}
