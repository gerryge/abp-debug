using AutoMapper;
using Dyabp.DyProjectName.Dyabp.Users;
using Microsoft.AspNetCore.Identity;

namespace Dyabp.DyProjectName
{
    public class DyProjectNameDomainAutoMapperProfile : Profile
    {
        public DyProjectNameDomainAutoMapperProfile()
        {
            /* You can configure your AutoMapper mapping configuration here.
             * Alternatively, you can split your mapping configurations
             * into multiple profile classes for a better organization. */
            CreateMap<IdentityUser, DyUserEto>();
        }
    }
}
