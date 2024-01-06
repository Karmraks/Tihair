using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tihair.Core.Models
{
    public class User
    {
        [Key]
        public Guid Id { get; set; }

        public string Name { get; set; } = null!;

        public string Password { get; set; } = null!;

        public List<UserRole> UserRoles { get; set; } = null!;
    }
}
