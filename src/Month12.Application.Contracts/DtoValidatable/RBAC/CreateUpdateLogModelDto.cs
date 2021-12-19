using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Month12.DtoValidatable.RBAC
{
    public class CreateUpdateLogModelDto
    {
        public int OpenType { get; set; }//操作类型
        [Required]
        public string OpenMessAge { get; set; }//操作内容
        public Guid OpenPeople { get; set; }//操作人
        public DateTime OpenDate { get; set; } = DateTime.Now;//操作时间
    }
}
