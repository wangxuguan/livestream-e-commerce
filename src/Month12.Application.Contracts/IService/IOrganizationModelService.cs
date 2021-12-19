using month12.RBAC;
using Month12.DtoValidatable.RBAC;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Month12.IService
{
    public interface IOrganizationModelService:ICrudAppService<
        OrganizationModelDto,
        Guid,
        PagedAndSortedResultRequestDto,
        CreateUpdateOrganizationModelDto
        >
    {

    }
}
