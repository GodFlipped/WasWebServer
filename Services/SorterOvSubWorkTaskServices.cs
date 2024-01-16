using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WasWebServerNew.Context;
using WasWebServerNew.JdWDbModels;

namespace WasWebServerNew.Services
{
    public class SorterOvSubWorkTaskServices
    {
        private readonly JDWWheelContext _wasContext;

        private readonly IDbContextFactory<JDWWheelContext> _dbContextFactory;

        public SorterOvSubWorkTaskServices(JDWWheelContext JDWWheelContext,IDbContextFactory<JDWWheelContext> dbContextFactory)
        {
            _wasContext = JDWWheelContext;
            _dbContextFactory = dbContextFactory;
        }

        public IQueryable<SorterOvSubWorkTask> GetSorterSubWorkTasks(string exector)
        {
            var context = GetDbContext(exector);
            return context.SorterOvSubWorkTasks.AsNoTracking().Where(s => s.Executor == exector);
        }

        public IQueryable<SorterOvSubWorkTask> GetSorterSubWorkTasksOutPut(string exector)
        {
            var context = GetDbContext(exector);
            return context.SorterOvSubWorkTasks.AsNoTracking().Where(s => s.Executor==exector);
        }

        public IQueryable<SorterOvSubWorkTask> GetSorterSubWorkTasks(DateTime createTimeStart, DateTime createTimeEnd,string executor)
        {
            var context = GetDbContext(executor);
            //return context.SorterOvSubWorkTasks.AsNoTracking().Where(s => s.ObjectToHandle != "NOREAD" && s.CreateTime >= createTimeStart && s.CreateTime < createTimeEnd);
            //20230916 by xiaoyang
            return context.SorterOvSubWorkTasks.AsNoTracking().Where(s => s.CreateTime >= createTimeStart && s.CreateTime < createTimeEnd);
        }


        public IQueryable<SorterOvSubWorkTask> GetSuccessSubWorkTask()
        {
            var queryable = _wasContext.SorterOvSubWorkTasks.AsNoTracking().Where(s => !(s.ObjectToHandle == "NOREAD") && !string.IsNullOrEmpty(s.ObjectToHandle)
            && s.Status == 40 && s.RequestShuteAddr != "13" && s.Results == "0");

            return queryable;
        }

        public IQueryable<SorterOvSubWorkTask> GetSuccessSubWorkTask(DateTime start, DateTime end)
        {
            var queryable = _wasContext.SorterOvSubWorkTasks.AsNoTracking().Where(s => s.Code == "ND" && s.Results == "0");

            queryable = queryable.Where(q => q.CreateTime >= start && q.CreateTime <= end);
            return queryable;
        }

        public IQueryable<SorterOvSubWorkTask> GetNRSubWorkTask(DateTime start, DateTime end)
        {
            var queryable = _wasContext.SorterOvSubWorkTasks.AsNoTracking().Where(s => s.Code == "NR");

            queryable = queryable.Where(q => q.CreateTime >= start && q.CreateTime <= end);
            return queryable;
        }

        public IQueryable<SorterOvSubWorkTask> GetMbSubWorkTask(DateTime start, DateTime end)
        {
            var queryable = _wasContext.SorterOvSubWorkTasks.AsNoTracking().Where(s => s.Code == "MB");

            queryable = queryable.Where(q => q.CreateTime >= start && q.CreateTime <= end);
            return queryable;
        }

        public IQueryable<SorterOvSubWorkTask> GetDESubWorkTask(DateTime start, DateTime end)
        {
            var queryable = _wasContext.SorterOvSubWorkTasks.AsNoTracking().Where(s => s.Code == "DE");

            queryable = queryable.Where(q => q.CreateTime >= start && q.CreateTime <= end);
            return queryable;
        }

        public IQueryable<SorterOvSubWorkTask> GetIdSubWorkTask(DateTime start, DateTime end)
        {
            var queryable = _wasContext.SorterOvSubWorkTasks.AsNoTracking().Where(s => s.Code == "ID");

            queryable = queryable.Where(q => q.CreateTime >= start && q.CreateTime <= end);
            return queryable;
        }

        public IQueryable<SorterOvSubWorkTask> GetFailedSubWorkTask(DateTime start, DateTime end)
        {
            var failedList = new List<string> { "NC", "UP", "IL", "DJ", "PF", "DD", "OW", "MT", "GC", "PL", "SF", "CL", "LF", "CO", "CU", "NA" ,"HF"};
            var queryable = _wasContext.SorterOvSubWorkTasks.AsNoTracking().Where(s => (failedList.Contains(s.Code)));

            queryable = queryable.Where(q => q.CreateTime >= start && q.CreateTime <= end);
            return queryable;
        }

        private JDWWheelContext GetDbContext(string exector)
        {
            var dbname = "WasWheelssss";
            var _connString = $"Server=.; Database={dbname};User ID=sa;password=Kengic@123;";
            var context = _dbContextFactory.CreateDbContext();
            context.Database.SetConnectionString(_connString);
            //return new JDWWheelContext(dbname);
            return context;
        }
    }
}
