using System;
using System.Collections.Generic;
using System.Text;

namespace Month12.DtoView
{
    public class UserModelView
    {
        public string LoginName { get; set; }//登录账号
        public string LoginPwd { get; set; }//登录密码
        public string UserName { get; set; }//姓名
        public string Phone { get; set; }//手机号
        public string Email { get; set; }//电子邮件
        public DateTime CreateDate { get; set; } = DateTime.Now;//创建时间
        public DateTime LoginDate { get; set; }//登录时间
        public DateTime LastDate { get; set; }//上次登录时间
        public string LoginCount { get; set; }//登录次数

        public Guid FatherId { get; set; }//上级id
        public string RoleName { get; set; }//角色名
        public DateTime CreateTime { get; set; } = DateTime.Now;//创建时间
        public string RoleMessage { get; set; }//角色描述

        public Guid UserId { get; set; }//用户id
        public Guid RoleId { get; set; }//角色id
    }
}
