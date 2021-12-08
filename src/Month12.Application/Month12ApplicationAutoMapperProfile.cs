using AutoMapper;
using month12.RBAC;
using Month12.Dto;
using Month12.DtoValidatable;

namespace Month12
{
    public class Month12ApplicationAutoMapperProfile : Profile
    {
        public Month12ApplicationAutoMapperProfile()
        {
            /* You can configure your AutoMapper mapping configuration here.
             * Alternatively, you can split your mapping configurations
             * into multiple profile classes for a better organization. */


            CreateMap<UserModel, UserModelDto>();
            CreateMap<CreateUpdateUserModelDto, UserModel>();
            CreateMap<RoleModel, RoleModelDto>();
            CreateMap<CreateUpdateRoleModelDto, RoleModel>();
        }
    }
}
