using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace month12.Commodity
{
    public class ImgModel : AuditedAggregateRoot<Guid>
    {

        public string ImgUrl { get; set; }//图片路径
        public DateTime ImgDate { get; set; }//图片上传时间
    }
}
