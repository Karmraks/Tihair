using Tihair.Core.Abstractions.Interfaces;
using Tihair.Core.Models.Dtos;
using Tihair.Core.Models;

namespace Tihair.Core.Abstractions.Extenstions
{
    public static class DemoExtenstion
    {
        public static User ToEntity(this UserDto user, IPasswordHasher passwordHasher)
        {
            return new User()
            {
                Name = user.Name,
                PhoneNumber = user.PhoneNumber,
                PasswordHash = passwordHasher.Generate(user.Password)
            };
        }

        public static UserDto ToDto(this User user)
        {
            return new UserDto()
            {
                Id = user.Id,
                Name = user.Name,
                PhoneNumber = user.PhoneNumber
            };
        }
    }
}
