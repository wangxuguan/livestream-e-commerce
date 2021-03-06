using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace month12.Commodity
{
    public class GoodsImgModel : AuditedAggregateRoot<Guid>
    {
        public Guid UserId { get; set; }//商品id
        public Guid ImgId { get; set; }//图片id
    }

}
