using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Month12.Dto
{
    public class RoleModelDto : AuditedEntityDto<Guid>
    {
        public Guid FatherId { get; set; }//上级id
        public string RoleName { get; set; }//角色名
        public DateTime CreateTime { get; set; } = DateTime.Now;//创建时间
        public string RoleMessage { get; set; }//角色描述
    }
}
