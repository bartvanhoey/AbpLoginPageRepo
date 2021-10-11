using System;
using System.Collections.Generic;
using System.Text;
using LoginPage.Localization;
using Volo.Abp.Application.Services;

namespace LoginPage
{
    /* Inherit your application services from this class.
     */
    public abstract class LoginPageAppService : ApplicationService
    {
        protected LoginPageAppService()
        {
            LocalizationResource = typeof(LoginPageResource);
        }
    }
}
