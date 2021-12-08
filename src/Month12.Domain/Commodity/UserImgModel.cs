using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace month12.Commodity
{
    public class UserImgModel : AuditedAggregateRoot<Guid>
    {
        public Guid UserId { get; set; }//用户id
        public Guid ImgId { get; set; }//图片id
    }
}
