using Volo.Abp.Modularity;

namespace BookTutorialAbp;

[DependsOn(
    typeof(BookTutorialAbpDomainModule),
    typeof(BookTutorialAbpTestBaseModule)
)]
public class BookTutorialAbpDomainTestModule : AbpModule
{

}
