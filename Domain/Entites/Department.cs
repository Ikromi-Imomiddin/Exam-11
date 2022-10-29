using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entites;

public class Department
{
    public int Id { get; set; }
    [Required, MaxLength(100)]
    public string? Budget { get; set; }
    [Required, MaxLength(100)]
    public string? Name { get; set; }
    [Required]
    public DateTime StartDate { get; set; }
    public int InstructorId { get; set; }
    public virtual Instructor? Instructor { get; set; }
    public List<Course>? Courses { get; set; }

     public Department()
    {
        StartDate = DateTime.UtcNow;  
    }
}