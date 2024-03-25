using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tihair.Core.Models;

public class Appointment
{
    [Key]
    public required Guid Id { get; set; }

    [ForeignKey("UserId")]
    public Guid? UserId { get; set; }

    public User? User { get; set; }

    [ForeignKey("AppointmentTypeId")]
    public required Guid AppointmentTypeId { get; set; }
    
    public AppointmentType Type { get; set; }

    public required DateTime StartDate { get; set; }
    
    public required DateTime EndDate { get; set; }
}