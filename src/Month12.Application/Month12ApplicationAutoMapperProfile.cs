using AutoMapper;
using month12.Commodity;
using month12.RBAC;
using Month12.Dto;
using Month12.DtoValidatable;
using Month12.DtoValidatable.Commodity;
using Month12.DtoValidatable.RBAC;
using Month12.DtoView;

namespace Month12
{
    public class Month12ApplicationAutoMapperProfile : Profile
    {
        public Month12ApplicationAutoMapperProfile()
        {
            /* You can configure your AutoMapper mapping configuration here.
             * Alternatively, you can split your mapping configurations
             * into multiple profile classes for a better organization. */


            //RBAC映射
            CreateMap<UserModel, UserModelDto>();
            CreateMap<CreateUpdateUserModelDto, UserModel>();

            CreateMap<RoleModel, RoleModelDto>();
            CreateMap<CreateUpdateRoleModelDto, RoleModel>();

            CreateMap<MenuModel, MenuModelDto>();
            CreateMap<CreateUpdateMenuModelDto, MenuModel>();

            CreateMap<UserRoleModel, UserRoleModelDto>();
            CreateMap<CreateUpdateUserRoleModelDto, UserRoleModel>();

            CreateMap<OrganizationModel, OrganizationModelDto>();
            CreateMap<CreateUpdateOrganizationModelDto, OrganizationModel>();

            CreateMap<RoleMenuModel, RoleMenuModelDto>();
            CreateMap<CreateUpdateRoleMenuModelDto, RoleMenuModel>();

            //Commodity映射
            CreateMap<GoodsModel, GoodsModelDto>();
            CreateMap<CreateUpdateGoodsModelDto, GoodsModel>();
        }
    }
}
