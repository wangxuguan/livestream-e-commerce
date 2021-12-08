using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace month12.Commodity
{
    public class SpecificationModel : AuditedAggregateRoot<Guid>
    {
        public string SpeciColor { get; set; }//颜色
        public string SpeciEdition { get; set; }//版本
        public decimal SpeciWeight { get; set; }//重量
        public string SpeciSize { get; set; }//大小/尺寸
    }
}
