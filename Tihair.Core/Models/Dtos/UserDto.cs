using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tihair.Core.Models.Dtos
{
    public class UserDto
    {
        public Guid Id { get; set; }
        public required string Name { get; set; }
        public string Password { get; set; }

        public required string PhoneNumber { get; set; }
    }
}
