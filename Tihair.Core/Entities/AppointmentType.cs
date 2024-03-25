using System.ComponentModel.DataAnnotations;

namespace Tihair.Core.Models;

public record AppointmentType
{
    [Key]
    public required Guid Id { get; set; }

    public required string Name { get; set; }
}