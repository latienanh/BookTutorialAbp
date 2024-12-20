using Xunit;

namespace BookTutorialAbp.EntityFrameworkCore;

[CollectionDefinition(BookTutorialAbpTestConsts.CollectionDefinitionName)]
public class BookTutorialAbpEntityFrameworkCoreCollection : ICollectionFixture<BookTutorialAbpEntityFrameworkCoreFixture>
{

}
