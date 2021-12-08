using System;
using System.Collections.Generic;
using System.Text;
using Month12.Localization;
using Volo.Abp.Application.Services;

namespace Month12
{
    /* Inherit your application services from this class.
     */
    public abstract class Month12AppService : ApplicationService
    {
        protected Month12AppService()
        {
            LocalizationResource = typeof(Month12Resource);
        }
    }
}
