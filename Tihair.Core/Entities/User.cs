using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Tihair.Core.Models.Enums;

namespace Tihair.Core.Models
{
    public class User
    {
        [Key]
        public Guid Id { get; set; }

        [MaxLength(50)]
        public required string Name { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        [MinLength(9)]
        [MaxLength(9)]
        public required string PhoneNumber { get; set; }

        public string PasswordHash { get; set; }
        
        public AuthorizeRoles AuthorizeRole { get; set; } = AuthorizeRoles.Client;

        public int LevelAccount { get; set; }

        public int AmountOfVisit { get; set; }
    }
}
