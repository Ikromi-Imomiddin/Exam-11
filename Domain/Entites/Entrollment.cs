using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entites;

public class Entrollment
{
    public int Id { get; set; }
    [Required, MaxLength(100)]
    public int CourseId { get; set; }
    public virtual Course? Course { get; set; }
    public int Grade { get; set; }
    public int EntrollmentId { get; set; }

    public int StudentId { get; set; }
    public virtual Student? Student { get; set; }
}