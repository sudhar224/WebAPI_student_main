using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace WebAPI_student.Models
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<tbl_student_marks> tbl_student_marks { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<tbl_student_marks>()
                .Property(e => e.student_name)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_student_marks>()
                .Property(e => e.percentage)
                .HasPrecision(10, 2);
        }
    }
}
