namespace SchoolDatabase
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Connection : DbContext
    {
        public Connection()
            : base("name=Connection")
        {
        }

        public virtual DbSet<School> School { get; set; }
        public virtual DbSet<Student> Student { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<School>()
                .Property(e => e.SchoolName)
                .IsFixedLength();

            modelBuilder.Entity<School>()
                .HasMany(e => e.Student)
                .WithRequired(e => e.School)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.FirstName)
                .IsFixedLength();

            modelBuilder.Entity<Student>()
                .Property(e => e.LastName)
                .IsFixedLength();
        }
    }
}
