using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace month12.RBAC
{
    public class UserModel : AuditedAggregateRoot<Guid>
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
    }
}
