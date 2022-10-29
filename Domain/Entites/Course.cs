using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entites;

public class Course
{
    public int Id { get; set; }
    [Required, MaxLength(100)]
    public string? Title { get; set; }
    public int Credits { get; set; }
    public int DepartmentId { get; set; }
    public virtual Department? Department { get; set; }


    public List<CourseAssigment>? CourseAssigments { get; set; }

    public List<Entrollment>? Entrollments { get; set; }


}