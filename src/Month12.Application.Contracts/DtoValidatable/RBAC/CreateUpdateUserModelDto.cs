using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Month12.DtoValidatable
{
    public class CreateUpdateUserModelDto
    {
        [Required]
        public string LoginName { get; set; }//登录账号
        [Required]
        public string LoginPwd { get; set; }//登录密码
        [Required]
        public string UserName { get; set; }//姓名
        [Required]
        public string Phone { get; set; }//手机号
        public string Email { get; set; }//电子邮件
        public DateTime CreateDate { get; set; } = DateTime.Now;//创建时间
        public DateTime LoginDate { get; set; }//登录时间
        public DateTime LastDate { get; set; }//上次登录时间
        public string LoginCount { get; set; }//登录次数
    }
}
