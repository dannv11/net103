using BAI_2_2_EF_fLUENT_API.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_2_2_EF_fLUENT_API
{
    public class StudentContext : DbContext
    {
        public StudentContext() : base()
        {

        }

        // Override method OnModelCreating() để cấu hình domain model bằng Fluent API

        /// <summary>
        /// Entity Config
        ///     + ToTable: set table name trong DB
        ///     + haskey: set Primary key
        ///     + hasForeignKey: set ForeignKey
        ///     + HasMany()
        ///     withRequired()
        ///     +hasOptional()
        ///     withOptional()
        ///Properties Config
        /// + HasColumnName: set Column name
        /// + hasColumnOrder: set thứ tự cho cột trong table
        /// + hasColumnType: set datatype cho cột
        /// + hasDatageneratedType: set kiểu gen data cho cột
        /// + hasMaxLength():
        /// + IsOptional()
        /// + IsRequired()
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // base.OnModelCreating(modelBuilder);
            // One to One RelationShip
            modelBuilder.Entity<Student>().HasOptional(x => x.StudentContact)
                                            .WithRequired(x => x.Student);
            modelBuilder.Entity<StudentContact>().HasKey(x => x.StudentId);
            // Cấu hình not null và maxlength cho cột FullName của bảng student
            //IsRequired : not null
            //IsOptional: nullable
            modelBuilder.Entity<Student>().Property(x => x.FullName)
                .IsRequired().HasMaxLength(50);
            //One to many
            modelBuilder.Entity<EduCenter>().HasMany(x => x.Students)
                                        .WithRequired(x => x.EduCenter)
                                        .HasForeignKey(x => x.EduCenterId);
            // Many to Many
            modelBuilder.Entity<Course>().HasMany(x => x.students)
                                        .WithMany(x => x.Courses)
                                        .Map(cs =>
                                        {
                                            cs.MapLeftKey("CourseId");
                                            cs.MapRightKey("StudentID");
                                            cs.ToTable("StudentCourse");
                                        });
        }

        // Add DbSet
        public DbSet<Course> courses { get; set; }
        public DbSet<Student> students { get; set; }
        public DbSet<StudentContact> studentContacts { get; set; }

    }
}
