using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Month12.DtoValidatable
{
    public class CreateUpdateRoleModelDto
    {
        public Guid FatherId { get; set; }//上级id
        [Required]
        public string RoleName { get; set; }//角色名
        public DateTime CreateTime { get; set; } = DateTime.Now;//创建时间
        public string RoleMessage { get; set; }//角色描述
    }
}
