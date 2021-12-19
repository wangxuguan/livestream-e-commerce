using System;
using System.Collections.Generic;
using System.Text;

namespace Month12.DtoValidatable.RBAC
{
    public class CreateUpdateUserRoleModelDto
    {
        public Guid UserId { get; set; }//用户id
        public Guid RoleId { get; set; }//角色id
    }
}
