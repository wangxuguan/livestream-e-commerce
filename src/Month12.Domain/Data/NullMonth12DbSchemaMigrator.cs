using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Month12.Data
{
    /* This is used if database provider does't define
     * IMonth12DbSchemaMigrator implementation.
     */
    public class NullMonth12DbSchemaMigrator : IMonth12DbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}