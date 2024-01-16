using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WasWebServerNew.Context;
using WasWebServerNew.JdWDbModels;

namespace WasWebServerNew.Services
{
    public class SorterDrSubWorkTaskServices
    {
        private readonly JDWWheelContext _wasContext;

        private readonly IDbContextFactory<JDWWheelContext> _dbContextFactory;

        private readonly TenantProvider _tenantProvider;

        public SorterDrSubWorkTaskServices(JDWWheelContext JDWWheelContext,IDbContextFactory<JDWWheelContext> dbContextFactory,TenantProvider tenantProvider)
        {
            _wasContext = JDWWheelContext;
            _dbContextFactory = dbContextFactory;
            _tenantProvider = tenantProvider;
        }

        public IQueryable<SorterDrSubWorkTask> GetSorterSubWorkTasks(string executor)
        {
            var context = GetDbContext(executor);
            return context.SorterDrSubWorkTasks.AsNoTracking().Where(s => s.Executor == executor);
        }

        public IQueryable<SorterDrSubWorkTask> GetSorterSubWorkTasksOutPut(string executor)
        {
            var context = GetDbContext(executor);
            return context.SorterDrSubWorkTasks.AsNoTracking().Where(s => s.Executor==executor);
        }

        public IQueryable<SorterDrSubWorkTask> GetSorterSubWorkTasks(DateTime createTimeStart, DateTime createTimeEnd,string exector)
        {
            var context = GetDbContext(exector);
            return context.SorterDrSubWorkTasks.AsNoTracking().Where(s => s.Executor == exector && s.CreateTime >= createTimeStart && s.CreateTime < createTimeEnd && !(s.ReleaseTime == null && s.Description != "ID"));
        }


        public IQueryable<SorterDrSubWorkTask> GetSuccessSubWorkTask()
        {
            var queryable = _wasContext.SorterDrSubWorkTasks.AsNoTracking().Where(s => s.ObjectToHandle != "NOREAD" && s.Status == 40);
            queryable = queryable.Where(q => q.Results != "NR");
            return queryable;
        }

        public IQueryable<SorterDrSubWorkTask> GetSuccessSubWorkTask(DateTime start, DateTime end)
        {
            var queryable = _wasContext.SorterDrSubWorkTasks.AsNoTracking().Where(s => s.ObjectToHandle != "NOREAD" && s.Status == 40);
            queryable = queryable.Where(q => q.Results != "NR");
            queryable = queryable.Where(q => q.CreateTime >= start && q.CreateTime <= end);
            return queryable;
        }

        private JDWWheelContext GetDbContext(string exector)
        {
            //var dbname = "JdWAS01";
            //if (exector == "RdsClient06" || exector == "RdsClient07" || exector == "RdsClient08" || exector == "RdsClient09" || exector == "RdsClient10")
            //    dbname = "JdWAS02";
            var dbname = "WasWheelssss";
        
            
            var _connString = $"Server=.; Database={dbname};User ID=sa;password=Kengic@123;";
            //if (exector=="NC")
            //{
            //    _connString = $"Server=192.168.5.200; Database=JDNC2;User ID=sa;password=Kengic@123;";
            //}
            _tenantProvider.SetTenant(dbname);
            var context = _dbContextFactory.CreateDbContext();
           context.Database.GetDbConnection().ConnectionString = _connString;
            //return new JDWWheelContext(dbname);
            return context;
        }
    }

    public class TenantProvider
    {
        private string tenant;

        public void SetTenant(string tenant)
        {
            this.tenant = tenant;
            // notify changes
        }

        public string GetTenant() => tenant;

    }
}
