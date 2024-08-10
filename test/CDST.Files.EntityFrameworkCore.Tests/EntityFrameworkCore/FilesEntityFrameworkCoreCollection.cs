using Xunit;

namespace CDST.Files.EntityFrameworkCore;

[CollectionDefinition(FilesTestConsts.CollectionDefinitionName)]
public class FilesEntityFrameworkCoreCollection : ICollectionFixture<FilesEntityFrameworkCoreFixture>
{

}
