using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;

namespace month12.RBAC
{
    public class UserRoleModelDto : AuditedEntityDto<Guid>
    {
        public Guid UserId { get; set; }//用户id
        public Guid RoleId { get; set; }//角色id
    }
}
