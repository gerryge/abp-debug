using Dyabp.DyProjectName.Dyabp.Users;
using Dyabp.DyProjectName.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.Users.EntityFrameworkCore;

namespace Dyabp.DyProjectName.Dyabp
{
    public class EfCoreDyUserRepository : EfCoreUserRepositoryBase<DyProjectNameDbContext, DyUser>, IDyUserRepository
    {
        public EfCoreDyUserRepository(IDbContextProvider<DyProjectNameDbContext> dbContextProvider)
            : base(dbContextProvider)
        {
        }
    }
}
