using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Debug;
using WasWebServerNew.JdWDbModels;
using WasWebServerNew.Services;

namespace WasWebServerNew.Context
{
    public partial class JDWWheelContext : DbContext
    {

        public static readonly LoggerFactory LoggerFactory =
          new LoggerFactory(new[] { new DebugLoggerProvider() });
        public string _suffix;

        public string _connString;


        private readonly string tenant = string.Empty;

        //public JDWWheelContext()
        //{
        //   // _connString = $"Server=.; Database=JdWas;User ID=sa;password=Kengic@123;";
        //}


        //public JDWWheelContext(string dbName)
        //{

        //    _connString = $"Server=.; Database={dbName};User ID=sa;password=Kengic@123;";

        //}



        public JDWWheelContext(DbContextOptions<JDWWheelContext> options, TenantProvider tenantProvider)
            : base(options)
        {
            tenant = tenantProvider.GetTenant();
        }


        public virtual DbSet<AlarmEventRecord> AlarmEventRecords { get; set; }
        public virtual DbSet<AlarmEventType> AlarmEventTypes { get; set; }
        public virtual DbSet<BarcodeFilterTemplate> BarcodeFilterTemplates { get; set; }
        public virtual DbSet<BarcodePriorityTemplate> BarcodePriorityTemplates { get; set; }
        public virtual DbSet<Company> Companies { get; set; }
        public virtual DbSet<ComplementSourceWorkTask> ComplementSourceWorkTasks { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<DisplayMessage> DisplayMessages { get; set; }
        public virtual DbSet<FunctionPrivilege> FunctionPrivileges { get; set; }
        public virtual DbSet<Induct> Inducts { get; set; }
        public virtual DbSet<InterfaceSourceWorkTask> InterfaceSourceWorkTasks { get; set; }
        public virtual DbSet<LogicalDestination> LogicalDestinations { get; set; }
        public virtual DbSet<LogicalSorter> LogicalSorters { get; set; }
        public virtual DbSet<MessageDictionary> MessageDictionaries { get; set; }
        public virtual DbSet<MigrationHistory> MigrationHistories { get; set; }
        public virtual DbSet<OperationTracing> OperationTracings { get; set; }
        public virtual DbSet<PackageSourceWorkTask> PackageSourceWorkTasks { get; set; }
        public virtual DbSet<Password> Passwords { get; set; }
        public virtual DbSet<Personnel> Personnels { get; set; }
        public virtual DbSet<PhysicalSorter> PhysicalSorters { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Routing> Routings { get; set; }
        public virtual DbSet<Scanner> Scanners { get; set; }
        public virtual DbSet<SdsSimulationSourceWorkTask> SdsSimulationSourceWorkTasks { get; set; }
        public virtual DbSet<Shute> Shutes { get; set; }
        public virtual DbSet<ShuteStatus> ShuteStatuses { get; set; }
        public virtual DbSet<ShuteType> ShuteTypes { get; set; }
        public virtual DbSet<SorterDeSubWorkTask> SorterDeSubWorkTasks { get; set; }
        
        public virtual DbSet<SorterDrSubWorkTask> SorterDrSubWorkTasks { get; set; }
        public virtual DbSet<SorterExecuteWorkTask> SorterExecuteWorkTasks { get; set; }
        public virtual DbSet<SorterMessageWorkTask> SorterMessageWorkTasks { get; set; }
        public virtual DbSet<SorterOvSubWorkTask> SorterOvSubWorkTasks { get; set; }
        public virtual DbSet<SorterParameter> SorterParameters { get; set; }
        public virtual DbSet<SorterPlan> SorterPlans { get; set; }
        public virtual DbSet<SorterSubWorkTask> SorterSubWorkTasks { get; set; }
        public virtual DbSet<SortingPackage> SortingPackages { get; set; }
        public virtual DbSet<SystemParameter> SystemParameters { get; set; }
        public virtual DbSet<SystemParameterTemplate> SystemParameterTemplates { get; set; }
        public virtual DbSet<SystemSequence> SystemSequences { get; set; }
        public virtual DbSet<Terminal> Terminals { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<VipPackageMessageWorkTask> VipPackageMessageWorkTasks { get; set; }
        public virtual DbSet<VipSourceWorkTask> VipSourceWorkTasks { get; set; }
        public virtual DbSet<WasExecutor> WasExecutors { get; set; }
        public virtual DbSet<Workgroup> Workgroups { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
               
                //optionsBuilder.ReplaceService<IModelCacheKeyFactory, WasCacheFactory>();
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer(_connString);
                optionsBuilder.UseLoggerFactory(LoggerFactory);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AlarmEventRecord>(entity =>
            {
                entity.ToTable("AlarmEventRecords", "WAS");

                entity.Property(e => e.Id).HasMaxLength(256);

                entity.Property(e => e.Code).HasMaxLength(256);

                entity.Property(e => e.Comments).HasMaxLength(256);

                entity.Property(e => e.CreateBy).HasMaxLength(256);

                entity.Property(e => e.Description).HasMaxLength(1024);

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.Object).HasMaxLength(256);

                entity.Property(e => e.Source).HasMaxLength(256);

                entity.Property(e => e.Type).HasMaxLength(256);

                entity.Property(e => e.UpdateBy).HasMaxLength(256);
            });

            modelBuilder.Entity<AlarmEventType>(entity =>
            {
                entity.ToTable("AlarmEventTypes", "WAS");

                entity.Property(e => e.Id).HasMaxLength(256);

                entity.Property(e => e.Code).HasMaxLength(256);

                entity.Property(e => e.Comments).HasMaxLength(256);

                entity.Property(e => e.CreateBy).HasMaxLength(256);

                entity.Property(e => e.Description).HasMaxLength(1024);

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.UpdateBy).HasMaxLength(256);
            });

            modelBuilder.Entity<BarcodeFilterTemplate>(entity =>
            {
                entity.ToTable("BarcodeFilterTemplates", "WAS");

                entity.Property(e => e.Id).HasMaxLength(256);

                entity.Property(e => e.Code).HasMaxLength(256);

                entity.Property(e => e.CreateBy).HasMaxLength(256);

                entity.Property(e => e.Description).HasMaxLength(1024);

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.RegularValue).HasMaxLength(256);

                entity.Property(e => e.UpdateBy).HasMaxLength(256);

                entity.Property(e => e.Value).HasMaxLength(256);
            });

            modelBuilder.Entity<BarcodePriorityTemplate>(entity =>
            {
                entity.ToTable("BarcodePriorityTemplates", "WAS");

                entity.Property(e => e.Id).HasMaxLength(256);

                entity.Property(e => e.Code).HasMaxLength(256);

                entity.Property(e => e.CreateBy).HasMaxLength(256);

                entity.Property(e => e.Description).HasMaxLength(1024);

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.RegularValue).HasMaxLength(256);

                entity.Property(e => e.UpdateBy).HasMaxLength(256);

                entity.Property(e => e.Value).HasMaxLength(256);
            });

