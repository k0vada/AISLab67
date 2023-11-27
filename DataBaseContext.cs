using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace AISLab67
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext() : base("SchoolDataBase")
        {
        }
        public DbSet<Model.School> Schools { get; set; }
        public DbSet<Model.Direction> Directions { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Model.School>().Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            modelBuilder.Entity<Model.School>().HasMany(p => p.Directions).WithOptional(p => p.School).HasForeignKey(p => p.SchoolId);
            modelBuilder.Entity<Model.Direction>().Property(p => p.Id).HasMaxLength(8);
            modelBuilder.Entity<Model.Direction>().ToTable("Directions");
        }
    }
}
