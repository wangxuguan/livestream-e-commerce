using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Month12.DtoValidatable
{
    public class CreateUpdateMenuModelDto
    {
        public Guid FatherId { get; set; }//父级id
        [Required]
        public string MenuName { get; set; }//权限名称
        [Required]
        public string MenuMessage { get; set; }//权限描述
    }
}
