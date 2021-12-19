using System;
using System.Collections.Generic;
using System.Text;

namespace Month12.DtoValidatable.RBAC
{
    public class CreateUpdateRoleMenuModelDto
    {
        public Guid RoleId { get; set; }//角色id
        public Guid MenuId { get; set; }//权限id
    }
}
