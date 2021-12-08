using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;

namespace month12.Commodity
{
    public class IndentDetailModelDto : AuditedEntityDto<Guid>
    {

        public DateTime DateOfOrder { get; set; }//下单日期
        public int PayWayInfoId { get; set; }//支付方式
        public Guid Ur_id { get; set; }//用户id
        public string OrderInfoAddre { get; set; }//收货人地址
        public string OrderInfoName { get; set; }//收货人姓名
        public string ShoppAddreTel { get; set; }//收货人电话
        public decimal OrderInfoSalePrice { get; set; }//订单总金额
        public decimal CommodCountPrice { get; set; }//商品总金额
        public string OrderInfoBarCode { get; set; }//配送方式
        public decimal OrderInfoPayPrice { get; set; }//实付金额
        public string OrderInfoActiveName { get; set; }//应收金额
        public decimal OrderDiscount { get; set; }//引用折扣
        public decimal OrderPrivilPrice { get; set; }//优惠金额
        public int OrderInfoActivePrice { get; set; }//运费
        public string OrderInvoiceM { get; set; }//发票信息
        public int OrderWheShipments { get; set; }//是否发货
        public int OrderInfoAuditState { get; set; }//审核状态  10已下单  20已取消  30已付款
        public int OrderInfoWhetherPay { get; set; }//是否支付
        public int OrderInfoState { get; set; }//订单状态（10已下单（未支付），20待发货（已支付），30已发货（待收货），40已完成（已确认），50订单取消（订单关闭））
        public int OrderInfoDeliveryState { get; set; }//配送状态
        public string OrderInfoWaybillNum { get; set; }//运单号
        public string LogComId { get; set; }//配送公司
        public int CommodEvaluaGrade { get; set; }//评星级别
        public decimal CommodEvaluaTime { get; set; }//发表时间
        public int CommodEvaluaOrder { get; set; }//前台是否显示
    }

}
