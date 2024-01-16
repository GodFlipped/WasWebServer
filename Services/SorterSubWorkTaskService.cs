using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WasWebServerNew.Context;
using WasWebServerNew.JdWDbModels;

namespace WasWebServerNew.Services
{
    public class SorterSubWorkTaskService
    {
        private readonly JDWWheelContext _wasContext;
        private readonly IDbContextFactory<JDWWheelContext> _dbContextFactory;

        public SorterSubWorkTaskService(JDWWheelContext JDWWheelContext, IDbContextFactory<JDWWheelContext> dbContextFactory)
        {
            _wasContext = JDWWheelContext;
            _dbContextFactory = dbContextFactory;
        }
        public IQueryable<SorterSubWorkTask> GetSorterSubWorkTasksOutPut(string exector)
        {
            var context = GetDbContext(exector);
            return context.SorterSubWorkTasks.AsNoTracking().Where(s => s.Executor == exector);
        }
        
        public IQueryable<SorterSubWorkTask> GetSorterSubWorkTasks(string exector)
        {
            var context = GetDbContext(exector);
            return context.SorterSubWorkTasks.AsNoTracking().Where(s => s.Executor == exector);
        }
        public IQueryable<SorterSubWorkTask> GetSorterSubWorkTasks()
        {
            return _wasContext.SorterSubWorkTasks.AsNoTracking().Where(s=>s.ObjectToHandle != "NOREAD" && !(s.ReleaseTime==null&&s.Description!="ID"));
        }

        public IQueryable<SorterSubWorkTask> GetSorterSubWorkTasks(DateTime createTimeStart,DateTime createTimeEnd)
        {
            return _wasContext.SorterSubWorkTasks.AsNoTracking().Where(s => s.ObjectToHandle != "NOREAD" && s.CreateTime>=createTimeStart&&s.CreateTime<createTimeEnd&&!(s.ReleaseTime == null && s.Description != "ID"));
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
        public IQueryable<SorterSubWorkTask> GetSorterSubWorkTasks(DateTime createTimeStart, DateTime createTimeEnd, string executor)
        {
            var context = GetDbContext(executor);
            //return context.SorterOvSubWorkTasks.AsNoTracking().Where(s => s.ObjectToHandle != "NOREAD" && s.CreateTime >= createTimeStart && s.CreateTime < createTimeEnd);
            //20230916 by xiaoyang
            return context.SorterSubWorkTasks.AsNoTracking().Where(s => s.CreateTime >= createTimeStart && s.CreateTime < createTimeEnd);
        }

        public IQueryable<SorterSubWorkTask> GetSuccessSubWorkTask()
        {
            var queryable = _wasContext.SorterSubWorkTasks.AsNoTracking().Where(s =>s.ObjectToHandle != "NOREAD" && s.Status == 40 );
            queryable = queryable.Where(q => q.Results != "NR" );
            return queryable;
        }

        public IQueryable<SorterSubWorkTask> GetSuccessSubWorkTask(DateTime start,DateTime end)
        {
            var queryable = _wasContext.SorterSubWorkTasks.AsNoTracking().Where(s=>s.ObjectToHandle != "NOREAD" && s.Status == 40);
            queryable = queryable.Where(q => q.Results != "NR");
            queryable = queryable.Where(q => q.CreateTime >= start && q.CreateTime <= end);
            return queryable;
        }
    }
}
