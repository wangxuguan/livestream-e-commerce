using System;
using System.Collections.Generic;
using System.Text;

namespace Month12.DtoView
{
    public class RoleModelView
    {
        public Guid FatherId { get; set; }//上级id
        public string RoleName { get; set; }//角色名
        public DateTime CreateTime { get; set; } = DateTime.Now;//创建时间
        public string RoleMessage { get; set; }//角色描述

        public string MenuName { get; set; }//权限名称
        public string MenuMessage { get; set; }//权限描述

        public Guid RoleId { get; set; }//角色id
        public Guid MenuId { get; set; }//权限id
    }
}
