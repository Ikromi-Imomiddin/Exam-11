using Domain.Entites;
using Microsoft.EntityFrameworkCore;
namespace Infrastructure.Context;
public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //CourseAssignment Many to Many Course/Instructor
        modelBuilder.Entity<CourseAssigment>()
        .HasOne(c => c.Course)
        .WithMany(ca => ca.CourseAssigments)
        .HasForeignKey(ci => ci.CourseId);
        
        modelBuilder.Entity<CourseAssigment>()
        .HasOne(i => i.Instructor)
        .WithMany(ca => ca.CourseAssigments)
        .HasForeignKey(ii => ii.InstructorId);

        //Enrollment Many to Many Course/Student
        modelBuilder.Entity<Entrollment>()
        .HasOne(c => c.Course)
        .WithMany(en => en.Entrollments)
        .HasForeignKey(ci => ci.CourseId);
        
        modelBuilder.Entity<Entrollment>()
        .HasOne(s => s.Student)
        .WithMany(en => en.Entrollments)
        .HasForeignKey(si => si.StudentId);
    }

    public DbSet<Course> Courses { get; set; }
    public DbSet<CourseAssigment> CourseAssignments { get; set; } //Many to Many
    public DbSet<Department> Departments { get; set; }
    public DbSet<Entrollment> Enrollments { get; set; } //Many to Many
    public DbSet<Instructor> Instructors { get; set; }
    public DbSet<OfficeAssignment> OfficeAssignments { get; set; }
    public DbSet<Student> Students { get; set; }
}