using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;

namespace month12.RBAC
{
    public class LogModelDto : AuditedEntityDto<Guid>
    {
        public int OpenType { get; set; }//操作类型
        public string OpenMessAge { get; set; }//操作内容
        public Guid OpenPeople { get; set; }//操作人
        public DateTime OpenDate { get; set; } = DateTime.Now;//操作时间
    }

}
