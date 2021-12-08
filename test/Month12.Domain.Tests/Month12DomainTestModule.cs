using Month12.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Month12
{
    [DependsOn(
        typeof(Month12EntityFrameworkCoreTestModule)
        )]
    public class Month12DomainTestModule : AbpModule
    {

    }
}