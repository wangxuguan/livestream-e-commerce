using Month12.Dto;
using Month12.DtoValidatable;
using System;
using System.Collections.Generic;
using System.Text;
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
    }
}
