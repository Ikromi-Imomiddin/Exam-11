using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entites;

public class Instructor
{
    public int Id { get; set; }
    [Required, MaxLength(100)]
    public string? FirstName { get; set; }
    [Required, MaxLength(100)]
    public string? LastName { get; set; }
    [Required]
    public DateTime HireDate { get; set; }

    public List<CourseAssigment>? CourseAssigments { get; set; }

    public List<OfficeAssignment>? OfficeAssignments { get; set; }

    public List<Department>? Departments { get; set; }

    public Instructor()
    {
        HireDate = DateTime.UtcNow;  
    }
}