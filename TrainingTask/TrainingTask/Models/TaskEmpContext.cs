using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrainingTask.Models
{
    public class TaskEmpContext : DbContext
    {
        #region Constructor
        public TaskEmpContext(DbContextOptions options) : base(options)
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


        private static void ConfigureModels(ModelBuilder modelBuilder)
        {
            #region Entity: Skills
            modelBuilder.Entity<Skills>().ToTable("Skills");           
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

        }
    }
}
