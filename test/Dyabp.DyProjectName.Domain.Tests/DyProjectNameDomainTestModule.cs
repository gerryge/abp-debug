using Dyabp.DyProjectName.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Dyabp.DyProjectName
{
    [DependsOn(
        typeof(DyProjectNameEntityFrameworkCoreTestModule)
        )]
    public class DyProjectNameDomainTestModule : AbpModule
    {

    }
}