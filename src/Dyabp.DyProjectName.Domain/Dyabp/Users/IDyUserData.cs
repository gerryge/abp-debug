using JetBrains.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Users;

namespace Dyabp.DyProjectName.Dyabp.Users
{
    public interface IDyUserData : IUserData
    {
        [CanBeNull]
        string SocialSecurityNumber { get; }
    }
}
