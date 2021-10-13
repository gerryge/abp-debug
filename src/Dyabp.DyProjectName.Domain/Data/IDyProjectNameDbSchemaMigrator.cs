using System.Threading.Tasks;

namespace Dyabp.DyProjectName.Data
{
    public interface IDyProjectNameDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
