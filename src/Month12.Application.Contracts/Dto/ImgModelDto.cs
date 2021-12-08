using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;


namespace month12.Commodity
{
    public class ImgModelDto : AuditedEntityDto<Guid>
    {

        public string ImgUrl { get; set; }//图片路径
        public DateTime ImgDate { get; set; }//图片上传时间
    }
}
