namespace Tihair.Core.Abstractions.Interfaces;

public interface IPasswordHasher
{
    string Generate(string password);
    bool Verify(string password, string hash);
}