using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace month12.RBAC
{
    public class RoleModel : AuditedAggregateRoot<Guid>
    {
        public Guid FatherId { get; set; }//上级id
        public string RoleName { get; set; }//角色名
        public DateTime CreateTime { get; set; } = DateTime.Now;//创建时间
        public string RoleMessage { get; set; }//角色描述
    }
}
