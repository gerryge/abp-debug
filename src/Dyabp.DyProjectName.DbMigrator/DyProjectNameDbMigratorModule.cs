using Dyabp.DyProjectName.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace Dyabp.DyProjectName.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(DyProjectNameEntityFrameworkCoreModule),
        typeof(DyProjectNameApplicationContractsModule)
        )]
    public class DyProjectNameDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
