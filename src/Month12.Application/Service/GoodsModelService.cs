using Microsoft.AspNetCore.Mvc;
using month12.Commodity;
using Month12.DtoValidatable.Commodity;
using Month12.EntityFrameworkCore;
using Month12.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Month12.Service
{
    public class GoodsModelService : CrudAppService<
        GoodsModel,
        GoodsModelDto,
        Guid,
        PagedAndSortedResultRequestDto,
        CreateUpdateGoodsModelDto
        >, IGoodsModelService
    {
        Month12DbContext db;
        public GoodsModelService(IRepository<GoodsModel, Guid> repository, Month12DbContext _db)
            : base(repository)
        {
            db = _db;
        }

        [HttpGet, Route("Show")]
        public UDto Show(int pageindex=1, int pagesize=2,string goodsName="")
        {
            UDto dto = new UDto();
            var list = db.GoodsModel.ToList();
            if (!string.IsNullOrEmpty(goodsName))
            {
                list = list.Where(x => x.GoodsName.Contains(goodsName)).ToList();
            }
            var total = list.Count();
            var xvlist = list.OrderBy(x => x.Id).Skip((pageindex - 1) * pagesize).Take(pagesize).ToList();
            
            dto.count = total;
            dto.list = xvlist;
            return dto;
        }

        public class UDto
        {
            public int count { get; set; }
            public List<GoodsModel> list { get; set; }

        }
    }
}
