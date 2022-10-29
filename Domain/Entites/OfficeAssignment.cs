using System.ComponentModel.DataAnnotations;

namespace Domain.Entites;

public class OfficeAssignment
{
    public int Id { get; set; }
    [Required, MaxLength(100)]
    public string? Location { get; set; }
    public int Instructor { get; set; }
}
