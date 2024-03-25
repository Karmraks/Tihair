using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Tihair.Core.Abstractions.Interfaces;
using Tihair.Core.Data;
using Tihair.Core.Models;

namespace Tihair.Core.Repositories
{
    public class UserService(DataContext context) : IUserService
    {
        public async Task Create(User user)
        {
            user.Id = Guid.NewGuid();
            await context.AddAsync(user);
            await context.SaveChangesAsync();
        }

        public async Task<bool> IsRegistered(User user)
        {
            return await context.Users.AnyAsync(u => u.Name == user.Name);
        }

        public async Task<IEnumerable<User>> GetAll()
        {
            return await context.Users.ToListAsync();
        }

        public async Task<User?> Get(User user)
        {
            return await context.Users.FirstOrDefaultAsync(u => u.Name == user.Name && u.PasswordHash == user.PasswordHash);
        }
    }
}
