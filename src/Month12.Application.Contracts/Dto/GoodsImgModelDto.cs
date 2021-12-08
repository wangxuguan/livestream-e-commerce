using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;

namespace month12.Commodity
{
    public class GoodsImgModelDto : AuditedEntityDto<Guid>
    {
        public Guid UserId { get; set; }//商品id
        public Guid ImgId { get; set; }//图片id
    }

}
