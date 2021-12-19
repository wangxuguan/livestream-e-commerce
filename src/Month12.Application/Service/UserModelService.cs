using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using month12.RBAC;
using Month12.Dto;
using Month12.DtoValidatable;
using Month12.DtoView;
using Month12.IIds4;
using Month12.IIds4Service;
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
        private IConfiguration _configuration;
        private readonly IRepository<UserModel, Guid> _userModels;
        private readonly IRepository<RoleModel, Guid> _roleModels;
        private readonly IRepository<UserRoleModel, Guid> _userRoleModels;
        public UserModelService(IRepository<UserModel,Guid>repository,
            
            IRepository<RoleModel, Guid> roleModels,
            IRepository<UserRoleModel, Guid> userRoleModels,
            IConfiguration configuration
            )
            : base(repository)
        {
            _userModels = repository;
            _roleModels = roleModels;
            _userRoleModels = userRoleModels;
            _configuration = configuration;
        }

        public async Task<liveshowData<string>> GetLogin(string userName, string userPwd)
        {
            Ids4Service ids4Service = new Ids4Service(_configuration);
            string token = await ids4Service.GetIdsTokenAsync(userName, userPwd);
            return new liveshowData<string>() { Status = ShopStatus.Succeed, Msg = "获取token成功", Info = token };
        }

        [HttpGet]
        public async Task<List<UserModelView>> Query()
        {
            List<UserModelDto> usermodel = ObjectMapper.Map<List<UserModel>, List<UserModelDto>>(await _userModels.GetListAsync());
            List<RoleModelDto> rolemodel = ObjectMapper.Map<List<RoleModel>, List<RoleModelDto>>(await _roleModels.GetListAsync());
            List<UserRoleModelDto> userrolemodel = ObjectMapper.Map<List<UserRoleModel>, List<UserRoleModelDto>>(await _userRoleModels.GetListAsync());

            var list = (from a in usermodel
                        join c in userrolemodel on a.Id equals c.UserId
                        join b  in rolemodel on c.RoleId equals b.Id
                        select new UserModelView
                        {
                            UserName=a.UserName,
                            Phone=a.Phone,
                            Email=a.Email,
                            RoleName=b.RoleName,
                            RoleMessage=b.RoleMessage,
                        }
                ).ToList();
            return list;
        }
    }
}
