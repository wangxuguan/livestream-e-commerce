using month12.RBAC;
using Month12.DtoValidatable.RBAC;
using Month12.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Month12.Service
{
    public class RoleMenuModelService : CrudAppService<
        RoleMenuModel,
        RoleMenuModelDto,
        Guid,
        PagedAndSortedResultRequestDto,
        CreateUpdateRoleMenuModelDto
        >, IRoleMenuModelService
    {
        public RoleMenuModelService(IRepository<RoleMenuModel, Guid> repository)
            : base(repository)
        {

        }


    }
}
