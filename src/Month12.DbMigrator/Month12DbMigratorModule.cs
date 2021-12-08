﻿using Month12.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace Month12.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(Month12EntityFrameworkCoreModule),
        typeof(Month12ApplicationContractsModule)
        )]
    public class Month12DbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
