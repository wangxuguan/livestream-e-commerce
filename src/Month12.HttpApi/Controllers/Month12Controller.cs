using Month12.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Month12.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class Month12Controller : AbpController
    {
        protected Month12Controller()
        {
            LocalizationResource = typeof(Month12Resource);
        }
    }
}