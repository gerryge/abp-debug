using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;

namespace Dyabp.DyProjectName.Controllers
{
    [Route("api/departments")]
    public class DepartmentController : DyProjectNameController
    {
        [HttpGet]
        public async Task<ListResultDto<DepartmentDto>> GetAsync()
        {
            return await Task.FromResult(new ListResultDto<DepartmentDto>(
                new[]
                {
                    new DepartmentDto
                    {
                        Id = Guid.Parse("6267f0df-870f-4173-be44-d74b4b56d2bd"),
                        Name = "Human Resources"
                    },
                    new DepartmentDto
                    {
                        Id = Guid.Parse("21c7b61f-330c-489e-8b8c-80e0a78a5cc5"),
                        Name = "Production"
                    }
                })
            );
        }
    }
}
