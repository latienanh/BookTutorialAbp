using Volo.Abp.Modularity;

namespace BookTutorialAbp;

[DependsOn(
    typeof(BookTutorialAbpApplicationModule),
    typeof(BookTutorialAbpDomainTestModule)
)]
public class BookTutorialAbpApplicationTestModule : AbpModule
{

}
