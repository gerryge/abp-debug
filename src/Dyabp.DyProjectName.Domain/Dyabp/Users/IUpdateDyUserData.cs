using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dyabp.DyProjectName.Dyabp.Users
{
    public interface IUpdateDyUserData
    {
        bool Update([NotNull] IDyUserData user);
    }
}
