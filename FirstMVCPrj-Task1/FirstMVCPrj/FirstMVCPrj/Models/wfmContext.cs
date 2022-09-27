using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstMVCPrj.Models
{
    public class wfmContext : DbContext
    {
        #region Constructor
        public wfmContext(DbContextOptions options) : base(options)
        {
        }
        #endregion

        #region Configuration
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            ConfigureModels(modelBuilder);

        }
        #endregion

        //#region Models Configuration
        //protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        //{
        //    base.ConfigureConventions(configurationBuilder);
        //    configurationBuilder.Properties<decimal>().HavePrecision(5, 0);
        //    configurationBuilder.Properties<string>().HaveColumnType("varchar");
        //}

        private static void ConfigureModels(ModelBuilder modelBuilder)
        {
            #region Entity: Skills
            modelBuilder.Entity<Skills>().ToTable("Skills");
            modelBuilder.Entity<Skills>().Property(x => x.Name).IsRequired().HasMaxLength(30);
            #endregion

            #region Entity: Employee
            modelBuilder.Entity<Emp>().ToTable("Employees");
            modelBuilder.Entity<Emp>().Property(x => x.EmpName).IsRequired().HasMaxLength(50);
            modelBuilder.Entity<Emp>().Property(x => x.Status).IsRequired().HasMaxLength(50);
            modelBuilder.Entity<Emp>().Property(x => x.Manager).HasMaxLength(30);
            modelBuilder.Entity<Emp>().Property(x => x.WFMmanager).HasMaxLength(30);
            modelBuilder.Entity<Emp>().Property(x => x.Email);
            modelBuilder.Entity<Emp>().Property(x => x.Lockstatus).HasMaxLength(30);
            modelBuilder.Entity<Emp>().Property(x => x.Experience).HasColumnType("decimal(5,0)");
            modelBuilder.Entity<Emp>().Property(x => x.ProfileID).HasColumnType("decimal(5,0)");
            #endregion

            #region Entity: User
            modelBuilder.Entity<Users>().ToTable("Users");
            modelBuilder.Entity<Users>().Property(x => x.Username).IsRequired().HasMaxLength(30);
            modelBuilder.Entity<Users>().Property(x => x.Password).IsRequired().HasMaxLength(30);
            modelBuilder.Entity<Users>().Property(x => x.Name).IsRequired().HasMaxLength(30);
            modelBuilder.Entity<Users>().Property(x => x.Role).IsRequired().HasMaxLength(30);
            modelBuilder.Entity<Users>().Property(x => x.Email);
            #endregion

            #region Entity: Softlock
            modelBuilder.Entity<Softlock>().ToTable("Softlocks");
            modelBuilder.Entity<Softlock>().Property(x => x.Manager).HasMaxLength(30);
            modelBuilder.Entity<Softlock>().Property(x => x.Reqdate);
            modelBuilder.Entity<Softlock>().Property(x => x.Status).HasMaxLength(30);
            modelBuilder.Entity<Softlock>().Property(x => x.LastUpdated);
            modelBuilder.Entity<Softlock>().Property(x => x.RequestMessage);
            modelBuilder.Entity<Softlock>().Property(x => x.WFMRemark);
            modelBuilder.Entity<Softlock>().Property(x => x.ManagerStatus).HasMaxLength(30).HasDefaultValue("awaiting_approval");
            modelBuilder.Entity<Softlock>().Property(x => x.MGRStatusComments);
            modelBuilder.Entity<Softlock>().Property(x => x.MGRLastUpdate);
            modelBuilder.Entity<Softlock>().HasOne(e => e.Employee).WithMany(b => b.softlocks).HasForeignKey(c => c.EmployeeID).OnDelete(DeleteBehavior.NoAction);
            #endregion

            #region Entity: SkillMap
            modelBuilder.Entity<SkillMap>().ToTable("SkillMaps");
            modelBuilder.Entity<SkillMap>().HasOne(a => a.employee).WithMany(b => b.skillMaps).HasForeignKey(c => c.EmployeeID).OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<SkillMap>().HasOne(a => a.skills).WithMany(b => b.skillMaps).HasForeignKey(c => c.SkillID).OnDelete(DeleteBehavior.NoAction);
            #endregion
        }
        #endregion
    }
}
