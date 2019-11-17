
namespace _2befit.Models
{
    using _2BeFit.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;

    public partial class RegistrationDBEntities : DbContext
    {
        public RegistrationDBEntities()
            : base("name=DefaultConnection")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Registration>().ToTable("registration");
        }

        public virtual DbSet<Registration> Registartion { get; set; }
    }
}
