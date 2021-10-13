using System;
using System.Collections.Generic;
using System.Text;
using Dyabp.DyProjectName.Localization;
using Volo.Abp.Application.Services;

namespace Dyabp.DyProjectName
{
    /* Inherit your application services from this class.
     */
    public abstract class DyProjectNameAppService : ApplicationService
    {
        protected DyProjectNameAppService()
        {
            LocalizationResource = typeof(DyProjectNameResource);
        }
    }
}
