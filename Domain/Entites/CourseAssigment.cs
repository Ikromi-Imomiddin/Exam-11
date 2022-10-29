using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entites;

public class CourseAssigment
{
    public int Id { get; set; }
    [Required, MaxLength(100)]
    public int InstructorId { get; set; }
    public virtual Instructor? Instructor { get; set; }

    public int CourseId { get; set; }
    public virtual Course? Course { get; set; }
}