using Microsoft.AspNetCore.Builder;
using CDST.Files;
using Volo.Abp.AspNetCore.TestBase;

var builder = WebApplication.CreateBuilder();
await builder.RunAbpModuleAsync<FilesWebTestModule>();

public partial class Program
{
}
