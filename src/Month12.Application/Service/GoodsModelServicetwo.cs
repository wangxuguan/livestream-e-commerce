using Microsoft.AspNetCore.Mvc;
using month12.Commodity;
using Month12.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Month12.Service
{
    public class GoodsModelServicetwo:Volo.Abp.Application.Services.ApplicationService
    {
        Month12DbContext db;
        public GoodsModelServicetwo(Month12DbContext _db)
        {
            db = _db;
        }

       
    }

    
}
