using month12.RBAC;
using Month12.Dto;
using Month12.DtoValidatable;
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
    public class UserModelService : CrudAppService<
        UserModel,
        UserModelDto,
        Guid,
        PagedAndSortedResultRequestDto,
        CreateUpdateUserModelDto
        >, IUserModelService
    {
        public UserModelService(IRepository<UserModel,Guid>repository)
            : base(repository)
        {

        }

    }
}
