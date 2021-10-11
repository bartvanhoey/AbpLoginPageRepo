using Volo.Abp.Modularity;

namespace LoginPage
{
    [DependsOn(
        typeof(LoginPageApplicationModule),
        typeof(LoginPageDomainTestModule)
        )]
    public class LoginPageApplicationTestModule : AbpModule
    {

    }
}