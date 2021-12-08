using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace month12.RBAC
{
    public class RoleMenuModel : AuditedAggregateRoot<Guid>
    {
        public Guid RoleId { get; set; }//角色id
        public Guid MenuId { get; set; }//权限id
    }

}
