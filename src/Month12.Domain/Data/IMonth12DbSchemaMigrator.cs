using System.Threading.Tasks;

namespace Month12.Data
{
    public interface IMonth12DbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
