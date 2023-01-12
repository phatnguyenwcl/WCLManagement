using WCLManagement.Infrastructure.Identity;

namespace WCLManagement.Interfaces
{
    public interface ITokenService
    {
        TokenResponse GetToken(TokenRequest token);
    }
}
