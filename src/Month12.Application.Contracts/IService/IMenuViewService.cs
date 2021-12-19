
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Month12.IService
{
    public interface IMenuViewService:Volo.Abp.Application.Services.IApplicationService
    {
        Task<IEnumerable<MenuModelView>> Query(string Tid );
    }
    public class MenuModelView
    {
        public string label { get; set; }

        public string Url { get; set; }

        public List<MenuModelView> children { get; set; }
    }
}
