using Microsoft.AspNetCore.Mvc;
using month12.RBAC;
using Month12.Dto;
using Month12.DtoValidatable;
using Month12.DtoView;
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
    public class RoleModelService:CrudAppService<
        RoleModel,
        RoleModelDto,
        Guid,
        PagedAndSortedResultRequestDto,
        CreateUpdateRoleModelDto
        >,IRoleModelService
    {
        private readonly IRepository<RoleModel, Guid> _roleModels;
        private readonly IRepository<MenuModel, Guid> _menuModels;
        private readonly IRepository<RoleMenuModel, Guid> _roleMenuModels;
        public RoleModelService(IRepository<RoleModel, Guid> repository,
            IRepository<MenuModel, Guid> menuModels,
            IRepository<RoleMenuModel, Guid> roleMenuModels
            )
            : base(repository)
        {
            _roleModels = repository;
            _menuModels = menuModels;
            _roleMenuModels = roleMenuModels;
        }

        [HttpGet]
        public async Task<List<RoleModelView>> Query()
        {
            List<RoleModelDto> rms = ObjectMapper.Map<List<RoleModel>, List<RoleModelDto>>(await _roleModels.GetListAsync());
            List<MenuModelDto> mms = ObjectMapper.Map<List<MenuModel>, List<MenuModelDto>>(await _menuModels.GetListAsync());
            List<RoleMenuModelDto> rmms = ObjectMapper.Map<List<RoleMenuModel>, List<RoleMenuModelDto>>(await _roleMenuModels.GetListAsync());

            var list = (from a in rms
                        join b in rmms on a.Id equals b.RoleId
                        join c in mms on b.MenuId equals c.Id
                        select new RoleModelView
                        {
                            RoleName=a.RoleName,
                            RoleMessage=a.RoleMessage,
                            MenuName=c.MenuName,
                            MenuMessage=c.MenuMessage
                        }
                ).ToList();
            return list;
        }
    }
}
