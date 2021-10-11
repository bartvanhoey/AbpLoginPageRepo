﻿using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace LoginPage.Blazor
{
    [Dependency(ReplaceServices = true)]
    public class LoginPageBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "LoginPage";
    }
}
