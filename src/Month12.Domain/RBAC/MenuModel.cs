using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace month12.RBAC
{
    public class MenuModel : AuditedAggregateRoot<Guid>
    {
        public Guid? FatherId { get; set; }//父级id
        public string MenuName { get; set; }//权限名称
        public string MenuMessage { get; set; }//权限描述
        public string Url { get; set; }
    }
 
}
