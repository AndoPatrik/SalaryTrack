namespace SalaryTrackWebService.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class SalaryTrackDBModel : DbContext
    {
        public SalaryTrackDBModel()
            : base("name=SalaryTrackDBcontext")
        {
        }

        public virtual DbSet<Records> Records { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Records>()
                .Property(e => e.Workplace)
                .IsUnicode(false);

            modelBuilder.Entity<Users>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<Users>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<Users>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Users>()
                .Property(e => e.PW)
                .IsUnicode(false);

            modelBuilder.Entity<Users>()
                .Property(e => e.Workplace)
                .IsUnicode(false);
        }
    }
}
