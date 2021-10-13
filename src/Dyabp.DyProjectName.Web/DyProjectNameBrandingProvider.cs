using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace Dyabp.DyProjectName.Web
{
    [Dependency(ReplaceServices = true)]
    public class DyProjectNameBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "DyProjectName";
    }
}
