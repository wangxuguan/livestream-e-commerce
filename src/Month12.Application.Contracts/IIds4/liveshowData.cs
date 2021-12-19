using System;
using System.Collections.Generic;
using System.Text;

namespace Month12.IIds4
{
    public class liveshowData<T>
    {
        public ShopStatus Status { get; set; }
        /// <summary>
        /// 消息
        /// </summary>
        public string Msg { get; set; }
        /// <summary>
        /// 数据
        /// </summary>
        public T Info { get; set; }

        /// <summary>
        /// 返回失败信息
        /// </summary>
        /// <param name="t"></param>
        /// <param name="msg"></param>
        /// <param name="resStatus"></param>
        /// <returns></returns>
        public liveshowData<T> Error(T t, Exception ex, ShopStatus shopStatus = ShopStatus.Failure)
        {
            return new liveshowData<T>() { Info = t, Msg = ex.Message, Status = shopStatus };

        }
    }
}