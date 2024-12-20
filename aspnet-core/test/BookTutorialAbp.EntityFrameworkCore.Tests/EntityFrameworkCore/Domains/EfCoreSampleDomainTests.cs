using BookTutorialAbp.Samples;
using Xunit;

namespace BookTutorialAbp.EntityFrameworkCore.Domains;

[Collection(BookTutorialAbpTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<BookTutorialAbpEntityFrameworkCoreTestModule>
{

}
