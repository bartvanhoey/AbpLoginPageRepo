using LoginPage.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace LoginPage.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class LoginPageController : AbpController
    {
        protected LoginPageController()
        {
            LocalizationResource = typeof(LoginPageResource);
        }
    }
}