using Microsoft.AspNetCore.Identity;

namespace NZwalk.API.Repositories
{
    public interface ITokenRepository
    {
        string CreateJWTToken(IdentityUser user, List<string> roles);
    }
}
