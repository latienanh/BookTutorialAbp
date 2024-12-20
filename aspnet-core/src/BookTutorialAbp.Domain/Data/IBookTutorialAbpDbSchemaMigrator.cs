using System.Threading.Tasks;

namespace BookTutorialAbp.Data;

public interface IBookTutorialAbpDbSchemaMigrator
{
    Task MigrateAsync();
}
