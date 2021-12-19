using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Month12.DtoValidatable.Commodity
{
    public class CreateUpdateGoodsModelDto
    {
        [Required]
        public string GoodsName { get; set; }//商品名称
        [Required]
        public decimal GoodPrice { get; set; }//商品价格
        [Required]
        public string GoodMessAge { get; set; }//商品描述
        public int GoodNum { get; set; }//商品库存
        [Required]
        public bool GoodState { get; set; }//商品状态
        public DateTime CreateDate { get; set; }//创建时间
    }
}