            modelBuilder.Entity<Company>(entity =>
            {
                entity.ToTable("Companies", "WAS");

                entity.HasIndex(e => e.ParentId, "IX_ParentId");

                entity.Property(e => e.Id).HasMaxLength(256);

                entity.Property(e => e.AddressCode).HasMaxLength(64);

                entity.Property(e => e.AddressDetail).HasMaxLength(255);

                entity.Property(e => e.Code).HasMaxLength(128);

                entity.Property(e => e.CreateBy).HasMaxLength(128);

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.EmailAddress).HasMaxLength(64);

                entity.Property(e => e.EmailCode).HasMaxLength(60);

                entity.Property(e => e.Fax).HasMaxLength(64);

                entity.Property(e => e.Name).HasMaxLength(255);

                entity.Property(e => e.ParentId).HasMaxLength(256);

                entity.Property(e => e.PhotoLink).HasMaxLength(255);

                entity.Property(e => e.Telephone).HasMaxLength(32);

                entity.Property(e => e.UpdateBy).HasMaxLength(128);

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.InverseParent)
                    .HasForeignKey(d => d.ParentId)
                    .HasConstraintName("FK_WAS.Companies_WAS.Companies_ParentId");
            });

            modelBuilder.Entity<ComplementSourceWorkTask>(entity =>
            {
                entity.ToTable("ComplementSourceWorkTasks", "WAS");

                entity.Property(e => e.Id).HasMaxLength(256);

                entity.Property(e => e.ActiveBy).HasMaxLength(256);

                entity.Property(e => e.AtricleBarcode).HasMaxLength(256);

                entity.Property(e => e.AtricleHeight).HasMaxLength(256);

                entity.Property(e => e.AtricleLength).HasMaxLength(256);

                entity.Property(e => e.AtricleProfile).HasMaxLength(256);

                entity.Property(e => e.AtricleVolume).HasMaxLength(256);

                entity.Property(e => e.AtricleWeight).HasMaxLength(256);

                entity.Property(e => e.AtricleWidth).HasMaxLength(256);

                entity.Property(e => e.CancelledBy).HasMaxLength(256);

                entity.Property(e => e.CarrierId).HasMaxLength(256);

                entity.Property(e => e.Code).HasMaxLength(256);

                entity.Property(e => e.Comments).HasMaxLength(256);

                entity.Property(e => e.ComplementBarcode).HasMaxLength(256);

                entity.Property(e => e.ComplementDestination).HasMaxLength(256);

                entity.Property(e => e.CreateBy).HasMaxLength(256);

                entity.Property(e => e.CurrentShuteAddr).HasMaxLength(256);

                entity.Property(e => e.CurrentShuteAddrX).HasMaxLength(256);

                entity.Property(e => e.CurrentShuteAddrY).HasMaxLength(256);

                entity.Property(e => e.CurrentShuteAddrZ).HasMaxLength(256);

                entity.Property(e => e.CurrentShuteCode).HasMaxLength(256);

                entity.Property(e => e.Description).HasMaxLength(1024);

                entity.Property(e => e.ExecuteWorkTaskId).HasMaxLength(256);

                entity.Property(e => e.Executor).HasMaxLength(128);

                entity.Property(e => e.FinalCarrierId).HasMaxLength(256);

                entity.Property(e => e.Induct).HasMaxLength(256);

                entity.Property(e => e.LogicBarcode).HasMaxLength(256);

                entity.Property(e => e.LogicalSortter).HasMaxLength(256);

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.NodeId).HasMaxLength(256);

                entity.Property(e => e.ObjectToHandle).HasMaxLength(256);

                entity.Property(e => e.OperatorName).HasMaxLength(256);

                entity.Property(e => e.PhysicalSortter).HasMaxLength(256);

                entity.Property(e => e.ReadyBy).HasMaxLength(256);

                entity.Property(e => e.ReleaseBy).HasMaxLength(256);

                entity.Property(e => e.RequestShuteAddr).HasMaxLength(256);

                entity.Property(e => e.RequestShuteAddrA).HasMaxLength(256);

                entity.Property(e => e.RequestShuteAddrB).HasMaxLength(256);

                entity.Property(e => e.RequestShuteAddrC).HasMaxLength(256);

                entity.Property(e => e.RequestShuteAddrL).HasMaxLength(256);

                entity.Property(e => e.RequestShuteAddrM).HasMaxLength(256);

                entity.Property(e => e.RequestShuteAddrN).HasMaxLength(256);

                entity.Property(e => e.RequestShuteAddrX).HasMaxLength(256);

                entity.Property(e => e.RequestShuteAddrY).HasMaxLength(256);

                entity.Property(e => e.RequestShuteAddrZ).HasMaxLength(256);

                entity.Property(e => e.RequestShuteCode).HasMaxLength(256);

                entity.Property(e => e.RequestShuteNum).HasMaxLength(256);

                entity.Property(e => e.Results).HasMaxLength(256);

                entity.Property(e => e.ResumeBy).HasMaxLength(256);

                entity.Property(e => e.Scanner).HasMaxLength(256);

                entity.Property(e => e.ScannerBarcode).HasMaxLength(256);

                entity.Property(e => e.SuspendedBy).HasMaxLength(256);

                entity.Property(e => e.TerminatedBy).HasMaxLength(256);

                entity.Property(e => e.TrackingId).HasMaxLength(256);

                entity.Property(e => e.UpdateBy).HasMaxLength(256);
            });

            modelBuilder.Entity<Department>(entity =>
            {
                entity.ToTable("Departments", "WAS");

                entity.HasIndex(e => e.CompanyId, "IX_CompanyId");

                entity.HasIndex(e => e.ParentId, "IX_ParentId");

                entity.Property(e => e.Id).HasMaxLength(256);

                entity.Property(e => e.Code).HasMaxLength(256);

                entity.Property(e => e.CompanyId).HasMaxLength(256);

                entity.Property(e => e.CreateBy).HasMaxLength(256);

                entity.Property(e => e.Description).HasMaxLength(1024);

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.ParentId).HasMaxLength(256);

                entity.Property(e => e.UpdateBy).HasMaxLength(256);

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Departments)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_WAS.Departments_WAS.Companies_CompanyId");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.InverseParent)
                    .HasForeignKey(d => d.ParentId)
                    .HasConstraintName("FK_WAS.Departments_WAS.Departments_ParentId");
            });

            modelBuilder.Entity<DisplayMessage>(entity =>
            {
                entity.ToTable("DisplayMessages", "WAS");

                entity.Property(e => e.Id).HasMaxLength(256);

                entity.Property(e => e.ActiveBy).HasMaxLength(128);

                entity.Property(e => e.CancelledBy).HasMaxLength(128);

                entity.Property(e => e.Code).HasMaxLength(256);

                entity.Property(e => e.Comments).HasMaxLength(256);

                entity.Property(e => e.CreateBy).HasMaxLength(256);

                entity.Property(e => e.Description).HasMaxLength(1024);

                entity.Property(e => e.DestinationAddress).HasMaxLength(256);

                entity.Property(e => e.Message).HasMaxLength(256);

                entity.Property(e => e.MessageType).HasMaxLength(256);

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.ObjectToHandle).HasMaxLength(256);

                entity.Property(e => e.ReadyBy).HasMaxLength(128);

                entity.Property(e => e.ReleaseBy).HasMaxLength(128);

                entity.Property(e => e.Source).HasMaxLength(256);

                entity.Property(e => e.SourceAddress).HasMaxLength(256);

                entity.Property(e => e.SuspendedBy).HasMaxLength(128);

                entity.Property(e => e.TerminatedBy).HasMaxLength(128);

                entity.Property(e => e.UpdateBy).HasMaxLength(256);
            });

            modelBuilder.Entity<FunctionPrivilege>(entity =>
            {
                entity.ToTable("FunctionPrivileges", "WAS");

                entity.HasIndex(e => e.ParentId, "IX_ParentId");

                entity.Property(e => e.Id).HasMaxLength(256);

                entity.Property(e => e.AuthorizationMask).HasMaxLength(256);

                entity.Property(e => e.Code).HasMaxLength(256);

                entity.Property(e => e.ConditionExpression).HasMaxLength(256);

                entity.Property(e => e.CreateBy).HasMaxLength(256);

                entity.Property(e => e.Description).HasMaxLength(1024);

                entity.Property(e => e.FunObjCatalog).HasMaxLength(256);

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.ParentId).HasMaxLength(256);

                entity.Property(e => e.UpdateBy).HasMaxLength(256);

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.InverseParent)
                    .HasForeignKey(d => d.ParentId)
                    .HasConstraintName("FK_WAS.FunctionPrivileges_WAS.FunctionPrivileges_ParentId");
            });

            modelBuilder.Entity<Induct>(entity =>
            {
                entity.ToTable("Inducts", "WAS");

                entity.Property(e => e.Id).HasMaxLength(256);

                entity.Property(e => e.Code).HasMaxLength(256);

                entity.Property(e => e.CreateBy).HasMaxLength(256);

                entity.Property(e => e.Description).HasMaxLength(1024);

                entity.Property(e => e.LogicalSorter).HasMaxLength(256);

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.PhycialSorter).HasMaxLength(256);

                entity.Property(e => e.UpdateBy).HasMaxLength(256);
            });

            modelBuilder.Entity<InterfaceSourceWorkTask>(entity =>
            {
                entity.ToTable("InterfaceSourceWorkTasks", "WAS");

                entity.Property(e => e.Id).HasMaxLength(256);

                entity.Property(e => e.ActiveBy).HasMaxLength(256);

                entity.Property(e => e.CancelledBy).HasMaxLength(256);

                entity.Property(e => e.Code).HasMaxLength(256);

                entity.Property(e => e.Comments).HasMaxLength(256);

                entity.Property(e => e.CreateBy).HasMaxLength(256);

                entity.Property(e => e.Description).HasMaxLength(1024);

                entity.Property(e => e.ExecuteWorkTaskId).HasMaxLength(256);

                entity.Property(e => e.Executor).HasMaxLength(128);

                entity.Property(e => e.ExpCode).HasMaxLength(256);

                entity.Property(e => e.FinalShuteAddr).HasMaxLength(256);

                entity.Property(e => e.LogicalDestination).HasMaxLength(256);

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.ObjectToHandle).HasMaxLength(256);

                entity.Property(e => e.OpCode).HasMaxLength(256);

                entity.Property(e => e.OperatorName).HasMaxLength(256);

                entity.Property(e => e.ReadyBy).HasMaxLength(256);

                entity.Property(e => e.ReleaseBy).HasMaxLength(256);

                entity.Property(e => e.ResultCode).HasMaxLength(256);

                entity.Property(e => e.Results).HasMaxLength(256);

                entity.Property(e => e.ResumeBy).HasMaxLength(256);

                entity.Property(e => e.ScanTime).HasMaxLength(256);

                entity.Property(e => e.SiteCode).HasMaxLength(256);

                entity.Property(e => e.SuspendedBy).HasMaxLength(256);

                entity.Property(e => e.TerminatedBy).HasMaxLength(256);

                entity.Property(e => e.TrackingId).HasMaxLength(256);

                entity.Property(e => e.UpdateBy).HasMaxLength(256);
            });

            modelBuilder.Entity<LogicalDestination>(entity =>
            {
                entity.ToTable("LogicalDestinations", "WAS");

                entity.Property(e => e.Id).HasMaxLength(256);

                entity.Property(e => e.Code).HasMaxLength(256);

                entity.Property(e => e.CreateBy).HasMaxLength(256);

                entity.Property(e => e.Description).HasMaxLength(1024);

                entity.Property(e => e.DisplayName).HasMaxLength(256);

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.ParentId).HasMaxLength(256);

                entity.Property(e => e.SorterPlan).HasMaxLength(256);

                entity.Property(e => e.UpdateBy).HasMaxLength(256);
            });

            modelBuilder.Entity<LogicalSorter>(entity =>
            {
                entity.ToTable("LogicalSorters", "WAS");

                entity.Property(e => e.Id).HasMaxLength(256);

                entity.Property(e => e.Code).HasMaxLength(256);

                entity.Property(e => e.CreateBy).HasMaxLength(256);

                entity.Property(e => e.Description).HasMaxLength(1024);

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.NodeId).HasMaxLength(256);

                entity.Property(e => e.PhycialSorter).HasMaxLength(256);

                entity.Property(e => e.UpdateBy).HasMaxLength(256);
            });

            modelBuilder.Entity<MessageDictionary>(entity =>
            {
                entity.ToTable("MessageDictionaries", "WAS");

                entity.Property(e => e.Id).HasMaxLength(256);

                entity.Property(e => e.Code).HasMaxLength(256);

                entity.Property(e => e.CreateBy).HasMaxLength(256);

                entity.Property(e => e.Description).HasMaxLength(1024);

                entity.Property(e => e.MessageId).HasMaxLength(256);

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.OperatorName).HasMaxLength(256);

                entity.Property(e => e.UpdateBy).HasMaxLength(256);
            });

            modelBuilder.Entity<MigrationHistory>(entity =>
            {
                entity.HasKey(e => new { e.MigrationId, e.ContextKey })
                    .HasName("PK_WAS.__MigrationHistory");

                entity.ToTable("__MigrationHistory", "WAS");

                entity.Property(e => e.MigrationId).HasMaxLength(150);

                entity.Property(e => e.ContextKey).HasMaxLength(300);

                entity.Property(e => e.Model).IsRequired();

                entity.Property(e => e.ProductVersion)
                    .IsRequired()
                    .HasMaxLength(32);
            });

            modelBuilder.Entity<OperationTracing>(entity =>
            {
                entity.ToTable("OperationTracings", "WAS");

                entity.Property(e => e.Id).HasMaxLength(256);

                entity.Property(e => e.Code).HasMaxLength(256);

                entity.Property(e => e.Comments).HasMaxLength(256);

                entity.Property(e => e.Context).HasMaxLength(256);

                entity.Property(e => e.CreateBy).HasMaxLength(256);

                entity.Property(e => e.Description).HasMaxLength(1024);

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.Object).HasMaxLength(256);

                entity.Property(e => e.ObjectValue).HasMaxLength(256);

                entity.Property(e => e.Operation).HasMaxLength(256);

                entity.Property(e => e.Result).HasMaxLength(256);

                entity.Property(e => e.Source).HasMaxLength(256);

                entity.Property(e => e.UpdateBy).HasMaxLength(256);

                entity.Property(e => e.User).HasMaxLength(256);
            });

            modelBuilder.Entity<PackageSourceWorkTask>(entity =>
            {
                entity.ToTable("PackageSourceWorkTasks", "WAS");

                entity.HasIndex(e => e.CreateTime, "IX_CreateTime");

                entity.HasIndex(e => e.ObjectToHandle, "IX_ObjectToHandle");

                entity.HasIndex(e => e.Status, "IX_Status");

                entity.Property(e => e.Id).HasMaxLength(256);

                entity.Property(e => e.ActiveBy).HasMaxLength(256);

                entity.Property(e => e.BackPrintId).HasMaxLength(256);

                entity.Property(e => e.BoxCode).HasMaxLength(256);

                entity.Property(e => e.BoxType).HasMaxLength(256);

                entity.Property(e => e.CancelledBy).HasMaxLength(256);

                entity.Property(e => e.CategoryText).HasMaxLength(256);

                entity.Property(e => e.Code).HasMaxLength(256);

                entity.Property(e => e.Comments).HasMaxLength(256);

                entity.Property(e => e.CreateBy).HasMaxLength(256);

                entity.Property(e => e.Description).HasMaxLength(1024);

                entity.Property(e => e.ExecuteWorkTaskId).HasMaxLength(256);

                entity.Property(e => e.Executor).HasMaxLength(128);

                entity.Property(e => e.MixBoxTypeText).HasMaxLength(256);

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.ObjectToHandle).HasMaxLength(256);

                entity.Property(e => e.OperatorName).HasMaxLength(256);

                entity.Property(e => e.PackageNumber).HasMaxLength(256);

                entity.Property(e => e.QrCode).HasMaxLength(256);

                entity.Property(e => e.ReadyBy).HasMaxLength(256);

                entity.Property(e => e.ReceiveSiteCode).HasMaxLength(256);

                entity.Property(e => e.ReleaseBy).HasMaxLength(256);

                entity.Property(e => e.Results).HasMaxLength(256);

                entity.Property(e => e.ResumeBy).HasMaxLength(256);

                entity.Property(e => e.RfidCode).HasMaxLength(1024);

                entity.Property(e => e.Router).HasMaxLength(256);

                entity.Property(e => e.RouterNum).HasMaxLength(256);

                entity.Property(e => e.ShuteId).HasMaxLength(256);

                entity.Property(e => e.SiteNo).HasMaxLength(256);

                entity.Property(e => e.SuspendedBy).HasMaxLength(256);

                entity.Property(e => e.TerminatedBy).HasMaxLength(256);

                entity.Property(e => e.UpdateBy).HasMaxLength(256);
            });

            modelBuilder.Entity<Password>(entity =>
            {
                entity.ToTable("Passwords", "WAS");

                entity.HasIndex(e => e.UserId, "IX_UserId");

                entity.Property(e => e.Id).HasMaxLength(256);

                entity.Property(e => e.Code).HasMaxLength(256);

                entity.Property(e => e.CreateBy).HasMaxLength(256);

                entity.Property(e => e.Description).HasMaxLength(1024);

                entity.Property(e => e.HashCode).HasMaxLength(256);

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.PasswordDefine).HasMaxLength(256);

                entity.Property(e => e.UpdateBy).HasMaxLength(256);

                entity.Property(e => e.UserId).HasMaxLength(256);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Passwords)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_WAS.Passwords_WAS.Users_UserId");
            });

            modelBuilder.Entity<Personnel>(entity =>
            {
                entity.ToTable("Personnels", "WAS");

                entity.HasIndex(e => e.DepartmentId, "IX_DepartmentId");

                entity.Property(e => e.Id).HasMaxLength(256);

                entity.Property(e => e.ChineseName).HasMaxLength(256);

                entity.Property(e => e.Code).HasMaxLength(256);

                entity.Property(e => e.Comments).HasMaxLength(256);

                entity.Property(e => e.CompanyTelephone).HasMaxLength(256);

                entity.Property(e => e.CreateBy).HasMaxLength(256);

                entity.Property(e => e.DepartmentId).HasMaxLength(256);

                entity.Property(e => e.Description).HasMaxLength(1024);

                entity.Property(e => e.EnglishName).HasMaxLength(256);

                entity.Property(e => e.MobileNo).HasMaxLength(256);

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.PhotoLink).HasMaxLength(256);

                entity.Property(e => e.PostAddress).HasMaxLength(256);

                entity.Property(e => e.UpdateBy).HasMaxLength(256);

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.Personnel)
                    .HasForeignKey(d => d.DepartmentId)
                    .HasConstraintName("FK_WAS.Personnels_WAS.Departments_DepartmentId");
            });

            modelBuilder.Entity<PhysicalSorter>(entity =>
            {
                entity.ToTable("PhysicalSorters", "WAS");

                entity.Property(e => e.Id).HasMaxLength(256);

                entity.Property(e => e.Code).HasMaxLength(256);

                entity.Property(e => e.CreateBy).HasMaxLength(256);

                entity.Property(e => e.Description).HasMaxLength(1024);

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.UpdateBy).HasMaxLength(256);
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.ToTable("Roles", "WAS");

                entity.Property(e => e.Id).HasMaxLength(256);

                entity.Property(e => e.Code).HasMaxLength(256);

                entity.Property(e => e.CreateBy).HasMaxLength(256);

                entity.Property(e => e.Description).HasMaxLength(1024);

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.UpdateBy).HasMaxLength(256);

                entity.HasMany(d => d.FunctionPrivilegeRefs)
                    .WithMany(p => p.RoleRefs)
                    .UsingEntity<Dictionary<string, object>>(
                        "RoleFunctionPrivilege",
                        l => l.HasOne<FunctionPrivilege>().WithMany().HasForeignKey("FunctionPrivilegeRefId").HasConstraintName("FK_WAS.RoleFunctionPrivilege_WAS.FunctionPrivileges_FunctionPrivilegeRefId"),
                        r => r.HasOne<Role>().WithMany().HasForeignKey("RoleRefId").HasConstraintName("FK_WAS.RoleFunctionPrivilege_WAS.Roles_RoleRefId"),
                        j =>
                        {
                            j.HasKey("RoleRefId", "FunctionPrivilegeRefId").HasName("PK_WAS.RoleFunctionPrivilege");

                            j.ToTable("RoleFunctionPrivilege", "WAS");

                            j.HasIndex(new[] { "FunctionPrivilegeRefId" }, "IX_FunctionPrivilegeRefId");

                            j.HasIndex(new[] { "RoleRefId" }, "IX_RoleRefId");

                            j.IndexerProperty<string>("RoleRefId").HasMaxLength(256);

                            j.IndexerProperty<string>("FunctionPrivilegeRefId").HasMaxLength(256);
                        });
            });

            modelBuilder.Entity<Routing>(entity =>
            {
                entity.ToTable("Routings", "WAS");

                entity.Property(e => e.Id).HasMaxLength(256);

                entity.Property(e => e.BoxSiteCode).HasMaxLength(256);

                entity.Property(e => e.Code).HasMaxLength(128);

                entity.Property(e => e.CreateBy).HasMaxLength(128);

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.LogicalDestination).HasMaxLength(128);

                entity.Property(e => e.Name).HasMaxLength(255);

                entity.Property(e => e.PhycialShute).HasMaxLength(128);

                entity.Property(e => e.SorterPlan).HasMaxLength(128);

                entity.Property(e => e.UpdateBy).HasMaxLength(128);
            });

            modelBuilder.Entity<Scanner>(entity =>
            {
                entity.ToTable("Scanners", "WAS");

                entity.Property(e => e.Id).HasMaxLength(256);

                entity.Property(e => e.Brand).HasMaxLength(256);

                entity.Property(e => e.Code).HasMaxLength(256);

                entity.Property(e => e.CreateBy).HasMaxLength(256);

                entity.Property(e => e.Description).HasMaxLength(1024);

                entity.Property(e => e.LogicalSorter).HasMaxLength(256);

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.PhycialSorter).HasMaxLength(256);

                entity.Property(e => e.UpdateBy).HasMaxLength(256);
            });

            modelBuilder.Entity<SdsSimulationSourceWorkTask>(entity =>
            {
                entity.ToTable("SdsSimulationSourceWorkTasks", "WAS");

                entity.Property(e => e.Id).HasMaxLength(256);

                entity.Property(e => e.ActiveBy).HasMaxLength(256);

                entity.Property(e => e.ArticalBarcode).HasMaxLength(256);

                entity.Property(e => e.CancelledBy).HasMaxLength(256);

                entity.Property(e => e.Code).HasMaxLength(256);

                entity.Property(e => e.Comments).HasMaxLength(256);

                entity.Property(e => e.CreateBy).HasMaxLength(256);

                entity.Property(e => e.Description).HasMaxLength(1024);

                entity.Property(e => e.ExecuteWorkTaskId).HasMaxLength(256);

                entity.Property(e => e.Executor).HasMaxLength(128);

                entity.Property(e => e.FinishQuantity).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.LogicalDestination).HasMaxLength(256);

                entity.Property(e => e.LogisticsBarcode).HasMaxLength(256);

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.ObjectToHandle).HasMaxLength(256);

                entity.Property(e => e.OperatorName).HasMaxLength(256);

                entity.Property(e => e.OrderNo).HasMaxLength(256);

                entity.Property(e => e.PickingQuantity).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ReadyBy).HasMaxLength(256);

                entity.Property(e => e.ReleaseBy).HasMaxLength(256);

                entity.Property(e => e.ReserveQuantity).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Results).HasMaxLength(256);

                entity.Property(e => e.ResumeBy).HasMaxLength(256);

                entity.Property(e => e.Shipment).HasMaxLength(256);

                entity.Property(e => e.SuspendedBy).HasMaxLength(256);

                entity.Property(e => e.TerminatedBy).HasMaxLength(256);

                entity.Property(e => e.UpdateBy).HasMaxLength(256);

                entity.Property(e => e.Wave).HasMaxLength(256);
            });

            modelBuilder.Entity<Shute>(entity =>
            {
                entity.ToTable("Shutes", "WAS");

                entity.Property(e => e.Id).HasMaxLength(256);

                entity.Property(e => e.BackPrintId).HasMaxLength(256);

                entity.Property(e => e.BoxType).HasMaxLength(256);

                entity.Property(e => e.CategoryText).HasMaxLength(256);

                entity.Property(e => e.Code).HasMaxLength(256);

                entity.Property(e => e.CreateBy).HasMaxLength(256);

                entity.Property(e => e.Description).HasMaxLength(1024);

                entity.Property(e => e.DeviceName1).HasMaxLength(256);

                entity.Property(e => e.DeviceName2).HasMaxLength(256);

                entity.Property(e => e.DisplayName).HasMaxLength(256);

                entity.Property(e => e.LogicalSorter).HasMaxLength(256);

                entity.Property(e => e.MixBoxTypeText).HasMaxLength(256);

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.PackageNo).HasMaxLength(256);

                entity.Property(e => e.PhycialSorter).HasMaxLength(256);

                entity.Property(e => e.PrintId).HasMaxLength(256);

                entity.Property(e => e.QrCode).HasMaxLength(256);

                entity.Property(e => e.ReceiveSiteCode).HasMaxLength(256);

                entity.Property(e => e.RfidCode).HasMaxLength(256);

                entity.Property(e => e.Router).HasMaxLength(256);

                entity.Property(e => e.RouterNum).HasMaxLength(256);

                entity.Property(e => e.ShuteType).HasMaxLength(256);

                entity.Property(e => e.SpecialPackageNo).HasMaxLength(256);

                entity.Property(e => e.TagNum).HasMaxLength(256);

                entity.Property(e => e.TheLastPackageNo).HasMaxLength(256);

                entity.Property(e => e.UpdateBy).HasMaxLength(256);
            });

            modelBuilder.Entity<ShuteStatus>(entity =>
            {
                entity.ToTable("ShuteStatus", "WAS");

                entity.Property(e => e.Id).HasMaxLength(256);

                entity.Property(e => e.Code).HasMaxLength(256);

                entity.Property(e => e.CreateBy).HasMaxLength(256);

                entity.Property(e => e.CutoffTimings)
                    .HasMaxLength(256)
                    .HasColumnName("Cutoff_timings");

                entity.Property(e => e.Description).HasMaxLength(1024);

                entity.Property(e => e.DisplayName).HasMaxLength(256);

                entity.Property(e => e.LogicalSorter).HasMaxLength(256);

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.PhycialSorter).HasMaxLength(256);

                entity.Property(e => e.ShuteType).HasMaxLength(256);

                entity.Property(e => e.UpdateBy).HasMaxLength(256);
            });

            modelBuilder.Entity<ShuteType>(entity =>
            {
                entity.ToTable("ShuteTypes", "WAS");

                entity.Property(e => e.Id).HasMaxLength(256);

                entity.Property(e => e.Code).HasMaxLength(256);

                entity.Property(e => e.CreateBy).HasMaxLength(256);

                entity.Property(e => e.Description).HasMaxLength(1024);

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.UpdateBy).HasMaxLength(256);
            });

            modelBuilder.Entity<SorterDeSubWorkTask>(entity =>
            {
                entity.ToTable("SorterDeSubWorkTasks", "WAS");

                entity.HasIndex(e => e.CreateTime, "IX_CreateTime");

                entity.HasIndex(e => e.Status, "IX_Status");

                entity.HasIndex(e => e.TrackingId, "IX_TrackingId");

                entity.Property(e => e.Id).HasMaxLength(256);

                entity.Property(e => e.ActiveBy).HasMaxLength(256);

                entity.Property(e => e.ActivePackageNo).HasMaxLength(256);

                entity.Property(e => e.AtricleBarcode).HasMaxLength(256);

                entity.Property(e => e.CarrierId).HasMaxLength(256);

                entity.Property(e => e.Code).HasMaxLength(256);

                entity.Property(e => e.Comments).HasMaxLength(256);

                entity.Property(e => e.CreateBy).HasMaxLength(256);

                entity.Property(e => e.CurrentShuteAddr).HasMaxLength(256);

                entity.Property(e => e.Description).HasMaxLength(1024);

                entity.Property(e => e.ExecuteWorkTaskId).HasMaxLength(256);

                entity.Property(e => e.Executor).HasMaxLength(128);

                entity.Property(e => e.FinalCarrierId).HasMaxLength(256);

                entity.Property(e => e.LogicalSortter).HasMaxLength(256);

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.ObjectToHandle).HasMaxLength(256);

                entity.Property(e => e.OperatorName).HasMaxLength(256);

                entity.Property(e => e.Results).HasMaxLength(256);

                entity.Property(e => e.SortResultSorter).HasMaxLength(256);

                entity.Property(e => e.SuspendedBy).HasMaxLength(256);

                entity.Property(e => e.TrackingId).HasMaxLength(256);

                entity.Property(e => e.UpdateBy).HasMaxLength(256);
            });

            modelBuilder.Entity<SorterDrSubWorkTask>(entity =>
            {
                entity.ToTable("SorterDrSubWorkTasks", "WAS");

                entity.HasIndex(e => e.CreateTime, "IX_CreateTime");

                entity.HasIndex(e => e.ObjectToHandle, "IX_ObjectToHandle");

                entity.HasIndex(e => e.Status, "IX_Status");

                entity.HasIndex(e => e.TrackingId, "IX_TrackingId");

                entity.Property(e => e.Id).HasMaxLength(256);

                entity.Property(e => e.AtricleBarcode).HasMaxLength(256);

                entity.Property(e => e.AtricleHeight).HasMaxLength(256);

                entity.Property(e => e.AtricleLength).HasMaxLength(256);

               // entity.Property(e => e.AtricleProfile).HasMaxLength(256);

                entity.Property(e => e.AtricleVolume).HasMaxLength(256);

                entity.Property(e => e.AtricleWeight).HasMaxLength(256);

                entity.Property(e => e.AtricleWidth).HasMaxLength(256);

                entity.Property(e => e.CarrierId).HasMaxLength(256);

                entity.Property(e => e.Code).HasMaxLength(256);

                entity.Property(e => e.Comments).HasMaxLength(256);

               // entity.Property(e => e.ComplementBarcode).HasMaxLength(256);

                entity.Property(e => e.CreateBy).HasMaxLength(256);

                entity.Property(e => e.Description).HasMaxLength(1024);

                entity.Property(e => e.ExecuteWorkTaskId).HasMaxLength(256);

                entity.Property(e => e.Executor).HasMaxLength(128);

               // entity.Property(e => e.ExpCode).HasMaxLength(256);

              //  entity.Property(e => e.LogicBarcode).HasMaxLength(256);

                entity.Property(e => e.LogicalSortter).HasMaxLength(256);

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.NodeId).HasMaxLength(256);

                entity.Property(e => e.ObjectToHandle).HasMaxLength(256);

                entity.Property(e => e.OperatorName).HasMaxLength(256);

                entity.Property(e => e.PhysicalSortter).HasMaxLength(256);

                entity.Property(e => e.RequestShuteAddr).HasMaxLength(256);

              //  entity.Property(e => e.RequestShuteAddrL).HasMaxLength(256);

                entity.Property(e => e.RequestShuteAddrX).HasMaxLength(256);

                entity.Property(e => e.RequestShuteAddrY).HasMaxLength(256);

                entity.Property(e => e.RequestShuteAddrZ).HasMaxLength(256);

                entity.Property(e => e.RequestShuteCode).HasMaxLength(256);

                entity.Property(e => e.RequestShuteNum).HasMaxLength(256);

                entity.Property(e => e.Results).HasMaxLength(256);

                entity.Property(e => e.Scanner).HasMaxLength(256);

                entity.Property(e => e.ScannerBarcode).HasMaxLength(500);

              //  entity.Property(e => e.SortResultCode).HasMaxLength(256);

              //  entity.Property(e => e.SortingErrorInfo).HasMaxLength(256);

                entity.Property(e => e.TrackingId).HasMaxLength(256);

                entity.Property(e => e.UpdateBy).HasMaxLength(256);
            });

            modelBuilder.Entity<SorterExecuteWorkTask>(entity =>
            {
                entity.ToTable("SorterExecuteWorkTasks", "WAS");

                entity.HasIndex(e => e.CreateTime, "IX_CreateTime");

                entity.HasIndex(e => e.ObjectToHandle, "IX_ObjectToHandle");

                entity.Property(e => e.Id).HasMaxLength(256);

                entity.Property(e => e.ArticalBarcode).HasMaxLength(256);

                entity.Property(e => e.Code).HasMaxLength(256);

                entity.Property(e => e.Comments).HasMaxLength(256);

                entity.Property(e => e.CreateBy).HasMaxLength(256);

                entity.Property(e => e.Description).HasMaxLength(1024);

                entity.Property(e => e.IndiaClient).HasMaxLength(256);

                entity.Property(e => e.IndiaCn).HasMaxLength(256);

                entity.Property(e => e.IndiaMot).HasMaxLength(256);

                entity.Property(e => e.IndiaNdc).HasMaxLength(256);

                entity.Property(e => e.IndiaOrderId).HasMaxLength(256);

                entity.Property(e => e.IndiaPdd).HasMaxLength(256);

                entity.Property(e => e.IndiaPdt).HasMaxLength(256);

                entity.Property(e => e.IndiaRcn).HasMaxLength(256);

                entity.Property(e => e.IndiaRpdd).HasMaxLength(256);

                entity.Property(e => e.IndiaSt).HasMaxLength(256);

                entity.Property(e => e.IndiaZn).HasMaxLength(256);

                entity.Property(e => e.KengicChute).HasMaxLength(256);

                entity.Property(e => e.LogicalDestination).HasMaxLength(256);

                entity.Property(e => e.LogisticsBarcode).HasMaxLength(256);

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.ObjectToHandle).HasMaxLength(256);

                entity.Property(e => e.OperatorName).HasMaxLength(256);

                entity.Property(e => e.Results).HasMaxLength(256);

                entity.Property(e => e.Shipment).HasMaxLength(256);

                entity.Property(e => e.UpdateBy).HasMaxLength(256);

                entity.Property(e => e.Wave).HasMaxLength(256);
            });

            modelBuilder.Entity<SorterMessageWorkTask>(entity =>
            {
                entity.ToTable("SorterMessageWorkTasks", "WAS");

                entity.HasIndex(e => e.CreateTime, "IX_CreateTime");

                entity.HasIndex(e => e.Status, "IX_Status");

                entity.HasIndex(e => e.TrackingId, "IX_TrackingId");

                entity.Property(e => e.Id).HasMaxLength(256);

                entity.Property(e => e.Code).HasMaxLength(256);

                entity.Property(e => e.Comments).HasMaxLength(256);

                entity.Property(e => e.Connect).HasMaxLength(256);

                entity.Property(e => e.CreateBy).HasMaxLength(256);

                entity.Property(e => e.CurrentShuteAddr).HasMaxLength(256);

                entity.Property(e => e.Description).HasMaxLength(1024);

                entity.Property(e => e.ExecuteWorkTaskId).HasMaxLength(256);

                entity.Property(e => e.Executor).HasMaxLength(128);

                entity.Property(e => e.Induct).HasMaxLength(256);

                entity.Property(e => e.InductMode).HasMaxLength(256);

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.ObjectToHandle).HasMaxLength(256);

                entity.Property(e => e.OperatorName).HasMaxLength(256);

                entity.Property(e => e.Result).HasMaxLength(256);

                entity.Property(e => e.Results).HasMaxLength(256);

                entity.Property(e => e.TrackingId).HasMaxLength(256);

                entity.Property(e => e.UpdateBy).HasMaxLength(256);

                entity.Property(e => e.Weight).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<SorterOvSubWorkTask>(entity =>
            {
                entity.ToTable("SorterOvSubWorkTasks", "WAS");

                entity.HasIndex(e => e.CreateTime, "IX_CreateTime");

                entity.HasIndex(e => e.ObjectToHandle, "IX_ObjectToHandle");

                entity.HasIndex(e => e.Status, "IX_Status");

                entity.HasIndex(e => e.TrackingId, "IX_TrackingId");

                entity.Property(e => e.Id).HasMaxLength(256);

               // entity.Property(e => e.ActiveBy).HasMaxLength(256);

                entity.Property(e => e.AtricleBarcode).HasMaxLength(256);

                entity.Property(e => e.AtricleHeight).HasMaxLength(256);

                entity.Property(e => e.AtricleLength).HasMaxLength(256);

                entity.Property(e => e.AtricleVolume).HasMaxLength(256);

                entity.Property(e => e.AtricleWeight).HasMaxLength(256);

                entity.Property(e => e.AtricleWidth).HasMaxLength(256);

                entity.Property(e => e.CarrierId).HasMaxLength(256);

                entity.Property(e => e.Code).HasMaxLength(256);

                entity.Property(e => e.Comments).HasMaxLength(256);

                entity.Property(e => e.CreateBy).HasMaxLength(256);

                entity.Property(e => e.Description).HasMaxLength(1024);

                entity.Property(e => e.ExecuteWorkTaskId).HasMaxLength(256);

                entity.Property(e => e.Executor).HasMaxLength(128);

               // entity.Property(e => e.ExpCode).HasMaxLength(256);

                entity.Property(e => e.FinalCarrierId).HasMaxLength(256);

                entity.Property(e => e.FinalShuteAddr).HasMaxLength(256);

                entity.Property(e => e.LogicBarcode).HasMaxLength(256);

                entity.Property(e => e.LogicalSortter).HasMaxLength(256);

                entity.Property(e => e.Name).HasMaxLength(256);

               // entity.Property(e => e.NodeId).HasMaxLength(256);

                entity.Property(e => e.ObjectToHandle).HasMaxLength(256);

                entity.Property(e => e.OperatorName).HasMaxLength(256);

                entity.Property(e => e.PhysicalSortter).HasMaxLength(256);

                entity.Property(e => e.RequestShuteAddr).HasMaxLength(256);

                //entity.Property(e => e.RequestShuteAddrL).HasMaxLength(256);

                entity.Property(e => e.RequestShuteAddrX).HasMaxLength(256);

                entity.Property(e => e.RequestShuteAddrY).HasMaxLength(256);

                entity.Property(e => e.RequestShuteAddrZ).HasMaxLength(256);

                entity.Property(e => e.RequestShuteCode).HasMaxLength(256);

                entity.Property(e => e.RequestShuteNum).HasMaxLength(256);

                entity.Property(e => e.Results).HasMaxLength(256);

                entity.Property(e => e.Scanner).HasMaxLength(256);

              //  entity.Property(e => e.ScannerBarcode).HasMaxLength(256);

                entity.Property(e => e.SortResultSorter).HasMaxLength(256);

              //  entity.Property(e => e.SortingErrorInfo).HasMaxLength(256);

                entity.Property(e => e.TrackingId).HasMaxLength(256);

                entity.Property(e => e.UpdateBy).HasMaxLength(256);
            });

            modelBuilder.Entity<SorterParameter>(entity =>
            {
                entity.ToTable("SorterParameters", "WAS");

                entity.Property(e => e.Id).HasMaxLength(256);

                entity.Property(e => e.Code).HasMaxLength(256);

                entity.Property(e => e.ConnectionName).HasMaxLength(256);

                entity.Property(e => e.CreateBy).HasMaxLength(256);

                entity.Property(e => e.Description).HasMaxLength(1024);

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.UpdateBy).HasMaxLength(256);

                entity.Property(e => e.Value).HasMaxLength(256);

                entity.Property(e => e.ValueType).HasMaxLength(256);
            });

            modelBuilder.Entity<SorterPlan>(entity =>
            {
                entity.ToTable("SorterPlans", "WAS");

                entity.Property(e => e.Id).HasMaxLength(256);

                entity.Property(e => e.Code).HasMaxLength(256);

                entity.Property(e => e.CreateBy).HasMaxLength(256);

                entity.Property(e => e.Description).HasMaxLength(1024);

                entity.Property(e => e.LogicalSorter).HasMaxLength(256);

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.SiteNo).HasMaxLength(256);

                entity.Property(e => e.SorterMode).HasMaxLength(256);

                entity.Property(e => e.UpdateBy).HasMaxLength(256);
            });

            modelBuilder.Entity<SorterSubWorkTask>(entity =>
            {
                entity.ToTable("SorterSubWorkTasks", "WAS");

                entity.HasIndex(e => e.CreateTime, "IX_CreateTime");

                entity.HasIndex(e => e.Status, "IX_Status");

                entity.HasIndex(e => e.TrackingId, "IX_TrackingId");

                entity.Property(e => e.Id).HasMaxLength(256);

                entity.Property(e => e.ActiveBy).HasMaxLength(256);

               

                entity.Property(e => e.AtricleBarcode).HasMaxLength(256);

                entity.Property(e => e.AtricleHeight).HasMaxLength(256);

                entity.Property(e => e.AtricleLength).HasMaxLength(256);

                entity.Property(e => e.AtricleProfile).HasMaxLength(256);

                entity.Property(e => e.AtricleVolume).HasMaxLength(10);

                entity.Property(e => e.AtricleWeight).HasMaxLength(10);

                entity.Property(e => e.AtricleWidth).HasMaxLength(256);

                entity.Property(e => e.CancelledBy).HasMaxLength(256);

                

                entity.Property(e => e.Code).HasMaxLength(256);

                entity.Property(e => e.Comments).HasMaxLength(256);

                entity.Property(e => e.ComplementBarcode).HasMaxLength(256);

                entity.Property(e => e.CreateBy).HasMaxLength(256);

                

                entity.Property(e => e.Description).HasMaxLength(1024);

                entity.Property(e => e.ExecuteWorkTaskId).HasMaxLength(256);

                entity.Property(e => e.Executor).HasMaxLength(128);

                entity.Property(e => e.ExpCode).HasMaxLength(256);

                

                entity.Property(e => e.FinalShuteAddr).HasMaxLength(256);

                entity.Property(e => e.FinishPackageNo).HasMaxLength(256);

                

                entity.Property(e => e.LogicalSortter).HasMaxLength(256);

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.NodeId).HasMaxLength(256);

                entity.Property(e => e.ObjectToHandle).HasMaxLength(256);

                entity.Property(e => e.OperatorName).HasMaxLength(256);

                entity.Property(e => e.PhysicalSortter).HasMaxLength(256);

                entity.Property(e => e.ReadyBy).HasMaxLength(256);

                entity.Property(e => e.ReleaseBy).HasMaxLength(256);

                entity.Property(e => e.RequestShuteAddr).HasMaxLength(256);

                

                entity.Property(e => e.RequestShuteCode).HasMaxLength(256);

                

                entity.Property(e => e.Results).HasMaxLength(256);

                entity.Property(e => e.ResumeBy).HasMaxLength(256);

                

                entity.Property(e => e.ScannerBarcode).HasMaxLength(500);

                entity.Property(e => e.SortResultCode).HasMaxLength(256);

                entity.Property(e => e.SortResultSorter).HasMaxLength(256);

                

                entity.Property(e => e.SuspendedBy).HasMaxLength(256);

                entity.Property(e => e.TerminatedBy).HasMaxLength(256);

                entity.Property(e => e.TrackingId).HasMaxLength(256);

                entity.Property(e => e.UpdateBy).HasMaxLength(256);
            });

            modelBuilder.Entity<SortingPackage>(entity =>
            {
                entity.ToTable("SortingPackages", "WAS");

                entity.HasIndex(e => e.CreateTime, "IX_CreateTime");

                entity.HasIndex(e => e.PackageNo, "IX_PackageNo");

                entity.HasIndex(e => e.ShuteId, "IX_ShuteId");

                entity.Property(e => e.Id).HasMaxLength(256);

                entity.Property(e => e.Barcode).HasMaxLength(256);

                entity.Property(e => e.Code).HasMaxLength(256);

                entity.Property(e => e.CreateBy).HasMaxLength(256);

                entity.Property(e => e.Description).HasMaxLength(1024);

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.PackageNo).HasMaxLength(256);

                entity.Property(e => e.ShuteId).HasMaxLength(256);

                entity.Property(e => e.UpdateBy).HasMaxLength(256);
            });

            modelBuilder.Entity<SystemParameter>(entity =>
            {
                entity.ToTable("SystemParameters", "WAS");

                entity.Property(e => e.Id).HasMaxLength(256);

                entity.Property(e => e.Code).HasMaxLength(256);

                entity.Property(e => e.CreateBy).HasMaxLength(256);

                entity.Property(e => e.Description).HasMaxLength(1024);

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.Template).HasMaxLength(256);

                entity.Property(e => e.UpdateBy).HasMaxLength(256);

                entity.Property(e => e.Value).HasMaxLength(256);
            });

            modelBuilder.Entity<SystemParameterTemplate>(entity =>
            {
                entity.ToTable("SystemParameterTemplates", "WAS");

                entity.Property(e => e.Id).HasMaxLength(256);

                entity.Property(e => e.Code).HasMaxLength(256);

                entity.Property(e => e.CreateBy).HasMaxLength(256);

                entity.Property(e => e.Description).HasMaxLength(1024);

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.UpdateBy).HasMaxLength(256);

                entity.Property(e => e.Value).HasMaxLength(256);
            });

            modelBuilder.Entity<SystemSequence>(entity =>
            {
                entity.ToTable("SystemSequences", "WAS");

                entity.Property(e => e.Id).HasMaxLength(256);

                entity.Property(e => e.Code).HasMaxLength(256);

                entity.Property(e => e.CreateBy).HasMaxLength(256);

                entity.Property(e => e.Description).HasMaxLength(1024);

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.Prefix).HasMaxLength(256);

                entity.Property(e => e.UpdateBy).HasMaxLength(256);
            });

            modelBuilder.Entity<Terminal>(entity =>
            {
                entity.ToTable("Terminals", "WAS");

                entity.Property(e => e.Id).HasMaxLength(256);

                entity.Property(e => e.Code).HasMaxLength(256);

                entity.Property(e => e.CreateBy).HasMaxLength(256);

                entity.Property(e => e.Description).HasMaxLength(1024);

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.TerminalIp).HasMaxLength(256);

                entity.Property(e => e.UpdateBy).HasMaxLength(256);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("Users", "WAS");

                entity.HasIndex(e => e.Id, "IX_Id");

                entity.Property(e => e.Id).HasMaxLength(256);

                entity.Property(e => e.Code).HasMaxLength(256);

                entity.Property(e => e.CreateBy).HasMaxLength(256);

                entity.Property(e => e.Description).HasMaxLength(1024);

                entity.Property(e => e.LastAccessIp).HasMaxLength(256);

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.PersonnelId).HasMaxLength(256);

                entity.Property(e => e.PhotoLink).HasMaxLength(256);

                entity.Property(e => e.TerminalEndIpAddress).HasMaxLength(256);

                entity.Property(e => e.TerminalIpAddress).HasMaxLength(256);

                entity.Property(e => e.TerminalStartIpAddress).HasMaxLength(256);

                entity.Property(e => e.UpdateBy).HasMaxLength(256);

                entity.HasOne(d => d.IdNavigation)
                    .WithOne(p => p.User)
                    .HasForeignKey<User>(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WAS.Users_WAS.Personnels_Id");

                entity.HasMany(d => d.FunctionPrivileges)
                    .WithMany(p => p.Users)
                    .UsingEntity<Dictionary<string, object>>(
                        "UserFunctionPrivilege",
                        l => l.HasOne<FunctionPrivilege>().WithMany().HasForeignKey("FunctionPrivilegeId").HasConstraintName("FK_WAS.UserFunctionPrivilege_WAS.FunctionPrivileges_FunctionPrivilegeId"),
                        r => r.HasOne<User>().WithMany().HasForeignKey("UserId").HasConstraintName("FK_WAS.UserFunctionPrivilege_WAS.Users_UserId"),
                        j =>
                        {
                            j.HasKey("UserId", "FunctionPrivilegeId").HasName("PK_WAS.UserFunctionPrivilege");

                            j.ToTable("UserFunctionPrivilege", "WAS");

                            j.HasIndex(new[] { "FunctionPrivilegeId" }, "IX_FunctionPrivilegeId");

                            j.HasIndex(new[] { "UserId" }, "IX_UserId");

                            j.IndexerProperty<string>("UserId").HasMaxLength(256);

                            j.IndexerProperty<string>("FunctionPrivilegeId").HasMaxLength(256);
                        });

                entity.HasMany(d => d.Roles)
                    .WithMany(p => p.Users)
                    .UsingEntity<Dictionary<string, object>>(
                        "UserRole",
                        l => l.HasOne<Role>().WithMany().HasForeignKey("RoleId").HasConstraintName("FK_WAS.UserRole_WAS.Roles_RoleId"),
                        r => r.HasOne<User>().WithMany().HasForeignKey("UserId").HasConstraintName("FK_WAS.UserRole_WAS.Users_UserId"),
                        j =>
                        {
                            j.HasKey("UserId", "RoleId").HasName("PK_WAS.UserRole");

                            j.ToTable("UserRole", "WAS");

                            j.HasIndex(new[] { "RoleId" }, "IX_RoleId");

                            j.HasIndex(new[] { "UserId" }, "IX_UserId");

                            j.IndexerProperty<string>("UserId").HasMaxLength(256);

                            j.IndexerProperty<string>("RoleId").HasMaxLength(256);
                        });

                entity.HasMany(d => d.Terminals)
                    .WithMany(p => p.Users)
                    .UsingEntity<Dictionary<string, object>>(
                        "UserTerminal",
                        l => l.HasOne<Terminal>().WithMany().HasForeignKey("TerminalId").HasConstraintName("FK_WAS.UserTerminal_WAS.Terminals_TerminalId"),
                        r => r.HasOne<User>().WithMany().HasForeignKey("UserId").HasConstraintName("FK_WAS.UserTerminal_WAS.Users_UserId"),
                        j =>
                        {
                            j.HasKey("UserId", "TerminalId").HasName("PK_WAS.UserTerminal");

                            j.ToTable("UserTerminal", "WAS");

                            j.HasIndex(new[] { "TerminalId" }, "IX_TerminalId");

                            j.HasIndex(new[] { "UserId" }, "IX_UserId");

                            j.IndexerProperty<string>("UserId").HasMaxLength(256);

                            j.IndexerProperty<string>("TerminalId").HasMaxLength(256);
                        });

                entity.HasMany(d => d.Workgroups)
                    .WithMany(p => p.Users)
                    .UsingEntity<Dictionary<string, object>>(
                        "UserWorkgroup",
                        l => l.HasOne<Workgroup>().WithMany().HasForeignKey("WorkgroupId").HasConstraintName("FK_WAS.UserWorkgroup_WAS.Workgroups_WorkgroupId"),
                        r => r.HasOne<User>().WithMany().HasForeignKey("UserId").HasConstraintName("FK_WAS.UserWorkgroup_WAS.Users_UserId"),
                        j =>
                        {
                            j.HasKey("UserId", "WorkgroupId").HasName("PK_WAS.UserWorkgroup");

                            j.ToTable("UserWorkgroup", "WAS");

                            j.HasIndex(new[] { "UserId" }, "IX_UserId");

                            j.HasIndex(new[] { "WorkgroupId" }, "IX_WorkgroupId");

                            j.IndexerProperty<string>("UserId").HasMaxLength(256);

                            j.IndexerProperty<string>("WorkgroupId").HasMaxLength(256);
                        });
            });

            modelBuilder.Entity<VipPackageMessageWorkTask>(entity =>
            {
                entity.ToTable("VipPackageMessageWorkTasks", "WAS");

                entity.Property(e => e.Id).HasMaxLength(256);

                entity.Property(e => e.ActiveBy).HasMaxLength(256);

                entity.Property(e => e.CageCode).HasMaxLength(256);

                entity.Property(e => e.CancelledBy).HasMaxLength(256);

                entity.Property(e => e.Code).HasMaxLength(256);

                entity.Property(e => e.Comments).HasMaxLength(256);

                entity.Property(e => e.CreateBy).HasMaxLength(256);

                entity.Property(e => e.Description).HasMaxLength(1024);

                entity.Property(e => e.Executor).HasMaxLength(128);

                entity.Property(e => e.MsgType).HasMaxLength(256);

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.Number).HasMaxLength(256);

                entity.Property(e => e.ObjectToHandle).HasMaxLength(256);

                entity.Property(e => e.OperatorName).HasMaxLength(256);

                entity.Property(e => e.ReadyBy).HasMaxLength(256);

                entity.Property(e => e.ReleaseBy).HasMaxLength(256);

                entity.Property(e => e.Results).HasMaxLength(256);

                entity.Property(e => e.ResumeBy).HasMaxLength(256);

                entity.Property(e => e.ShuteCode).HasMaxLength(256);

                entity.Property(e => e.SuspendedBy).HasMaxLength(256);

                entity.Property(e => e.TerminatedBy).HasMaxLength(256);

                entity.Property(e => e.TheLastCageCode).HasMaxLength(256);

                entity.Property(e => e.TheNewCageCode).HasMaxLength(256);

                entity.Property(e => e.UpdateBy).HasMaxLength(256);

                entity.Property(e => e.Whse).HasMaxLength(256);
            });

            modelBuilder.Entity<VipSourceWorkTask>(entity =>
            {
                entity.ToTable("VipSourceWorkTasks", "WAS");

                entity.Property(e => e.Id).HasMaxLength(256);

                entity.Property(e => e.ActiveBy).HasMaxLength(256);

                entity.Property(e => e.BindingMode).HasMaxLength(256);

                entity.Property(e => e.CageCode).HasMaxLength(256);

                entity.Property(e => e.CancelledBy).HasMaxLength(256);

                entity.Property(e => e.Code).HasMaxLength(256);

                entity.Property(e => e.Comments).HasMaxLength(256);

                entity.Property(e => e.CreateBy).HasMaxLength(256);

                entity.Property(e => e.Cube).HasMaxLength(256);

                entity.Property(e => e.Description).HasMaxLength(1024);

                entity.Property(e => e.ExecuteWorkTaskId).HasMaxLength(256);

                entity.Property(e => e.Executor).HasMaxLength(128);

                entity.Property(e => e.FailReason).HasMaxLength(256);

                entity.Property(e => e.Induction).HasMaxLength(256);

                entity.Property(e => e.MsgType).HasMaxLength(256);

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.ObjectToHandle).HasMaxLength(256);

                entity.Property(e => e.OperatorName).HasMaxLength(256);

                entity.Property(e => e.PackingCode).HasMaxLength(256);

                entity.Property(e => e.ReadyBy).HasMaxLength(256);

                entity.Property(e => e.ReleaseBy).HasMaxLength(256);

                entity.Property(e => e.Results).HasMaxLength(256);

                entity.Property(e => e.ResumeBy).HasMaxLength(256);

                entity.Property(e => e.SuspendedBy).HasMaxLength(256);

                entity.Property(e => e.TerminatedBy).HasMaxLength(256);

                entity.Property(e => e.ToteNbr).HasMaxLength(256);

                entity.Property(e => e.UpdateBy).HasMaxLength(256);

                entity.Property(e => e.WcsDestLocn).HasMaxLength(256);

                entity.Property(e => e.Weight).HasMaxLength(256);

                entity.Property(e => e.Whse).HasMaxLength(256);

                entity.Property(e => e.WmsDestLocn).HasMaxLength(256);

                entity.Property(e => e.WmsMsgid).HasMaxLength(256);
            });

            modelBuilder.Entity<WasExecutor>(entity =>
            {
                entity.ToTable("WasExecutors", "WAS");

                entity.Property(e => e.Id).HasMaxLength(256);

                entity.Property(e => e.Code).HasMaxLength(256);

                entity.Property(e => e.Connection).HasMaxLength(256);

                entity.Property(e => e.CreateBy).HasMaxLength(256);

                entity.Property(e => e.CurrentAddress).HasMaxLength(256);

                entity.Property(e => e.Description).HasMaxLength(1024);

                entity.Property(e => e.ExecuteOperator).HasMaxLength(256);

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.UpdateBy).HasMaxLength(256);
            });

            modelBuilder.Entity<Workgroup>(entity =>
            {
                entity.ToTable("Workgroups", "WAS");

                entity.Property(e => e.Id).HasMaxLength(256);

                entity.Property(e => e.Code).HasMaxLength(256);

                entity.Property(e => e.CreateBy).HasMaxLength(256);

                entity.Property(e => e.Description).HasMaxLength(1024);

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.UpdateBy).HasMaxLength(256);

                entity.HasMany(d => d.Terminals)
                    .WithMany(p => p.Workgroups)
                    .UsingEntity<Dictionary<string, object>>(
                        "WorkgroupTerminal",
                        l => l.HasOne<Terminal>().WithMany().HasForeignKey("TerminalId").HasConstraintName("FK_WAS.WorkgroupTerminal_WAS.Terminals_TerminalId"),
                        r => r.HasOne<Workgroup>().WithMany().HasForeignKey("WorkgroupId").HasConstraintName("FK_WAS.WorkgroupTerminal_WAS.Workgroups_WorkgroupId"),
                        j =>
                        {
                            j.HasKey("WorkgroupId", "TerminalId").HasName("PK_WAS.WorkgroupTerminal");

                            j.ToTable("WorkgroupTerminal", "WAS");

                            j.HasIndex(new[] { "TerminalId" }, "IX_TerminalId");

                            j.HasIndex(new[] { "WorkgroupId" }, "IX_WorkgroupId");

                            j.IndexerProperty<string>("WorkgroupId").HasMaxLength(256);

                            j.IndexerProperty<string>("TerminalId").HasMaxLength(256);
                        });
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
