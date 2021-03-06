using Month12.Dto;
using Month12.DtoValidatable;
using Month12.DtoView;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Month12.IService
{
    public interface IRoleModelService: ICrudAppService<
        RoleModelDto,
        Guid,
        PagedAndSortedResultRequestDto,
        CreateUpdateRoleModelDto
        >
    {
        Task<List<RoleModelView>> Query();
    }
}
