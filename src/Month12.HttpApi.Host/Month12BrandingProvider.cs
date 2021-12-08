using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace Month12
{
    [Dependency(ReplaceServices = true)]
    public class Month12BrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "Month12";
    }
}
