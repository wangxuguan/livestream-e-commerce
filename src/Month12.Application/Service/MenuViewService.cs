using month12.RBAC;
using Month12.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace Month12.Service
{
    public class MenuViewService : Volo.Abp.Application.Services.ApplicationService
    {
        private readonly IRepository<MenuModel, Guid> db;
        public MenuViewService(IRepository<MenuModel, Guid> _db)
        {
            db = _db;
        }
        public async Task<IEnumerable<MenuModelView>> Query(string Tid )
        {
            var a = new List<MenuModelView>();

            List<MenuModelDto> A = ObjectMapper.Map<List<MenuModel>, List<MenuModelDto>>(await db.GetListAsync());
            var list = A.Where(x =>Convert.ToString(x.FatherId).Equals(Tid)).ToList();
            list.ForEach(p =>
            {
                MenuModelView m = new MenuModelView();
                m.label = p.MenuName;
                m.Url = p.Url;
                //m.children =  p.Id.ToString();
                a.Add(m);
            });
            return a;
        }
    }
}
