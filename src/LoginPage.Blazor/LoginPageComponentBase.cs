using LoginPage.Localization;
using Volo.Abp.AspNetCore.Components;

namespace LoginPage.Blazor
{
    public abstract class LoginPageComponentBase : AbpComponentBase
    {
        protected LoginPageComponentBase()
        {
            LocalizationResource = typeof(LoginPageResource);
        }
    }
}
