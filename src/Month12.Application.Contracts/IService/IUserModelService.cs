using Month12.Dto;
using Month12.DtoValidatable;
using Month12.DtoView;
using Month12.IIds4;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
 
namespace Month12.IService
{
    public interface IUserModelService:ICrudAppService<
        UserModelDto,
        Guid,
        PagedAndSortedResultRequestDto,
        CreateUpdateUserModelDto
        >
    {
        Task<List<UserModelView>> Query();
        Task<liveshowData<string>> GetLogin(string userName, string userPwd);
    }
}
