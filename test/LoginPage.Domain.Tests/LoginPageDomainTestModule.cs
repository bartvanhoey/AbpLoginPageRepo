using LoginPage.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace LoginPage
{
    [DependsOn(
        typeof(LoginPageEntityFrameworkCoreTestModule)
        )]
    public class LoginPageDomainTestModule : AbpModule
    {

    }
}