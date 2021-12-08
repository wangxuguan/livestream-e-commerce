using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace month12.Commodity
{
    public class GoodsTypeModel:AuditedAggregateRoot<Guid>
    {
        public Guid GoodId { get; set; }//商品id
        public Guid TypeId { get; set; }//类型id
    }
}
