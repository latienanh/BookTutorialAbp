using BookTutorialAbp.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace BookTutorialAbp.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(BookTutorialAbpEntityFrameworkCoreModule),
    typeof(BookTutorialAbpApplicationContractsModule)
    )]
public class BookTutorialAbpDbMigratorModule : AbpModule
{
}
