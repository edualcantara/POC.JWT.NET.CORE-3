using Authenticator.API.Model;
using IdentityServer4.Services;

namespace Authenticator.API.Services
{
    public class TokenUser : IToken
    {
        IProfileService _profile;

        public TokenUser(IProfileService profile)
        {
            _profile = profile;
        }


        public string GeneratorToken(User user)
        {
            return "teste";
        }
    }
}
