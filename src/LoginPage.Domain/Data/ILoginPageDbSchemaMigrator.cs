using System.Threading.Tasks;

namespace LoginPage.Data
{
    public interface ILoginPageDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
