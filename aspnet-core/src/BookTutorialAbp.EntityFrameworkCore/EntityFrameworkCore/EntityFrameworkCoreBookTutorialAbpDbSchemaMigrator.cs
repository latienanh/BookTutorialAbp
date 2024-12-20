using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using BookTutorialAbp.Data;
using Volo.Abp.DependencyInjection;

namespace BookTutorialAbp.EntityFrameworkCore;

public class EntityFrameworkCoreBookTutorialAbpDbSchemaMigrator
    : IBookTutorialAbpDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreBookTutorialAbpDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolve the BookTutorialAbpDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<BookTutorialAbpDbContext>()
            .Database
            .MigrateAsync();
    }
}
