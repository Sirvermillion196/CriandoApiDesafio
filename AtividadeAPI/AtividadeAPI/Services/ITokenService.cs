using AtividadeAPI.Models;

namespace AtividadeAPI.Services
{
    public interface ITokenService
    {
        UserToken BuildToken(UserInfo user);
    }
}
