using Month12.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Month12.IService
{
    public interface IUserLoginService:Volo.Abp.Application.Services.IApplicationService
    {
        Task<string> Login(UserModelDto userModel);
        
    }

    
}
