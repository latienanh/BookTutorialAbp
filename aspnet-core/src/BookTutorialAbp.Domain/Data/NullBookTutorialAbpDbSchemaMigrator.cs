using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace BookTutorialAbp.Data;

/* This is used if database provider does't define
 * IBookTutorialAbpDbSchemaMigrator implementation.
 */
public class NullBookTutorialAbpDbSchemaMigrator : IBookTutorialAbpDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
