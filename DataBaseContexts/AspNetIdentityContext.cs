using Microsoft.EntityFrameworkCore;
using WasWebServerCore.DataBaseModels.AspNetIdentity;

namespace WasWebServerCore.DataBaseContexts
{
    public partial class AspNetIdentityContext : DbContext
    {
        public AspNetIdentityContext()
        {
        }

        public AspNetIdentityContext(DbContextOptions<AspNetIdentityContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AspNetPermissions> AspNetPermissions { get; set; }
        public virtual DbSet<AspNetRolePermission> AspNetRolePermission { get; set; }
        public virtual DbSet<AspNetRoles> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaims> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogins> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUserRoles> AspNetUserRoles { get; set; }
        public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }
        public virtual DbSet<MigrationHistory> MigrationHistory { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=.;Database=JDWheelIdentity;User Id=sa;Password=Kengic@123;");
                //optionsBuilder.UseSqlServer("Server=.;Database=AspNetIdentity;User Id=sa;Password=Kengic@123;");
            }

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AspNetPermissions>(entity =>
            {
                entity.ToTable("AspNetPermissions", "C##WORKBINIDENTITYDATACONTEXT");

                entity.HasIndex(e => e.Name)
                    .HasName("INDEX_REGNUM")
                    .IsUnique();

                entity.Property(e => e.Id).HasMaxLength(128);

                entity.Property(e => e.Name).HasMaxLength(128);
            });

            modelBuilder.Entity<AspNetRolePermission>(entity =>
            {
                entity.HasKey(e => new { e.PermissionId, e.RoleId })
                    .HasName("PK_C##WORKBINIDENTITYDATACONTEXT.AspNetRolePermission");

                entity.ToTable("AspNetRolePermission", "C##WORKBINIDENTITYDATACONTEXT");

                entity.HasIndex(e => e.PermissionId)
                    .HasName("IX_PermissionId");

                entity.HasIndex(e => e.RoleId)
                    .HasName("IX_RoleId");

                entity.Property(e => e.PermissionId).HasMaxLength(128);

                entity.Property(e => e.RoleId).HasMaxLength(256);

                entity.HasOne(d => d.Permission)
                    .WithMany(p => p.AspNetRolePermission)
                    .HasForeignKey(d => d.PermissionId)
                    .HasConstraintName("FK_C##WORKBINIDENTITYDATACONTEXT.AspNetRolePermission_C##WORKBINIDENTITYDATACONTEXT.AspNetPermissions_PermissionId");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetRolePermission)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_C##WORKBINIDENTITYDATACONTEXT.AspNetRolePermission_C##WORKBINIDENTITYDATACONTEXT.AspNetRoles_RoleId");
            });

            modelBuilder.Entity<AspNetRoles>(entity =>
            {
                entity.ToTable("AspNetRoles", "C##WORKBINIDENTITYDATACONTEXT");

                entity.HasIndex(e => e.Name)
                    .HasName("RoleNameIndex")
                    .IsUnique();

                entity.Property(e => e.Id).HasMaxLength(256);

                entity.Property(e => e.Discriminator)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetUserClaims>(entity =>
            {
                entity.ToTable("AspNetUserClaims", "C##WORKBINIDENTITYDATACONTEXT");

                entity.HasIndex(e => e.UserId)
                    .HasName("IX_UserId");

                entity.Property(e => e.ClaimType).HasMaxLength(256);

                entity.Property(e => e.ClaimValue).HasMaxLength(256);

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserClaims)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_C##WORKBINIDENTITYDATACONTEXT.AspNetUserClaims_C##WORKBINIDENTITYDATACONTEXT.AspNetUsers_UserId");
            });

            modelBuilder.Entity<AspNetUserLogins>(entity =>
            {
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey, e.UserId })
                    .HasName("PK_C##WORKBINIDENTITYDATACONTEXT.AspNetUserLogins");

                entity.ToTable("AspNetUserLogins", "C##WORKBINIDENTITYDATACONTEXT");

                entity.HasIndex(e => e.UserId)
                    .HasName("IX_UserId");

                entity.Property(e => e.LoginProvider).HasMaxLength(256);

                entity.Property(e => e.ProviderKey).HasMaxLength(256);

                entity.Property(e => e.UserId).HasMaxLength(256);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserLogins)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_C##WORKBINIDENTITYDATACONTEXT.AspNetUserLogins_C##WORKBINIDENTITYDATACONTEXT.AspNetUsers_UserId");
            });

            modelBuilder.Entity<AspNetUserRoles>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId })
                    .HasName("PK_C##WORKBINIDENTITYDATACONTEXT.AspNetUserRoles");

                entity.ToTable("AspNetUserRoles", "C##WORKBINIDENTITYDATACONTEXT");

                entity.HasIndex(e => e.RoleId)
                    .HasName("IX_RoleId");

                entity.HasIndex(e => e.UserId)
                    .HasName("IX_UserId");

                entity.Property(e => e.UserId).HasMaxLength(256);

                entity.Property(e => e.RoleId).HasMaxLength(256);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_C##WORKBINIDENTITYDATACONTEXT.AspNetUserRoles_C##WORKBINIDENTITYDATACONTEXT.AspNetRoles_RoleId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_C##WORKBINIDENTITYDATACONTEXT.AspNetUserRoles_C##WORKBINIDENTITYDATACONTEXT.AspNetUsers_UserId");
            });

            modelBuilder.Entity<AspNetUsers>(entity =>
            {
                entity.ToTable("AspNetUsers", "C##WORKBINIDENTITYDATACONTEXT");

                entity.HasIndex(e => e.UserName)
                    .HasName("UserNameIndex")
                    .IsUnique();

                entity.Property(e => e.Id).HasMaxLength(256);

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.PasswordHash).HasMaxLength(256);

                entity.Property(e => e.PhoneNumber).HasMaxLength(256);

                entity.Property(e => e.SecurityStamp).HasMaxLength(256);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<MigrationHistory>(entity =>
            {
                entity.HasKey(e => new { e.MigrationId, e.ContextKey })
                    .HasName("PK_C##WORKBINIDENTITYDATACONTEXT.__MigrationHistory");

                entity.ToTable("__MigrationHistory", "C##WORKBINIDENTITYDATACONTEXT");

                entity.Property(e => e.MigrationId).HasMaxLength(150);

                entity.Property(e => e.ContextKey).HasMaxLength(300);

                entity.Property(e => e.Model).IsRequired();

                entity.Property(e => e.ProductVersion)
                    .IsRequired()
                    .HasMaxLength(32);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
