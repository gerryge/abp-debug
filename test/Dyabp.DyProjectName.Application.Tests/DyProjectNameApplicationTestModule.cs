using Volo.Abp.Modularity;

namespace Dyabp.DyProjectName
{
    [DependsOn(
        typeof(DyProjectNameApplicationModule),
        typeof(DyProjectNameDomainTestModule)
        )]
    public class DyProjectNameApplicationTestModule : AbpModule
    {

    }
}