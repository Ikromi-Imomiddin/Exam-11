using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entites;

public class Student
{
    public int Id { get; set; }
    [Required, MaxLength(100)]
    public string? FirstName { get; set; }
    [Required, MaxLength(100)]
    public string? LastName { get; set; }
    [Required]
    public DateTime EnrollmentDate { get; set; }

    public List<Entrollment>? Entrollments { get; set; }

    public Student()
    {
        EnrollmentDate = DateTime.UtcNow;  
    }
}