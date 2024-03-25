using Microsoft.Extensions.DependencyInjection;
using Tihair.Core.Abstractions.Interfaces;
using Tihair.Core.Models.Hasher;
using Tihair.Core.Repositories;

namespace Infrastructure.Extenstions;

public static class BusinessServiceExtenstions
{
    public static void AddBusinessService(this IServiceCollection services)
    {
        services.AddScoped<IUserService, UserService>();
        services.AddScoped<IPasswordHasher, PasswordHasher>();
        services.AddScoped<IAppointmentService, AppointmentService>();
    }
}