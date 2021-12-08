using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Month12.Data;
using Volo.Abp.DependencyInjection;

namespace Month12.EntityFrameworkCore
{
    public class EntityFrameworkCoreMonth12DbSchemaMigrator
        : IMonth12DbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreMonth12DbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the Month12DbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<Month12DbContext>()
                .Database
                .MigrateAsync();
        }
    }
}
