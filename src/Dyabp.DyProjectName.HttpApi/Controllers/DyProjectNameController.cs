using Dyabp.DyProjectName.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Dyabp.DyProjectName.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class DyProjectNameController : AbpController
    {
        protected DyProjectNameController()
        {
            LocalizationResource = typeof(DyProjectNameResource);
        }
    }
}