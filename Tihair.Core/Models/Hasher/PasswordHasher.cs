using Tihair.Core.Abstractions.Interfaces;

namespace Tihair.Core.Models.Hasher;

public class PasswordHasher : IPasswordHasher
{
    public string Generate(string password) => 
        BCrypt.Net.BCrypt.HashPassword(password);

    public bool Verify(string password, string hash) => 
        BCrypt.Net.BCrypt.Verify(password, hash);
}