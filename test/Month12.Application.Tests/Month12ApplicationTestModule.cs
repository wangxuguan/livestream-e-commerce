using Volo.Abp.Modularity;

namespace Month12
{
    [DependsOn(
        typeof(Month12ApplicationModule),
        typeof(Month12DomainTestModule)
        )]
    public class Month12ApplicationTestModule : AbpModule
    {

    }
}