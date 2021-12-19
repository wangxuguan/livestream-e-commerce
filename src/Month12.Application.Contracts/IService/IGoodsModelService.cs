using month12.Commodity;
using Month12.DtoValidatable.Commodity;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Month12.IService
{
    public interface IGoodsModelService : ICrudAppService<
        GoodsModelDto,
        Guid,
        PagedAndSortedResultRequestDto,
        CreateUpdateGoodsModelDto
        >
    {
    }
}
