using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tihair.Core.Models.Dtos;
using Tihair.Core.Models;

namespace Tihair.Core.Abstractions.Extenstions
{
    public static class DemoExtenstion
    {
        public static User ToEntity(this UserDto user)
        {
            return new User()
            {
                Name = user.Name,
                Password = user.Password
            };
        }

        public static UserDto ToDto(this User user)
        {
            return new UserDto()
            {
                Name = user.Name,
                Password = user.Password
            };
        }
    }
}
