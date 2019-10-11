using Authenticator.API.Model;

namespace Authenticator.API.Services
{
    public interface IToken
    {
        string GeneratorToken(User user);
    }
}