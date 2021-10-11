using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace LoginPage.Data
{
    /* This is used if database provider does't define
     * ILoginPageDbSchemaMigrator implementation.
     */
    public class NullLoginPageDbSchemaMigrator : ILoginPageDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}