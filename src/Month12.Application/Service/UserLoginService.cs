
using IdentityModel.Client;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using month12.RBAC;
using Month12.Dto;
using Month12.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;


namespace Month12.Service
{
    public class UserLoginService : Volo.Abp.Application.Services.ApplicationService, IUserLoginService
    {
        private readonly IRepository<UserModel, Guid> db;
        
        public UserLoginService(IRepository<UserModel, Guid> _db)
        {
            db = _db;
            
        }

       

        public async Task<string> Login(UserModelDto userModel)
        {
            List<UserModelDto> userModels = ObjectMapper.Map<List<UserModel>, List<UserModelDto>>(await db.GetListAsync());
            var list = userModels.Where(x => x.LoginName == userModel.LoginName && x.LoginPwd == userModel.LoginPwd).FirstOrDefault();
            string i = "登入成功";
            if (list==null)
            {
                return i = "登入失败";
            }
            return i;
        }    
    }
}
