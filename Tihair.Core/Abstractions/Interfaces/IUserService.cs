using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tihair.Core.Models;

namespace Tihair.Core.Abstractions.Interfaces
{
    public interface IUserService
    {
        Task<User?> Get(User user);
        Task<IEnumerable<User>> GetAll();
        Task Create(User user);
        Task<bool> IsRegistered(User user);
    }
}
