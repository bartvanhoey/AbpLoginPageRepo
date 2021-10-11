using LoginPage.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace LoginPage.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(LoginPageEntityFrameworkCoreModule),
        typeof(LoginPageApplicationContractsModule)
        )]
    public class LoginPageDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
